#region Usings

using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using VkMirea.AppContext;
using VkMirea.Model;
using VkMirea.ViewModel.Commands;

#endregion

namespace VkMirea.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.mvvmlight.net
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;

        private string _welcomeTitle = string.Empty;

        /// <summary>
        /// Gets the WelcomeTitle property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string WelcomeTitle
        {
            get => _welcomeTitle;
            set => Set(ref _welcomeTitle, value);
        }

        #region Commands

        public RelayCommand OpenLoginDialog => AppCommands.OpenLoginDialogWindowCommand;
        public RelayCommand OpenInfoDialog => AppCommands.OpenInfoDialogWindowCommand;
        public RelayCommand GoTrainingMode => AppCommands.GoTrainingModeCommand;
        public RelayCommand GoExamineMode => AppCommands.GoExamineModeCommand;

        #endregion

        public bool IsUnauthorized => AppState.LoginState != LoginState.Authorized;
        public bool IsAuthorized => AppState.LoginState == LoginState.Authorized;

        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}
    }
}