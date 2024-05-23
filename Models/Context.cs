using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WingtipToys.Models
{
    public class Context : DbContext
    {
        public Context() : base ("Company JLS") 
        { 
        }
        public DbSet <Category> Categories { get; set; }
        public DbSet<Product> Products { get; set;}
    }
    
}