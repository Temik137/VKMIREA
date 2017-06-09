using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using VkMirea.Services;
using VkMirea.ViewModel;

namespace VkMirea
{
    /// <summary>
    /// Interaction logic for MainPage.xaml
    /// </summary>
    public partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            Unloaded += (s, e) => ViewModelLocator.Cleanup();
        }

        private void MainPage_OnLoaded(object sender, RoutedEventArgs e)
        {
            AppNavigationService.NavigationService = NavigationService.GetNavigationService(this);
        }
    }
}
