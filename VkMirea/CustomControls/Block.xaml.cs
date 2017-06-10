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
using VkMirea.CustomControls.ViewModel;

namespace VkMirea.CustomControls
{
    /// <summary>
    /// Interaction logic for Block.xaml
    /// </summary>
    public partial class Block : UserControl
    {
        public Block()
        {
            InitializeComponent();
        }

        public Block(string text, string img)
        {
            InitializeComponent();
            TitleName = text;
            ImageSource = img;
        }

        public string TitleName
        {
            get { return (string)GetValue(TitleNameProperty); }
            set { SetValue(TitleNameProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Title.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TitleNameProperty =
            DependencyProperty.Register("TitleName", typeof(string), typeof(Block), new PropertyMetadata(null));

        public string ImageSource
        {
            get { return (string)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageSource.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(string), typeof(Block), new PropertyMetadata(null));
        
    }
}
