using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ZEgor362.Class
{
    internal class Class
    {
        public Class(string name_class) 
        {

            Group = name_class;

        }
        public string Group { get; set; }
    }
}
