﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryManagement.Model
{
    class Costumer
    {
        public Costumer()
        {
            orderitems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public string PhoneNo { get; set; }

        [Required]
        public string Email { get; set; }

        public ICollection<OrderItem> orderitems { get; set; }

        public ICollection<Order> orders { get; set; }

    }
}
