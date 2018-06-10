using System;
using SportShirts.CrossCutting.Enums;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SportShirts.Models
{
    public class Shirt
    {
        [Required]
        public int Id {get;set;}
        public Size Size{get;set;}

        [Required]
        public Team Team { get; set; }

        public uint Number { get; set; }

        public string Player { get; set; }

        public ShirtType ShirtType {get; set;}
    }
}
