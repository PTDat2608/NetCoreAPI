using Microsoft.EntityFrameworkCore;
using DemoMvc.Models;
using Microsoft.AspNetCore.SignalR;

namespace DemoMvc.Data
{
    public class ApplicationDbcontext : DbContext
    {
        public ApplicationDbcontext(DbContextOptions<ApplicationDbcontext> options) : base(options)
        {}
        public DbSet<Person> Person {get; set; } 
        
    }
}