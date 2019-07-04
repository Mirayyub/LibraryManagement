using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagement.Model
{
    class Order
    {
        public Order()
        {
            orderitems = new HashSet<OrderItem>();
        }
        public int Id { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Costumer Costumer { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public decimal TotalPrice { get; set; }

        public ICollection<OrderItem> orderitems { get; set; }


    }
}
