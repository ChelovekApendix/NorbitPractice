using DataBase_Task2.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase_Task2
{
    internal class ApplicationContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        static string _connectionString;

        public ApplicationContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public ApplicationContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }
    }
}
