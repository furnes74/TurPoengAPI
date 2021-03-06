﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TurPoengAPI.Models
{
    public class Idrettslag
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string Address { get; set; }

        public bool Approved { get; set; }

        [MaxLength(4)]
        public string ZipCode { get; set; }

        [MaxLength(50)]
        public string City { get; set; }

        [Required]
        [MaxLength(255)]
        public string EmailAddress { get; set; }
       
        public int AdminId { get; set; } 
        public Person Admin { get; set; }


    }
}
