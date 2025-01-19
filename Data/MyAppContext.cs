using Microsoft.EntityFrameworkCore;
using MyMvcApp.Models;

namespace MyMvcApp.Data
{

 public class MyMvcAppContext : DbContext 
 {
     public MyMvcAppContext(DbContextOptions<MyMvcAppContext> options)
          : base(options)
      {
      }

     public DbSet<Item> Items { get; set; }
 }
}