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
using VkMirea.Model;

namespace VkMirea
{
    /// <summary>
    /// Interaction logic for DevicePage.xaml
    /// </summary>
    public partial class DevicePage : Page
    {
        public DevicePage()
        {
            InitializeComponent();
        }

        public DevicePage(Device device)
        {
            InitializeComponent();
            DeviceName = device.Name;
            DeviceImagePath = DeviceImagePath;
        }
        
        public string DeviceName
        {
            get { return (string) GetValue(DeviceNameProperty); }
            set { SetValue(DeviceNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DeviceName.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DeviceNameProperty =
            DependencyProperty.Register("DeviceName", typeof(string), typeof(DevicePage), new PropertyMetadata(null));

        public string DeviceImagePath
        {
            get { return (string) GetValue(DeviceImagePathProperty); }
            set { SetValue(DeviceImagePathProperty, value); }
        }

        // Using a DependencyProperty as the backing store for DeviceImagePath.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DeviceImagePathProperty =
            DependencyProperty.Register("DeviceImagePath", typeof(string), typeof(DevicePage), new PropertyMetadata(null));


    }
}
