﻿using System.Windows.Controls;

namespace NETworkManager.Views.Dialogs
{
    public partial class IPScannerProfileDialog : UserControl
    {
        public IPScannerProfileDialog()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            txtName.Focus();
        }
    }
}
