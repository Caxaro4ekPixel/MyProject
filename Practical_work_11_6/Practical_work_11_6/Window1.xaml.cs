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
using System.Windows.Shapes;

namespace Practical_work_11_6
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        List<Maneger> manegers = new List<Maneger>();
        List<Consultant> consultants = new List<Consultant>();
        TempData tempData = new TempData();
        Random random = new Random();
        bool is_worker;

        public Window1(bool is_worker)
        {
            InitializeComponent();
            this.is_worker = is_worker;
            if (is_worker)
                for (int i = 0; i < 10; i++)
                    manegers.Add(new Maneger(
                        lastName: tempData.tempSurName[random.Next(0, 8)],
                        firstName: tempData.tempName[random.Next(0, 8)],
                        midleName: tempData.tempMiddleName[random.Next(0, 8)],
                        phone: tempData.tempPhoneNumber[random.Next(0, 8)],
                        passportNum: tempData.tempPasNumber[random.Next(0, 8)]
                        ));
            else
                for (int i = 0; i < 10; i++)
                    consultants.Add(new Consultant(
                        lastName: tempData.tempSurName[random.Next(0, 8)],
                        firstName: tempData.tempName[random.Next(0, 8)],
                        midleName: tempData.tempMiddleName[random.Next(0, 8)],
                        phone: tempData.tempPhoneNumber[random.Next(0, 8)],
                        passportNum: tempData.tempPasNumber[random.Next(0, 8)]
                        ));
            UpdateDataInGrid();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.is_worker)
                manegers.Add(new Maneger(
                    lastName: tempData.tempSurName[random.Next(0, 8)],
                    firstName: tempData.tempName[random.Next(0, 8)],
                    midleName: tempData.tempMiddleName[random.Next(0, 8)],
                    phone: tempData.tempPhoneNumber[random.Next(0, 8)],
                    passportNum: tempData.tempPasNumber[random.Next(0, 8)]
                    ));
            else
                consultants.Add(new Consultant(
                    lastName: tempData.tempSurName[random.Next(0, 8)],
                    firstName: tempData.tempName[random.Next(0, 8)],
                    midleName: tempData.tempMiddleName[random.Next(0, 8)],
                    phone: tempData.tempPhoneNumber[random.Next(0, 8)],
                    passportNum: tempData.tempPasNumber[random.Next(0, 8)]
                    ));
            UpdateDataInGrid();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            int index = ListBoxUsers.SelectedIndex;
            if (this.is_worker)
            {
                manegers[index].FirstName = tempData.tempName[random.Next(0, 8)];
                manegers[index].LastName = tempData.tempSurName[random.Next(0, 8)];
                manegers[index].MidleName = tempData.tempMiddleName[random.Next(0, 8)];
                manegers[index].Phone = tempData.tempPhoneNumber[random.Next(0, 8)];
                manegers[index].PassportNum = tempData.tempPasNumber[random.Next(0, 8)];
            }
            else
            {
                consultants[index].Phone = tempData.tempPhoneNumber[random.Next(0, 8)];
            }
            UpdateDataInGrid();
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            int index = ListBoxUsers.SelectedIndex;
            if (this.is_worker)
                manegers.Remove(manegers[index]);
            else
                MessageBox.Show("У вас нет прав на удаление!", "Внимание!", MessageBoxButton.OK ,MessageBoxImage.Warning);
            UpdateDataInGrid();
        }

        private void UpdateDataInGrid()
        {
            ListBoxUsers.Items.Clear();
            if (this.is_worker)
                foreach (var i in manegers)
                    ListBoxUsers.Items.Add($"{i.FirstName} {i.LastName} {i.MidleName} {i.Phone} ({i.PassportNum})");
            else
                foreach (var i in consultants)
                    ListBoxUsers.Items.Add($"{i.FirstName} {i.LastName} {i.MidleName} {i.Phone} ({i.PassportNum})");
        }

        private void Button_Click3(object sender, RoutedEventArgs e)
        {
            if (this.is_worker)
                manegers = manegers.OrderBy(o => o.FirstName).ToList();
            else 
                consultants = consultants.OrderBy(o => o.FirstName).ToList();
            UpdateDataInGrid();
        }
    }
}
