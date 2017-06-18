#region Usings

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using VkMirea.Network;

#endregion

namespace VkMirea.DialogWindows.ViewModel
{
    public class LoginDialogViewModel : ViewModelBase
    {
        public RelayCommand Login { get; set; }

        private string loginField;

        public LoginDialogViewModel()
        {
            Login = new RelayCommand(OnSignInAsync, OnSignInCanExecute);
        }

        public LoginDialog View { private get; set; }

        public string LoginField
        {
            get => loginField;
            set => Set(ref loginField, value);
        }

        private string PasswordField => View.GetPassword();

        private async void OnSignInAsync()
        {
            var tcpClient = new AppAdapter();
            await tcpClient.Connect("120.0.0.1", 20517); //TODO: Настроить получение IP и Порта из XML-конфига

            var lcp = new LoginClientPackage(LoginField, PasswordField);

            await tcpClient.SendMessageAsync(lcp.ToXml());
        }

        private bool OnSignInCanExecute()
        {
            return !string.IsNullOrEmpty(LoginField) && !string.IsNullOrEmpty(PasswordField);
        }
    }
}