using System;
using System.Data.Entity;
using System.Linq;

namespace Asp.net_MVC_Code_First
{
    public class StagiaireDbContext : DbContext
    {
       public DbSet<Filiere> modules { get; set; } 
       public DbSet<Stagiaire> Stagiaires { get; set; }
    }
}