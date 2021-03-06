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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDataBinding
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private readonly Student _stu;
        public MainWindow()
        {
            InitializeComponent();
            _stu = new Student()
            {
                Name = "Alice",
                Age = 30
            };
            DataContext = _stu;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _stu.Name = "Rob";
            _stu.Age = 35;
        }
    }
}
