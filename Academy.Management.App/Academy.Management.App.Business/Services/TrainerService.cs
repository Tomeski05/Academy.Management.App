using Academy.Management.App.Business.ServiceModels;
using Academy.Management.App.Domain.Data;
using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Business.Services
{
    public class TrainerService
    {
        public TrainerRepo TrainerRepo = new TrainerRepo();
        public TrainerServiceResult TSR = new TrainerServiceResult();

        public void TrainerServiceInit(Trainer currentTrainer)
        {
            TrainerUi();
            while (!IsValidInput(Console.ReadLine()))
            {
                TrainerUi();
                IsValidInput(Console.ReadLine());
            }
            int trainerChoice = TSR.TrainerInput;
            if (trainerChoice == 1)
            {
                PrintAllStudents();
                Console.WriteLine("Select to see their attending subjects");
                PrintStudentSubjects(Console.ReadLine());
            }
            if (trainerChoice == 2)
            {
                PrintAllSubjects();
            }
        }

        public void TrainerUi()
        {
            Console.WriteLine("1. See all students");
            Console.WriteLine("2. See all subjects");
        }

        public void PrintAllSubjects()
        {
            List<Subject> subjects = TrainerRepo.ReturnAllSubjects();
            List<Student> students = TrainerRepo.ReturnAllStudents();

            for (int i = 0; i < subjects.Count ; i++)
            {
                int studentCount = 0;
                for (int j = 0; j < students.Count; j++)
                {
                    if (students[j].Subjects.Contains(subjects[i]))
                    {
                        studentCount++;
                    }
                }
                Console.WriteLine($"{subjects[i].Name}, students attending: {studentCount}");
            }
        }

        public void PrintAllStudents()
        {
            List<Student> students = TrainerRepo.ReturnAllStudents();
            Console.WriteLine("Select a student to see info");
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {students[i].FirstName} {students[i].LastName}");
            }
        }

        public void PrintStudentSubjects(string input)
        {
            try
            {
                int chosenStudentIndex = int.Parse(input);
                int count = TrainerRepo.ReturnAllStudents().Count;
                if (chosenStudentIndex < 0 || chosenStudentIndex > count)   // kako chosenstudentIndex moze da e pomal od count ?
                {
                    throw new Exception("Invalid student selected, please enter a valid number");
                }
                List<Subject> studentSubjects = TrainerRepo.ReturnStudentSubject(chosenStudentIndex - 1);
                for (int i = 0; i < studentSubjects.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {studentSubjects[i].Name}");
                }
            }
            catch
            {
                Console.WriteLine("Invalid studentselected, please enter a valid number");
            }
        }

        public bool IsValidInput(string input)
        {
            try
            {
                int num = int.Parse(input);
                if (num == 1 || num == 2)
                {
                    TSR.IsValidTrainerInput = true;
                    TSR.TrainerInput = num;
                    return true;
                }
                throw new Exception("Invalid input");
            }
            catch 
            {
                Console.WriteLine("Please enter a valid number");
            }
            return false;
        }
    }
}
