using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VetryaBloodBowl.Models
{
    public class TeamRoster
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Name")]
        public RaceTeam Race { get; set; }

        public int RerollQuantity { get; set; }

        [Display(Name = "Re-roll Counters")]
        public string RerollQuantityDescription
        {
            get
            {
                return "0-" + RerollQuantity.ToString();
            }
        }

        [Display(Name = "Re-roll Cost")]
        public int RerollCost { get; set; }

        [Display(Name = "Special Rules")]
        public string SpecialRules { get; set; }

        public virtual ICollection<PlayerProfile> Players { get; set; }
    }
}