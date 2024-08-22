using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionBiblioteca.Models;
using Microsoft.EntityFrameworkCore;


namespace GestionBiblioteca.Data
{
    public class ApplicationDbContext : DbContext 
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options ) : base(options){}
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Customer> Customers { get; set;}
        public  DbSet<Loan> Loans { get; set;}
        public DbSet<User> Users { get; set; }
    }
}