using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
using Npgsql;

namespace ZEgor362
{
    /// <summary>
    /// Логика взаимодействия для RegistrationPage.xaml
    /// </summary>
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AuthorizationPage());
        }

        private void Reg(object sender, RoutedEventArgs e)
        {
            string login = Login.Text.Trim();
            string password = Password.Password;
            string firstname = FirstName.Text.Trim();   
            string secondname = Secondname.Text.Trim();
            string patronymic = Patronymic.Text.Trim();
            string role = "Student";
            var group = Group.SelectedItem as Group;


            if (login =="" || password == "" || firstname == "" || secondname == "" || patronymic == "" || role == "" || group == null) { }

        }
    }
}
