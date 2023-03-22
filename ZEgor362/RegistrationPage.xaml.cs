using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using NpgsqlTypes;
using ZEgor362.Class;

namespace ZEgor362
{
    
    public partial class RegistrationPage : Page
    {
        public RegistrationPage()
        {
            InitializeComponent();

            DataLoader.Load();

            Group.SetBinding(ItemsControl.ItemsSourceProperty, new Binding()
           {
                Source = DataLoader.Groups
           });
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
            var group = Group.SelectedItem as Class.Group;


            if (login == "" || password == "" || firstname == "" || secondname == "" || patronymic == "" || group == null) return;

            var command = Connection.ExecuteComand(" INSERT INTO \"account\" VALUES(@a, @b, @c, @e, @f, @g)");
            command.Parameters.AddWithValue("@a", NpgsqlDbType.Varchar,login);
            command.Parameters.AddWithValue("@b", NpgsqlDbType.Varchar,password);
            command.Parameters.AddWithValue("@c", NpgsqlDbType.Varchar, firstname);
            command.Parameters.AddWithValue("@d", NpgsqlDbType.Varchar, secondname);
            command.Parameters.AddWithValue("@e", NpgsqlDbType.Varchar, patronymic);
            command.Parameters.AddWithValue("@f", NpgsqlDbType.Varchar, "Student");
            command.Parameters.AddWithValue("@g", NpgsqlDbType.Varchar, group.Groups );

            var result = command.ExecuteNonQuery();
            if (result == 1) return;
                DataLoader.Load();

            Login.Clear();
            Password.Clear();
            FirstName.Clear();
            Secondname.Clear();
            Patronymic.Clear();

        }

        public static void GetList(ObservableCollection<Class. Group> List)
        {
            var command = Connection.ExecuteComand("SELECT \"name_class\" FROM \"class\"");

            var result = command.ExecuteReader();
            if (result.HasRows)
            {
                List.Clear();
                while (result.Read())
                {
                    List.Add(new Class.Group(result.GetString(0)));
                }
            }
            result.Close();
        }

    }
}
