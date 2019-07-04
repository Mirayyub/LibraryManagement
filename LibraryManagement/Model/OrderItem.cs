using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Model
{
    class OrderItem
    {
        public int Id { get; set; }

        [Required]
        public int BookId { get; set; }

        public virtual Book Book { get; set; }

        [Required]
        public int Count { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        [Required]
        public int CustomerId { get; set; }

        public Costumer Costumer { get; set; }

        [Required]
        public int OrderInfoId { get; set; }

        public virtual OrderInfo OrderInfo { get; set; }

    }
}
