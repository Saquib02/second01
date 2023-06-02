using Microsoft.EntityFrameworkCore;
using MyApplication.Models;
using System.Data.Common;

namespace MyApplication.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)  : base(options)
        {   
            
        }           
        public DbSet<Category> Categories { get; set; }
    }

}
