using System;
using System.Web;

namespace WideWorldImportersService.Authentication
{
    public class CustomAuthenticationModule : IHttpModule
    {
        public void Init(HttpApplication context)
        {
            context.AuthenticateRequest +=
               new EventHandler(context_AuthenticateRequest);
        }
        void context_AuthenticateRequest(object sender, EventArgs e)
        {
            HttpApplication app = (HttpApplication)sender;
            if (!CustomAuthenticationProvider.Authenticate(app.Context))
            {
                app.Context.Response.Status = "401 Unauthorized";
                app.Context.Response.StatusCode = 401;
                app.Context.Response.End();
            }
        }
        public void Dispose() { }
    }
}