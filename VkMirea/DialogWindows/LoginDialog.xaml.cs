﻿using System;
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
using System.Windows.Shapes;
using VkMirea.DialogWindows.ViewModel;

namespace VkMirea.DialogWindows
{
    /// <summary>
    /// Interaction logic for LoginDialog.xaml
    /// </summary>
    public partial class LoginDialog : Window
    {
        private LoginDialogViewModel ViewModel => DataContext as LoginDialogViewModel;

        public LoginDialog()
        {
            InitializeComponent();
        }

        public LoginDialog(Window owner)
        {
            InitializeComponent();
            this.Owner = owner;
            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs routedEventArgs)
        {
            ViewModel.View = this;
        }

        public string GetPassword()
        {
            return pBox.Password;
        }
    }
}
