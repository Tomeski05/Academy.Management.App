using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Business.Services
{
    public class StudentService
    {
        public void ListSubjects(Student student)
        {
            Console.WriteLine("Subjects that you are currently listening: ");
            foreach (KeyValuePair<Subject, int> subject in student.Grades)
            {
                Console.WriteLine($"{subject.Key.Name} Grade: {subject.Value}");
            }
        }
    }
}