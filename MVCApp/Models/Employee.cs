using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class Employee
    {
        public int ID { get; set; }
        public string FirstName { get; set; }
        public string lastName { get; set; }
        public string Gender { get; set; }
        public int Salary { get; set; }
        public int departmentID { get; set; }


    }
}