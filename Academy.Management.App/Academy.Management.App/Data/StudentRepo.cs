using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy.Management.App.Domain.Data
{
    public class StudentRepo
    {
        public Student ReturnCurrentStudent(Student currentStudent)
        {
            return InMemoryDatabase.Students.First(student => student == currentStudent);
        }
    }
}
