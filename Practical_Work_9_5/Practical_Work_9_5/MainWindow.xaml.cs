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

namespace Practical_Work_9_5
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonTask2_Click(object sender, RoutedEventArgs e)
        {
            LableTask2.Content = string.Join(" ", TextBox1.Text.Split(' ').Reverse().ToArray());
        }

        private void ButtonTask1_Click(object sender, RoutedEventArgs e)
        {
            ListboxTask1.ItemsSource = TextBox1.Text.Split(' ');
        }
    }
}
