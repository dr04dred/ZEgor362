using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZEgor362.Class
{
    public class DataLoader
    {
        public static ObservableCollection<Role> Roles { get; set; }
        public static ObservableCollection<Class> Groups { get; set; }
        public static ObservableCollection<QuestionType> QuestionTypes { get; set; }

        public static void Load()
        {
            if (Roles == null)
                Roles = new ObservableCollection<Role>();
            if (Groups == null)
                Groups = new ObservableCollection<Class>();
            if (QuestionTypes == null)
                QuestionTypes = new ObservableCollection<QuestionType>();

           // RegistrationPage.GetList(Groups);
            //BlankPage.GetType(QuestionTypes);
        }
        
    }
}
