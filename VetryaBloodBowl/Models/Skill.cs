using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VetryaBloodBowl.Models
{
    [Flags]
    public enum SkillCategory
    {
        General = 1, Strenght = 2, Agility = 4, Passing = 8, Mutation = 16, Extraordinary = 32
    }

    public static class SkillCategoryExtensions
    {
        public static IEnumerable<SkillCategory> GetFlags(this SkillCategory input)
        {
            foreach (SkillCategory value in Enum.GetValues(input.GetType()))
                if (input.HasFlag(value))
                    yield return value;
        }
    }

    public class Skill
    {
        public int ID { get; set; }

        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Rules { get; set; }

        public SkillCategory SkillCategory { get; set; }

        public string CategoryDescription
        {
            get
            {
                return SkillCategory.ToString();
            }
        }

        public virtual ICollection<StartingSkill> StartingSkills { get; set; }
    }
}