using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VetryaBloodBowl.Models
{
    public class StartingSkill
    {
        public int ID { get; set; }
        public int PlayerProfileID { get; set; }
        public int SkillID { get; set; }
        public virtual PlayerProfile PlayerProfile { get; set; }
        public virtual Skill Skill { get; set; }
    }
}