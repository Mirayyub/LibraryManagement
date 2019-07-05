﻿using System;
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
            OrderItems = new HashSet<OrderItem>();
        }
        public int Id { get; set; }

        [Required]
        public int CostumerId { get; set; }

        public Costumer Costumer { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        public ICollection<OrderItem> OrderItems { get; set; }


    }
}
