using Academy.Management.App.Business.ServiceModels;
using Academy.Management.App.Domain.Data;
using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Business.Services
{
    public class UserManagementService
    {
        private UserRepo UserRepo { get; set; }

        public UserManagementService()
        {
            UserRepo = new UserRepo();
        }

        public UserResult Login ()
        {

            while (true)
            {
                Console.WriteLine("Please enter email:");
                string email = Console.ReadLine();

                Console.WriteLine("Please enter password:");
                string password = Console.ReadLine();

                try
                {
                    Student student = UserRepo.GetStudentByEmail(email);
                    if (student != null)
                    {
                        student.ValidatePassword(password);
                        return new UserResult
                        {
                            Student = student,
                            IsLoggedIn = true
                        };
                    }
                    Admin admin = UserRepo.GetAdminByEmail(email);
                    if (admin != null)
                    {
                        admin.ValidatePassword(password);
                        return new UserResult
                        {
                            Admin = admin,
                            IsLoggedIn = true
                        };
                    }
                    Trainer trainer = UserRepo.GetTrainerByEmail(email);
                    if (trainer != null)
                    {
                        trainer.ValidatePassword(password);
                        return new UserResult
                        {
                            Trainer = trainer,
                            IsLoggedIn = true
                        };
                    }
                    throw new Exception("Not valid email");
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex.Message);
                    Console.ResetColor();
                    Console.WriteLine("Please try again!");
                }
            }   
        }
    }
}
