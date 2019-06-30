using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagement.Model;
using LibraryManagement.DAL;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Model
{
    class Book
    {
        public Book()
        {
            costumers = new HashSet<Costumer>();

            orderitems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public string Name { get; set; }

        [Required, Column(TypeName = "money")]
        public decimal Price { get; set; }

        public ICollection<Costumer> costumers { get; set; }

        public ICollection<OrderItem> orderitems { get; set; }
    }
}
