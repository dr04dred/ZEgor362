using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEgor362.Class
{
    public class Cash
    {
        private static ObservableCollection<Accounts> accounts { get; set; }
        private static ObservableCollection<Answer> answers { get; set; }
        private static ObservableCollection<Form> forms { get; set; }
        private static ObservableCollection<Group> groups { get; set; }
        private static ObservableCollection<Question> questions { get; set; }
        private static ObservableCollection<QuestionType> questionTypes { get; set; }
        private static ObservableCollection<Role> roles { get; set; }

        public static ObservableCollection<Accounts> Accounts { get { return accounts; } }
        public static ObservableCollection<Answer> Answers { get { return answers; } }
        public static ObservableCollection<Form> Forms { get { return forms; } }
        public static ObservableCollection<Group> Groups { get { return groups; } }
        public static ObservableCollection<Question> Questions { get { return questions; } }
        public static ObservableCollection<QuestionType> QuestionTypes { get { return questionTypes; } }
        public static ObservableCollection<Role> Roles { get { return roles; } }

        // разобраться для чего используется load у Афонасьева.
        //public static Connection Connection
        //{
        //    set
        //    {
        //        Connection = value;
        //        load();
        //    }
        //}
    }
}
