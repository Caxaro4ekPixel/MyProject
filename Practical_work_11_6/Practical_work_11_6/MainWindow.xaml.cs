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

namespace Practical_work_11_6
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NextWindow(true);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            NextWindow(false);
        }

        private void NextWindow(bool is_worker) 
        {
            this.Hide();
            Window1 window1 = new Window1(is_worker);
            window1.Show();
        }
    }
}
