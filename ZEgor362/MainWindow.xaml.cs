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
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void ButtonRegistration_Click(object sender, RoutedEventArgs e)
        {


            if (TextBoxLogin.Text.Length == 0) return;
            if (PasswordBox.Password.Length == 0) return;

            string login = TextBoxLogin.Text.Trim();
            string pass = PasswordBox.Password.Trim().ToLower();

        }
    }
}
