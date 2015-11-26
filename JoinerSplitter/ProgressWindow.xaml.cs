﻿using System.Windows;

namespace JoinerSplitter
{
    /// <summary>
    /// Interaction logic for ProgressWindow.xaml
    /// </summary>
    partial class ProgressWindow : Window
    {
        ProgressWindow()
        {
            InitializeComponent();
        }
        public static ProgressWindow Show(Window owner)
        {
            var dlg = new ProgressWindow();
            dlg.Owner = owner;
            dlg.Show();
            return dlg;
        }
    }
}
