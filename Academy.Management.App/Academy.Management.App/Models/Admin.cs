using Academy.Management.App.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Models
{
    public class Admin : User
    {
        public Admin() { }
        public Admin(int id, string fname, string lname, string email, string password) 
            : base(id, fname, lname, email, password, Role.Admin)
        {

        }
    }
}
