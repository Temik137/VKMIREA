using System.Xml.Linq;

namespace VkMirea.Network
{
    public class LoginClientPackage : IClientPackage
    {
        private string logInTryElement;
        private string guidElement;
        private string loginElement;
        private string passwordElement;

        private string guidData;
        private readonly string loginData;
        private readonly string passwordData;

        public LoginClientPackage(string login, string password)
        {
            Initialize();

            loginData = login;
            passwordData = password;
        }
        public void Initialize()
        {
            logInTryElement = "login-try";
            guidElement = "guid";
            loginElement = "login";
            passwordElement = "password";

            guidData = AppContext.AppState.AppGuid.ToString();
        }

        public string ToXml()
        {
            var lte = new XElement(logInTryElement, 
                new XElement(guidElement, guidData),
                new XElement(loginElement, loginData),
                new XElement(passwordElement, passwordData));
            return lte.ToString();
        }
    }
}