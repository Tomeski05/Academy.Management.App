using Academy.Management.App.Business;
using Academy.Management.App.Business.ServiceModels;
using Academy.Management.App.Business.Services;
using System;

namespace Academy.Management.Ap
{
    class Program
    {
        static void Main(string[] args)
        {
            //povruzvame controller so service preku new - istanca
            UserManagementService userManagementService = new UserManagementService();
            //AdminManagementService adminManagementService = new AdminManagementService();

            UserResult userResult = userManagementService.Login();


            Console.WriteLine(userResult.IsLoggedIn);

            if (userResult.Admin != null)
            {
                AdminManagementService adminManagementService = new AdminManagementService();
                adminManagementService.AdminService(userResult.Admin); 
            }
            else if (userResult.Student != null)
            {
                StudentService studentService = new StudentService();
                studentService.ListSubjects(userResult.Student);
            }
            else if (userResult.Trainer != null)
            {
                TrainerService trainerService = new TrainerService();
                trainerService.TrainerServiceInit(userResult.Trainer);
            }
            else
            {
                Console.WriteLine("Something bad has happened");
            }

            Console.ReadLine();
        }

        //public static void AdminMenu()
        //{
        //    Console.WriteLine("this is admin menu");
        //}
    }
}
