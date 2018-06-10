using System;
using SportShirts.CrossCutting.Enums;

namespace SportShirts.Models
{
    public class Shirt
    {
        public int Id {get;set;}
        public Size Size{get;set;}

        public Team Team { get; set; }

        public uint Number { get; set; }

        public string Player { get; set; }

        public ShirtType ShirtType {get; set;}
    }
}
