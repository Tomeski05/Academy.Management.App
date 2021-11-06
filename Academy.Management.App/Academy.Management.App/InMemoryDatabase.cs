using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App
{
    public static class InMemoryDatabase
    {
        public static List<Admin> Admins { get; set; }
        public static List<Trainer> Trainers { get; set; }
        public static List<Student> Students { get; set; }
        public static List<Subject> Subjects { get; set; }

        static InMemoryDatabase()
        {
            Subjects = GenerateSubjects();
            Admins = GenerateAdmins();
            Trainers = GenerateTrainers();
            Students = GenerateStudents();
        }

        private static List<Subject> GenerateSubjects()
        {
            List<Subject> subjects = new List<Subject>
            {
                new Subject() {
                    Name = "c# Basic",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 11, 15),
                    StartOn = new DateTime(2020, 11, 10)
                },
                new Subject() {
                    Name = "c# Advanced",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 10, 15),
                    StartOn = new DateTime(2020, 10, 10)
                },
                new Subject()
                {
                    Name = "JavaScript Advanced",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 03, 15),
                    StartOn = new DateTime(2020, 03, 10)
                },
                new Subject()
                {
                    Name = "JavaScript Basic",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 05, 15),
                    StartOn = new DateTime(2020, 05, 10)
                },
                new Subject()
                {
                    Name = "Html",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 02, 15),
                    StartOn = new DateTime(2020, 02, 10)
                },
                new Subject()
                {
                    Name = "Css",
                    IsOptional = false,
                    NumberOfClasses = 10,
                    EndOn = new DateTime(2021, 06, 15),
                    StartOn = new DateTime(2020, 06, 10)
                },
            };
            return subjects;
        }
        private static List<Student> GenerateStudents()
        {
            List<Student> listOfStudents = new List<Student>
            {
                new Student(1, "Filip", "Tomeski", "filip@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[0], Subjects[1], Subjects[3] }},
                new Student(2, "Dori", "Doritos", "dori@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[2], Subjects[3], Subjects[1] }},
                new Student(3, "Josh", "Joshua", "josh@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[3], Subjects[2], Subjects[1] }},
                new Student(4, "Jean", "Money", "jean@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[2], Subjects[1], Subjects[3] }},
                new Student(5, "Bob", "Bobsky", "bob@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[1], Subjects[4], Subjects[2] }},
                new Student(6, "John", "Johnsky", "john@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[4], Subjects[2], Subjects[1] }},
                new Student(7, "Jen", "Jensky", "fJen@mail.com", "asd123") { Subjects = new List<Subject> { Subjects[0], Subjects[3], Subjects[1] }}, 
            };

            return listOfStudents;
        }
        private static List<Trainer> GenerateTrainers()
        {
            List<Trainer> listOfTrainer = new List<Trainer>
            {
                new Trainer(1, "Filip", "Tomeski", "filip@mqil.com", "123asd"), 
                new Trainer(2, "Bob", "Bobsky", "bob@mqil.com", "123asd"), 
            };

            return listOfTrainer;
        }
        private static List<Admin> GenerateAdmins()
        {
            List<Admin> listOfAdmin = new List<Admin>
            {
                new Admin(1, "admin", "admin", "admin@mail.com", "123asd"),
                new Admin(1, "admin", "admin", "admin@mail.com", "123asd")
            };

            return listOfAdmin;
        }
    }
}
