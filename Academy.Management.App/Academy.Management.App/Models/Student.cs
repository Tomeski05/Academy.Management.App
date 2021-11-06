using System;
using System.Collections.Generic;
using System.Text;
using Academy.Management.App.Enums;

namespace Academy.Management.App.Models
{
    public class Student : User
    {
        public Student() { }
        public Student(int id, string fname, string lname, string email, string password) 
            : base(id, fname, lname, email, password, Role.Student)
        {

        }
        public Dictionary<Subject, int> Grades { get; set; }
        public List<Subject> Subjects { get; set; }
    }
}
