﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GMS.Modul1.Models
{
    public class Opstina
    { 
        [Key]
        public int ID { get; set; }
        public string description { get; set; }
        [ForeignKey(nameof(drzava))]
        public int DrzavaID { get; set; }
        public Drzava drzava { get; set; }
    }
}
