using System;
using System.Collections.Generic;
using System.Text;

namespace Academy.Management.App.Models
{
    public class Subject
    {
        public string Name { get; set; }
        public int NumberOfClasses { get; set; }
        public bool IsOptional { get; set; }
        public DateTime StartOn { get; set; }
        public DateTime EndOn { get; set; }
    }
}
