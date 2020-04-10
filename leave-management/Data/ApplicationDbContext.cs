using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using leave_management.Models;

namespace leave_management.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        //if u have created a class you have to update in here. to say that the class is part of this dbSet DbContext
        //Always update here after u add dataClasses
        public DbSet<Employee> Employees { get; set; }
        public DbSet<LeaveHistorycs> LeaveHistorycs { get; set; }
        public DbSet<LeaveType> LeaveTypes { get; set; }
        public DbSet<LeaveAllocation> LeaveAllocations { get; set; }
        public DbSet<leave_management.Models.LeaveTypeVM> DetailsLeaveTypeVM { get; set; }

    }
}
