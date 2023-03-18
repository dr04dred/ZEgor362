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

namespace ZEgor362
{
    /// <summary>
    /// Логика взаимодействия для AuthorizationPage.xaml
    /// </summary>
    public partial class AuthorizationPage : Page
    {
        public AuthorizationPage()
        {
            InitializeComponent();
        }
        private void LoginButton(object sender, RoutedEventArgs e)
        {
            if (TextBoxLogin.Text.Length == 0) return;
            if (PassBox.Password.Length == 0) return;

            string login = TextBoxLogin.Text.Trim();
            string pass = PassBox.Password.Trim().ToLower();

            NavigationService.Navigate(new BlankPage());
        }

        private void ButtonRegistration(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new RegistrationPage());
        }
    }

}
