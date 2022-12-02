using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ModuleCalculatorWeb.Models;

namespace ModuleCalculatorWeb.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<ModuleCalculatorWeb.Models.Semester> Semester { get; set; }
        public DbSet<ModuleCalculatorWeb.Models.Module> Module { get; set; }
    }
}
