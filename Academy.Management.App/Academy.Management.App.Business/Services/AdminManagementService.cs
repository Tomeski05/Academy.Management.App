using Academy.Management.App.Business.ServiceModels;
using Academy.Management.App.Domain.Data;
using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Business.Services
{
    public class AdminManagementService
    {
        public AdminServiceResult ASR = new AdminServiceResult();
        private Admin NewAdmin = new Admin();
        private Student NewStudent = new Student();
        private Trainer NewTrainer = new Trainer();
        private AdminRepo AdminRepo = new AdminRepo();


        public void AdminService(Admin current)
        {
            Admin currentAdmin = current;
            AdminPanelUi();
            SetAdminServiceResults(Console.ReadLine());
            bool isValidAddRemoveUserChoice = ASR.IsValidChoice;
            int adminInput = ASR.AdminChoice;
            while (!isValidAddRemoveUserChoice)
            {
                SetAdminServiceResults(Console.ReadLine());
                isValidAddRemoveUserChoice = ASR.IsValidChoice;
                adminInput = ASR.AdminChoice;
            }
            switch (adminInput)
            {
                case 1:
                    AddUserPanelUi();
                    AddUser(isValidAddRemoveUserChoice, adminInput);
                    break;
                case 2:
                    RemoveUserUi();
                    RemoveUser(isValidAddRemoveUserChoice, adminInput, currentAdmin);
                    break;
            }
        }

        public void RemoveUser(bool isValidAddRemoveUserChoice, int adminInput, Admin currentAdmin)
        {
            SetAdminAddOrRemoveChoice(Console.ReadLine());
            isValidAddRemoveUserChoice = ASR.IsValidChoice;
            adminInput = ASR.AdminChoice;
            while (!isValidAddRemoveUserChoice)
            {
                SetAdminAddOrRemoveChoice(Console.ReadLine());
                isValidAddRemoveUserChoice = ASR.IsValidChoice;
                adminInput = ASR.AdminChoice;
            }
            if (adminInput == 1)
            {
                Console.WriteLine("Enter a valid admin emal to remove it");
                AdminRepo.RemoveAdmin(Console.ReadLine(), currentAdmin.Email);
            }
            if (adminInput == 2)
            {
                Console.WriteLine("Choose a student");
                AdminRepo.ListStudents();
                AdminRepo.RemoveStudent(Console.ReadLine());
            }
            if (adminInput == 3)
            {
                Console.WriteLine("Choose a trainer");
                AdminRepo.ListTrainers();
                AdminRepo.RemoveTrainer(Console.ReadLine());
            }
        }

        public void AddUser(bool isValidAddRemoveUserChoice, int adminInput)
        {
            SetAdminAddOrRemoveChoice(Console.ReadLine());
            isValidAddRemoveUserChoice = ASR.IsValidChoice;
            while (!isValidAddRemoveUserChoice)
            {
                SetAdminAddOrRemoveChoice(Console.ReadLine());
                isValidAddRemoveUserChoice = ASR.IsValidChoice;
                adminInput = ASR.AdminChoice;
            }
            if (ASR.AdminChoice == 1)
            {
                NewAdmin = AddAdmin();
                while (NewAdmin == null)
                {
                    NewAdmin = AddAdmin();
                }
                AdminRepo.AddAdmin(NewAdmin);
            }
            if (ASR.AdminChoice == 2)
            {
                NewStudent = AddStudent();
                while (NewStudent == null)
                {
                    NewStudent = AddStudent();
                }
                AdminRepo.AddStudent(NewStudent);
            }
            if (ASR.AdminChoice == 3)
            {
                NewTrainer = AddTrainer();
                while (NewTrainer == null)
                {
                    NewTrainer = AddTrainer();
                }
                AdminRepo.AddTrainer(NewTrainer);
            }
        }

        public void AdminPanelUi()
        {
            Console.WriteLine("1. Add User");
            Console.WriteLine("2. Remove user");

        }
        public void AddUserPanelUi()
        {
            Console.WriteLine("1. Add Admin");
            Console.WriteLine("2. Add Student");
            Console.WriteLine("3. Add Trainer");
        }
        public void RemoveUserUi()
        {
            Console.WriteLine("1. Remove Admin");
            Console.WriteLine("2. Remove Student");
            Console.WriteLine("3. Remove Trainer");
        }

        public void SetAdminServiceResults(string input)
        {
            try
            {
                int result = int.Parse(input);
                if (result == 1 || result == 2)
                {
                    ASR.AdminChoice = result;
                    ASR.IsValidChoice = true;
                    return;
                }
                ASR.IsValidChoice = false;
                throw new Exception("Enter valid input 1 or 2");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void SetAdminAddOrRemoveChoice(string input)
        {
            try
            {
                int result = int.Parse(input);
                if (result >= 1 && result <= 3)
                {
                    ASR.AdminChoice = result;
                    ASR.IsValidChoice = true;
                    return;
                }
                ASR.IsValidChoice = false;
                throw new Exception("Enter valid input 1, 2, 3");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public Admin AddAdmin()
        {
            if (ASR.AdminChoice == 1)
            {
                try
                {
                    Console.Write($"Enter Id(must be a number): ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write($"Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write($"Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write($"Enter password: ");
                    string password = Console.ReadLine();
                    Console.Write($"Enter email: ");
                    string email = Console.ReadLine();
                    return NewAdmin = new Admin(id, firstName, lastName, email, password);
                    throw new Exception("Invalid inputs");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return NewAdmin = null;
        }

        public Student AddStudent()
        {
            if (ASR.AdminChoice == 2)
            {
                try
                {
                    Console.Write($"Enter Id(must be a number): ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write($"Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write($"Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write($"Enter password: ");
                    string password = Console.ReadLine();
                    Console.Write($"Enter email: ");
                    string email = Console.ReadLine();
                    return NewStudent = new Student(id, firstName, lastName, email, password);
                    throw new Exception("Invalid inputs");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return NewStudent = null;
        }

        public Trainer AddTrainer()
        {
            if (ASR.AdminChoice == 3)
            {
                try
                {
                    Console.Write($"Enter Id(must be a number): ");
                    int id = int.Parse(Console.ReadLine());
                    Console.Write($"Enter first name: ");
                    string firstName = Console.ReadLine();
                    Console.Write($"Enter last name: ");
                    string lastName = Console.ReadLine();
                    Console.Write($"Enter password: ");
                    string password = Console.ReadLine();
                    Console.Write($"Enter email: ");
                    string email = Console.ReadLine();
                    return NewTrainer = new Trainer(id, firstName, lastName, email, password);
                    throw new Exception("Invalid inputs");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            return NewTrainer = null;
        }
    }
}
