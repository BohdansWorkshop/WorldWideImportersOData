using System.Linq;
using System.Security.Principal;
using System.Web;
using NLog;

namespace WideWorldImportersService.Authentication
{
    public class CustomAuthenticationProvider
    {
        private static readonly Logger logger = LogManager.GetCurrentClassLogger();
        public static bool Authenticate(HttpContext context)
        {
            //When using HTTPS
            //if (!context.Request.IsSecureConnection)
            //    return false;

            if (!context.Request.Headers.AllKeys.Contains("Authorization"))
            {
                logger.Warn($"Failed headers validation for Application: {HttpContext.Current.User}");
                return false;
            }
        
            string authHeader = context.Request.Headers["Authorization"];

            IPrincipal principal = null;
            if (TryGetPrincipal(authHeader, out principal))
            {
                context.User = principal;
                return true;
            }
            return false;
        }
        private static bool TryGetPrincipal(string authHeader, out IPrincipal principal)
        {

            var protocolParts = authHeader.Split(' ');
            if (protocolParts.Length != 2)
            {
                principal = null;
                return false;
            }
            else if (protocolParts[0] == "Administrator" && protocolParts[1] == "Password")
            {
                principal = new CustomPrincipal(
                    protocolParts[1],
                    "Administrator", "User"
                );
                CurrentUser.currentUser = protocolParts[0];
                logger.Info($"Succeeded credentials validation for user: {protocolParts[0]}");
                return true;
            }
            else if (protocolParts[0] == "User")
            {
                principal = new CustomPrincipal(
                    protocolParts[1],
                    "User"
                );
                CurrentUser.currentUser = protocolParts[0];
                logger.Info($"Succeeded credentials validation for user: {protocolParts[0]}");
                return true;
            }
            else
            {
                logger.Warn($"Failed credentials validation for Application: {HttpContext.Current.User}, UserName:{protocolParts[0]}");
                principal = null;
                return false;
            }
        }
    }
}