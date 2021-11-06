using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Academy.Management.App.Domain.Data
{
    public class AdminRepo
    {
        public bool AddStudent(Student newStudent)
        {
            int count = InMemoryDatabase.Students.Count();
            Student MailInUse = InMemoryDatabase.Students.FirstOrDefault(student => student.Email == newStudent.Email);
            if (MailInUse == null)
            {
                InMemoryDatabase.Students.Add(newStudent);
                Console.WriteLine("Init...");
            }
            if (count != InMemoryDatabase.Students.Count())
            {
                Console.WriteLine($"Added student {newStudent.Email}");
                return true;
            }
            Console.WriteLine($"Email already in use");
            return false;
        }
        public bool RemoveStudent(string numberInList)
        {
            try
            {
                int choice = int.Parse(numberInList);
                if (choice < 1 || choice > InMemoryDatabase.Students.Count)
                {
                    throw new Exception("Invalid user entered");
                }
                Console.WriteLine($"Sucessfuly removed student {InMemoryDatabase.Students[choice - 1].FirstName}");
                return InMemoryDatabase.Students.Remove(InMemoryDatabase.Students[choice - 1]); // method returns true or false..
            }
            catch
            {
                Console.WriteLine("User not found");
            }
            return false;
        }
        public bool AddTrainer(Trainer newTrainer)
        {
            int count = InMemoryDatabase.Trainers.Count();
            Trainer MailInUse = InMemoryDatabase.Trainers.FirstOrDefault(trainer => trainer.Email == newTrainer.Email);
            if (MailInUse == null)
            {
                InMemoryDatabase.Trainers.Add(newTrainer);
                Console.WriteLine("Init...");
            }
            if (count != InMemoryDatabase.Trainers.Count())
            {
                Console.WriteLine($"Added trainer {newTrainer.Email}");
                return true;
            }
            Console.WriteLine($"Email already in use");
            return false;
        }
        public bool RemoveTrainer(string trainer)
        {
            try
            {
                int choice = int.Parse(trainer);
                if (choice < 1 || choice > InMemoryDatabase.Students.Count)
                {
                    throw new Exception("Invalid user entered");
                }
                Console.WriteLine($"Sucessfuly removed trainer {InMemoryDatabase.Trainers[choice - 1].FirstName}");
                return InMemoryDatabase.Trainers.Remove(InMemoryDatabase.Trainers[choice - 1]); // method returns true or false..
            }
            catch
            {
                Console.WriteLine("User not found");
            }
            return false;
        }
        public bool AddAdmin(Admin newAdmin)
        {
            int count = InMemoryDatabase.Admins.Count();
            Admin MailInUse = InMemoryDatabase.Admins.FirstOrDefault(admin => admin.Email == newAdmin.Email);
            if (MailInUse == null)
            {
                InMemoryDatabase.Admins.Add(newAdmin);
                Console.WriteLine("Init...");
            }
            if (count != InMemoryDatabase.Admins.Count())
            {
                Console.WriteLine($"Added admin {newAdmin.Email}");
                return true;
            }
            Console.WriteLine($"Email already in use");
            return false;
        }
        public bool RemoveAdmin(string toBeremovedAdmin, string currentAdmin)
        {

            if (toBeremovedAdmin == currentAdmin)
            {
                Console.WriteLine("You cant remove yourself");
                return false;
            }
            try
            {
                Admin toBeRemoved = InMemoryDatabase.Admins.First(admin => admin.Email == toBeremovedAdmin);
                return InMemoryDatabase.Admins.Remove(toBeRemoved);
            }
            catch
            {
                Console.WriteLine("That admin doesn't exist");
            }
            return false;
        }
        public void ListStudents()
        {
            if (InMemoryDatabase.Students.Count == 0)
            {
                Console.WriteLine("There arent any students yet");
                return;
            }
            for (int i = 0; i < InMemoryDatabase.Students.Count; i++)
            {
                Console.WriteLine($"{i + 1} {InMemoryDatabase.Students[i].FirstName} {InMemoryDatabase.Students[i].LastName} {InMemoryDatabase.Students[i].Email}");
            }
        }
        public void ListTrainers()
        {
            if (InMemoryDatabase.Trainers.Count == 0)
            {
                Console.WriteLine("There arent any trainers yet");
                return;
            }
            for (int i = 0; i < InMemoryDatabase.Trainers.Count; i++)
            {
                Console.WriteLine($"{i + 1} {InMemoryDatabase.Trainers[i].FirstName} {InMemoryDatabase.Trainers[i].LastName} {InMemoryDatabase.Trainers[i].Email}");
            }
        }
    }
}
