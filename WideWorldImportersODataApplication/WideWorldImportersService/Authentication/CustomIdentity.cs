using System.Security.Principal;

namespace WideWorldImportersService.Authentication
{
    public class CustomIdentity : IIdentity
    {
        string _name;

        public CustomIdentity(string name)
        {
            this._name = name;
        }

        string IIdentity.AuthenticationType
        {
            get { return "Custom SCHEME"; }
        }

        bool IIdentity.IsAuthenticated
        {
            get { return true; }
        }

        string IIdentity.Name
        {
            get { return _name; }
        }
    }
}