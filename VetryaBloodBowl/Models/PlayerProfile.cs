using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetryaBloodBowl.Models
{
    public class PlayerProfile
    {
        public PlayerProfile(PlayerProfile item)
        {
            ID = item.ID;
            MaxQuantity = item.MaxQuantity;
            Quantity = item.Quantity;
            Role = item.Role;
            PlayerCost = item.PlayerCost;
            MovementAllowance = item.MovementAllowance;
            Strenght = item.Strenght;
            Agility = item.Agility;
            ArmorValue = item.ArmorValue;
            TeamID = item.TeamID;
            StartingSkills = item.StartingSkills;
            TeamRoster = item.TeamRoster;
            NormalSkillGroup = item.NormalSkillGroup;
            DoubleSkillGroup = item.DoubleSkillGroup;
        }
        public PlayerProfile() {
            Quantity = 0;
        }
        
        public int ID { get; set; }

        public int MaxQuantity { get; set; }
        public int Quantity { get; set; }

        [Display(Name = "Qty")]
        public string QuantityDescription
        {
            get { return Quantity.ToString() + " - " + MaxQuantity.ToString(); }
        }

        [Display(Name = "Tytle")]
        public string Role { get; set; }

        [Display(Name = "Cost (GP)")]
        public int PlayerCost { get; set; }

        [Display(Name = "MA")]
        public int MovementAllowance { get; set; }

        [Display(Name = "ST")]
        public int Strenght { get; set; }

        [Display(Name = "AG")]
        public int Agility { get; set; }

        [Display(Name = "AV")]
        public int ArmorValue { get; set; }
        
        public int TeamID { get; set; }

        public virtual ICollection<StartingSkill> StartingSkills { get; set; }

        public string Skills
        {
            get
            {
                var skillsDescription = "";
                foreach (StartingSkill startingSkill in StartingSkills)
                {
                    skillsDescription += startingSkill.Skill.Name + ", ";
                }
                return skillsDescription.Trim();
            }
        }

        [ForeignKey("TeamID")]
        public virtual TeamRoster TeamRoster { get; set; }

        public SkillCategory NormalSkillGroup { get; set; }

        [Display(Name = "Normal")]
        public string NormalRollSkills
        {
            get
            {
                String normalSkillsDescription = "";
                var normalSkillsList = NormalSkillGroup.GetFlags().ToList();
                foreach (SkillCategory category in normalSkillsList)
                {
                    normalSkillsDescription += category.ToString().ToUpper().First();
                }
                return normalSkillsDescription;
            }
        }

        public SkillCategory DoubleSkillGroup { get; set; }

        [Display(Name = "Double")]
        public string DoubleRollSkills
        {
            get
            {
                String doubleSkillsDescription = "";
                var doubleSkillsList = DoubleSkillGroup.GetFlags().ToList();
                foreach (SkillCategory category in doubleSkillsList)
                {
                    doubleSkillsDescription += category.ToString().ToUpper().First();
                }
                return doubleSkillsDescription;
            }
        }
    }
}