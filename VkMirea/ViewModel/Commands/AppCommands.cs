#region Usings

using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Effects;
using GalaSoft.MvvmLight.CommandWpf;
using VkMirea.AppContext;
using VkMirea.DialogWindows;
using VkMirea.Services;

#endregion

namespace VkMirea.ViewModel.Commands
{
    public static class AppCommands
    {
        #region Commands

        public static RelayCommand SignInCommand => new RelayCommand(OnSignIn);
        public static RelayCommand OpenLoginDialogWindowCommand => new RelayCommand(OnOpenLoginDialogWindow);
        public static RelayCommand OpenInfoDialogWindowCommand => new RelayCommand(OnOpenInfoDialogWindow);
        public static RelayCommand GoTrainingModeCommand => new RelayCommand(OnGoTrainingMode);
        public static RelayCommand GoExamineModeCommand => new RelayCommand(OnGoExamineMode);
        public static RelayCommand GoToMainPageCommand => new RelayCommand(OnGoToMainPage);

        #endregion

        private static void OnGoToMainPage()
        {
            AppNavigationService.NavigationService.Navigate(new Uri("MainPage.xaml", UriKind.RelativeOrAbsolute));
        }

        private static void OnGoExamineMode()
        {
            if (AppState.LoginState != LoginState.Authorized)
            {
                MessageBox.Show(Application.Current.MainWindow, "Для прохождения экзамена необходимо авторизоваться");
                return;
            }

            ChangeAppModeState(ModeState.Examine);
            var chosePage = new ChoosePage();
            ChangeMainWindowContent(chosePage, true);
        }

        private static void OnGoTrainingMode()
        {
            ChangeAppModeState(ModeState.Training);
            var chosePage = new ChoosePage();
            ChangeMainWindowContent(chosePage, true);
        }

        private static void OnSignIn()
        {
            throw new NotImplementedException();
        }

        private static void OnOpenLoginDialogWindow()
        {
            var dialog = new LoginDialog(Application.Current.MainWindow);
            OnShowDialogWithBlackBackground(dialog, out bool? loginAccess);
            if (loginAccess == true)
            {
                AppState.LoginState = LoginState.Authorized;
            }
        }

        private static void OnOpenInfoDialogWindow()
        {
            var dialog = new InfoDialog(Application.Current.MainWindow);
            OnShowDialogWithBlackBackground(dialog);
        }

        private static void ChangeAppModeState(ModeState newModeState)
        {
            AppState.AppModeState = newModeState;
        }

        private static void ChangeMainWindowContent(Page toThisPage)
        {
            AppNavigationService.NavigationService.Navigate(toThisPage);
        }

        private static void ChangeMainWindowContent(Page toThisPage, bool mustClearBackground)
        {
            AppNavigationService.NavigationService.Navigate(toThisPage);

            if (mustClearBackground)
            {
                Application.Current.MainWindow.Background = null;
            }
        }

        private static void OnShowDialogWithBlurBackground(Window dialogWindow, out bool? dialogResult)
        {
            const int blurRadius = 4;
            var blur = new BlurEffect {Radius = blurRadius};

            dialogWindow.Owner.Effect = blur;
            dialogResult = dialogWindow.ShowDialog();
            dialogWindow.Owner.Effect = null;
        }

        private static void OnShowDialogWithBlackBackground(Window dialogWindow, out bool? dialogResult)
        {
            dialogWindow.Owner.OpacityMask = new SolidColorBrush {Color = Colors.Black, Opacity = 0.5};
            dialogResult = dialogWindow.ShowDialog();
            dialogWindow.Owner.OpacityMask = null;
        }

        private static void OnShowDialogWithBlackBackground(Window dialogWindow)
        {
            dialogWindow.Owner.OpacityMask = new SolidColorBrush { Color = Colors.Black, Opacity = 0.5 };
            dialogWindow.ShowDialog();
            dialogWindow.Owner.OpacityMask = null;
        }
    }
}