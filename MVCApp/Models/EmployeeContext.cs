﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCApp.Models
{
    public class EmployeeContext:DbContext
    {
     public DbSet<Employee> employees { get; set; }
        public DbSet<Department> departments { get; set; }

    }

}