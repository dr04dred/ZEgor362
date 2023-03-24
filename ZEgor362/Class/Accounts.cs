using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEgor362.Class
{
    public class Accounts
    {
        public Accounts(string login, string password, string firstname, string lastname, string patronymic, string role, string group)
        {
            Login = login;
            Password = password;
            Firstname = firstname;
            Lastname = lastname;
            Patronymic = patronymic;
            Role = role;
            Group = group;

        }
        public string Login { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public string Role { get; set; }
        public string Group { get; set; }

        public Role RoleReference  { get; set; }
        public Group GroupReference { get; set; }
    }
}
