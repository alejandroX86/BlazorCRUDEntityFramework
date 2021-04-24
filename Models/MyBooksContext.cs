using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUDEntityFramework.Models
{
    public class MyBooksContext : DbContext
    {
    
     public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder  optionsBuilder) 
        {

            optionsBuilder.UseSqlServer("Data Source=DESKTOP-UCKHD7C\\SQLEXPRESS01;Initial Catalog=BlazorCRUDEntityFramework;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");



        }

    }
}
