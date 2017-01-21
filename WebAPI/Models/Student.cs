using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Student
    {
        public int RollNo { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public char Section { get; set; }
        public string Email { get; set; }
    }
}