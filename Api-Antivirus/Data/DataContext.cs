using Microsoft.EntityFrameworkCore;
using Api_Antivirus.Models;

namespace Api_Antivirus.Data
{
    public class ApplicationDbContext : DbContext
    {
        //constructor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){}
        public DbSet<User> Users{get; set;}
        
    }
}