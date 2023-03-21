using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZEgor362.Class
{
    internal class Answer
    {
        public Answer(int id, string student, string question, string content, string date) 
        {
           Id = id;
           Student = student;
           Question = question;
           Content = content;
           Date = date;
        }

        public int Id { get; set; }
        public string Student { get; set; }
        public string Question { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }
    }
}
