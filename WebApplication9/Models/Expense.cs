﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication9.Models
{
    public class Expense
    {
        public int IdE { get; set; }
        [Required]
        public int Amount { get; set; }
        public string Category { get; set; }
        public DateTime Datee { get; set; }
        public string Description { get; set; }
        public int IdA { get; set; }
    }
}
