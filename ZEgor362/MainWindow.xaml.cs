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
using NpgsqlTypes;
using ZEgor362.Class;

namespace ZEgor362
{
    public partial class MainWindow : Window
    {
        public static string host = "10.14.206.28";
        public static int port = 5432;
        public static string user = "student";
        public static string pass = "1234";
        public static string ddatabase = "postgres";



        //private Connection connection = new Connection();

        public MainWindow()
        {
            InitializeComponent();
            Connection.Connecting(host.ToString(),port,user.ToString(),pass.ToString(), ddatabase.ToString());
            PrimaryPage.Navigate(new AuthorizationPage());
        }

       
    }
}
