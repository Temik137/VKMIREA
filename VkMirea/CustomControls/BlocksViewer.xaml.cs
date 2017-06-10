using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
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

namespace VkMirea.CustomControls
{
    /// <summary>
    /// Interaction logic for BlocksViewer.xaml
    /// </summary>
    public partial class BlocksViewer : UserControl
    {
        public BlocksViewer()
        {
            InitializeComponent();
        }

        public ObservableCollection<Instrument> ItemsSource
        {
            get { return (ObservableCollection<Instrument>)GetValue(ItemsSourceProperty); }
            set { SetValue(ItemsSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ItemsSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ItemsSourceProperty =
            DependencyProperty.Register("ItemsSource", typeof(ObservableCollection<Instrument>), typeof(BlocksViewer), new PropertyMetadata(null));


    }
}
