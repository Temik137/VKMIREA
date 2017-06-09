#region Usings

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using VkMirea.Model;
using VkMirea.ViewModel.Commands;

#endregion

namespace VkMirea.DialogWindows.ViewModel
{
    public class LoginDialogViewModel : ViewModelBase
    {
        private readonly IDataService dataService;

        public RelayCommand Login => AppCommands.SignInCommand;

        public LoginDialogViewModel(IDataService dataService)
        {
            this.dataService = dataService;
        }
    }
}