using SQLite.Net.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Draft.Model
{
    public class Student
    {
        [PrimaryKey, AutoIncrement]
        public int StudentId { get; private set; }
        public string Password { get; set; }
        public string StudentName { get; set; }
        public string DOB { get; set;}
        public string Certificate { get; set; }
    }
}
