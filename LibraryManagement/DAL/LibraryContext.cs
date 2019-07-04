using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using LibraryManagement.Model;

namespace LibraryManagement.DAL
{
    class LibraryContext:DbContext
    {
        public LibraryContext() : base("LibraryContext")
        {

        }

        public DbSet<Costumer> Costumers { get; set; }

        public DbSet<Book> Books { get; set; }
        
        public DbSet<OrderItem> OrderItems { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<OrderInfo> OrderInfos { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
