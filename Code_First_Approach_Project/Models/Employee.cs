using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Code_First_Approach_Project.Models
{
    public class Employee
    {
        [Key]
        public int Emp_ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public long Phone { get; set; }

    }
}