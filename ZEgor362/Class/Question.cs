using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEgor362.Class
{
    internal class Question
    {
        public Question(int id_question, string type, string from, string content ) 
        {
            Id_Question = id_question;
            Type = type;
            From = from;
            Content = content;
        }
            public int Id_Question { get; set; }
            public string Type { get; set; }
            public string From { get; set; }
            public string Content { get; set; }
    }
}
