using System.Diagnostics;
using System.Windows;
using GalaSoft.MvvmLight.Threading;

namespace VkMirea
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            DispatcherHelper.Initialize();
        }

        /// <summary>
        /// Entry point after app is loaded.
        /// </summary>
        /// <param name="e">Command line arguments</param>
        private void App_OnStartup(object sender, StartupEventArgs e)
        {
            
        }
    }
}
