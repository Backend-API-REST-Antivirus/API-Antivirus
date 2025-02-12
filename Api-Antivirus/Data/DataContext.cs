using Microsoft.EntityFrameworkCore;
using Api_Antivirus.Models;

namespace Api_Antivirus.Data
{
    public class DataContext : DbContext
    {
        //constructor
        public DataContext(DbContextOptions<DataContext> options): base(options){}
        public DbSet<User> Users{get; set;}
        
    }
}