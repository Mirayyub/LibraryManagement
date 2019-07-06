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

        public bool IsHave { get; set; }

        [Required]
        public decimal PayPrice { get; set; }

        [Required]
        public DateTime ReturnDate { get; set; }

        public int OrderId { get; set; }


        public Order Order { get; set; }

    }
}
