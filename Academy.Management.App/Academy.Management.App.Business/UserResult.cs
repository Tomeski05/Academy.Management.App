using Academy.Management.App.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Business
{
    public class UserResult
    {
        public Admin Admin { get; set; }
        public Student Student { get; set; }
        public Trainer Trainer { get; set; }
        public bool IsLoggedIn { get; set; }
    }

}
