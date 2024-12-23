﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Pokemon_Like.MVVM.ViewModel;

namespace Pokemon_Like
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindowVM MainWindowVM { get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MainWindowVM = new MainWindowVM();
            DataContext = MainWindowVM;
        }
    }
}