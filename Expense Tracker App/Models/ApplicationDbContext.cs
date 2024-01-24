﻿using Microsoft.EntityFrameworkCore;

namespace Expense_Tracker_App.Models
{
    public class ApplicationDbContext:DbContext
    {
          
         public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {

         }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options):base(options)
        {
            
        }


        public DbSet<Category> Categories { get; set; }
            public DbSet<Transaction> Transactions { get; set; }

    }
}
