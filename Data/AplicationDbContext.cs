using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestionBiblioteca.Models;
using Microsoft.EntityFrameworkCore;


namespace GestionBiblioteca.Data
{
    public class AplicationDbContext : DbContext 
    {
        public AplicationDbContext (DbContextOptions<AplicationDbContext> opntions ) : base(opntions){}

        public DbSet<User> Users { get; set; }
    }
}