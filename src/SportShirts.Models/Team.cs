using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace SportShirts.Models
{
    public class Team
    {
        [Required]
        public string Name { get; set; }

        public Country Country { get; set; }

        [DefaultValue(false)]
        public bool NationalTeam { get; set; }
    }
}
