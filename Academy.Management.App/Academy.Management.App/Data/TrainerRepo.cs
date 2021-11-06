using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Domain.Data
{
    public class TrainerRepo
    {
        public List<Student> ReturnAllStudents()
        {
            return InMemoryDatabase.Students;
        }
        public List<Subject> ReturnAllSubjects()
        {
            return InMemoryDatabase.Subjects;
        }
        public List<Subject> ReturnStudentSubject(int studentByIndex)
        {
            return InMemoryDatabase.Students[studentByIndex].Subjects;
        }
    }
}
