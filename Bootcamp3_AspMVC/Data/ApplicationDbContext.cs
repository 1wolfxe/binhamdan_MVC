using Bootcamp3_AspMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace Bootcamp3_AspMVC.Data
{
    public class ApplicationDbContext  :DbContext
    {

        //ctor
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) :base(options)
        {
            
        }

        //DbSet
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }


    }
}
