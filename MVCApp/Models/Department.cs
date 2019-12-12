using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    [Table("tbldepartment")]
    public class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
       // public List<Employee> Deptemployees { get; set; }
    }
}