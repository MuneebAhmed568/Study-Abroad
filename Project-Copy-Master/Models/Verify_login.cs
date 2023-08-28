﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Project_Copy_Master.Models
{
    public class Verify_login
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string identifier { get; set; }
        [NotMapped]
        public string value { get; set; }
        public int id { get; set; }
    }
}
