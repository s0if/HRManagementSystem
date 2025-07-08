﻿using HRManagementSystem.DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManagementSystem.DAL.Data
{
    public class ApplicationDbContext:DbContext
    {
          public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        :base(options){ }
        public DbSet<Employee> Employees { get; set; }
    }
}
