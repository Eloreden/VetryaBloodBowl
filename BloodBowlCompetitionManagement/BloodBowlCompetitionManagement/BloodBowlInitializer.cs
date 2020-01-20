using System.Data.Entity;

asausing System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using VetryaBloodBowl.Models;

namespace VetryaBloodBowl.DAL
{
    public class BloodBowlInitializer : DropCreateDatabaseIfModelChanges<BloodBowlContext>
    {
        protected override void Seed(BloodBowlContext context)
        {
            var teamRosterList = new List<TeamRoster>()
            {
                new TeamRoster{ Race = RaceTeam.Human, RerollQuantity = 8, RerollCost = 50000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.Skaven, RerollQuantity = 8, RerollCost = 60000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.Nurgle, RerollQuantity = 8, RerollCost = 70000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.Dwarf, RerollQuantity = 8, RerollCost = 50000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.ElvenUnion, RerollQuantity = 8, RerollCost = 50000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.HightElf, RerollQuantity = 8, RerollCost = 50000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.DarkElf, RerollQuantity = 8, RerollCost = 50000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.WoodElf, RerollQuantity = 8, RerollCost = 50000, SpecialRules = ""},
                new TeamRoster{ Race  = RaceTeam.Orc, RerollQuantity = 8, RerollCost = 60000, SpecialRules = "" },
            };
            teamRosterList.ForEach(t => context.TeamRoster.Add(t));
            context.SaveChanges();
            
            var skillList = new List<Skill>()
            {
                new Skill{ID = 1, Name = "Block", Rules = "A player with the Block skill is proficient at knocking opponents down. The Block skill, if used, affects the results rolled with the Block dice, as explained in the Blocking rules.", SkillCategory = SkillCategory.General},
                new Skill{ID = 2, Name = "Catch", Rules = "A player who has the Catch skill is allowed to re-roll the D6 if they fail a Catch roll. It also allows the player to re-roll the D6 if they fail to catch a hand-off or make an interception.", SkillCategory = SkillCategory.Agility},
                new Skill{ID = 3, Name = "Dodge", Rules = "A player with the Dodge skill is adept at slipping away from opponents, and is allowed to re-roll the D6 if they fail to dodge out of any of an opposing player's tackle zones. However, the player may only re-roll one failed Dodge roll per turn. In addition, the Dodge skill if used, affects the results rolled on the Block dice, as explained in the Blocking rules.", SkillCategory = SkillCategory.Agility},
                new Skill{ID = 4, Name = "Pass", Rules = "A player with the Pass skill is allowed to re-roll the D6 if they throw an incaccurate pass or fumble.", SkillCategory = SkillCategory.Passing},
                new Skill{ID = 5, Name = "Sure Hands", Rules = "A player with the Sure Hands skill is allowed to re-roll the D6 if they fail to pick up the ball. In addition, the Strip Ball skill will not work against a player with this skill.", SkillCategory = SkillCategory.General},
                new Skill{ID = 6, Name = "Bone-head", Rules = "The player is not noted for their intelligence. Because of this, you must roll a D6 immediately after declaring an Action for the player, but before taking the Action. On a roll of 1, they stand around trying to remember what it is they're meant to be doing. The player can't do anything for the turn, and the player's team loses the declared Action for the turn. For example, if a Bone-head player declares a Blitz Action and rolls a 1; then the team cannot declare another Blitz Action that turn. The player loses their tackle zones and may not catch, intercept of pass, assist another player on a block or foul, or voluntarily move until they manage to roll a 2 or better at the start of a future Action or the drive ends.", SkillCategory = SkillCategory.Extraordinary},
                new Skill{ID = 7, Name = "Loner", Rules = "Loners, through inexperience, arrogance, animal ferocity or just plain stupidity, do not work well with the rest of a team. As a result, a Loner may use team re-rolls but has to roll a D6 first. On a roll of 4+, they may use the team re-roll as normal. On a roll of 1-3, the original result stands without being re-rolled but the team re-roll is lost (i.e., used).", SkillCategory = SkillCategory.Extraordinary},
                new Skill{ID = 8, Name = "Mighty Blow", Rules = "Add 1 to any Armour roll or Injury roll made by a player with this skill when an opponent is Knocked Down by this player during a block. Note that you only modify one of the dice rolls, so if you decide to use Mighty Blow to modify the Armour roll, you may not modify the Injury roll as well. Mighty Blow cannot be used with the Stab or Chainsaw skills.", SkillCategory = SkillCategory.Strenght},
                new Skill{ID = 9, Name = "Thick Skull", Rules = "This player treats a roll of 8 on the Injury table, after any modifiers have been applied, as a Stunned result rather than a KO's result. This skill may be used even if the player is Prone or Stunned.", SkillCategory = SkillCategory.Strenght},
                new Skill{ID = 10, Name = "Throw Team-mate", Rules = "A player with this skill has the ability to throw a player from the same team instead of the ball - this includes the ball if the player being thrown already has it! The throwing player must end the movement of their Pass Action standing next to the intended team-mate to be thrown, who must have the Right Stuff skill and be standing. The pass is worked out exactly the same as if the player with Throw Team-mate was passing the ball, exept the player must subtract 1 from the D6 roll when they pass the player, fumbles are not automatically turnovers, and Long Pass or Long Bomb range passes are not possible. In addition, accurate passes are treated instead as inaccurate passes, thus scattering the thrown player three times as players are heavier and harder to pass than a ball. The thrown player cannot be intercepted. A fumbled team-mate will land in the square they originally occupied. If the thrown player scatters of the pitch, they are beaten up by the crowd in the same manner as a player who has been pushed off the pitch. If the final square they scatter into is occupied by another player, treat the player landed on as Knocked Down and roll for Armour (even if already Prone or Stunned), and then the player being thrown will scatter one more square. If the thrown player would land on another player, continue to scatter the thrown player until they end up in an empty square or off the pitch (i.e., they cannot land on more than one player). See the Right Stuff entry to see if the player lands on their feet or head-down in a crumpled heap!", SkillCategory = SkillCategory.Extraordinary},
                new Skill{ID = 1, Name = "Block", Rules = "A player with the Block skill is proficient at knocking opponents down. The Block skill, if used, affects the results rolled with the Block dice, as explained in the Blocking rules.", SkillCategory = SkillCategory.General},
            };
            skillList.ForEach(s => context.Skill.Add(s));
            context.SaveChanges();

            var playerList = new List<PlayerProfile>()
            {   //Human
                new PlayerProfile{ID = 1, Role = "Lineman", MaxQuantity = 16, PlayerCost = 50000, MovementAllowance = 6, Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 1, NormalSkillGroup = SkillCategory.General, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{
                    ID = 2, Role = "Catcher", MaxQuantity = 4, PlayerCost = 60000, MovementAllowance = 8,  Strenght = 2, Agility = 3, ArmorValue = 7, TeamID = 1, NormalSkillGroup = SkillCategory.General | SkillCategory.Agility, DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 3, Role = "Thrower", MaxQuantity = 2, PlayerCost = 70000, MovementAllowance = 6,  Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 1, NormalSkillGroup = SkillCategory.General | SkillCategory.Passing, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght},
                new PlayerProfile{ID = 4, Role = "Blitzer", MaxQuantity = 4, PlayerCost = 90000, MovementAllowance = 7,  Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 1, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 5, Role = "Ogre", MaxQuantity = 1, PlayerCost = 140000, MovementAllowance = 5,    Strenght = 5, Agility = 2, ArmorValue = 9, TeamID = 1, NormalSkillGroup = SkillCategory.General, DoubleSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing},
                //Skaven
                new PlayerProfile{ID = 6, Role = "Lineman", MaxQuantity = 16, PlayerCost = 50000, MovementAllowance = 7,        Strenght = 3, Agility = 3, ArmorValue = 7, TeamID = 2, NormalSkillGroup = SkillCategory.General,                           DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght | SkillCategory.Passing | SkillCategory.Mutation},
                new PlayerProfile{ID = 7, Role = "Thrower", MaxQuantity = 2, PlayerCost = 70000, MovementAllowance = 7,         Strenght = 3, Agility = 3, ArmorValue = 7, TeamID = 2, NormalSkillGroup = SkillCategory.General | SkillCategory.Passing,   DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght| SkillCategory.Mutation},
                new PlayerProfile{ID = 8, Role = "Gutt5er Runners", MaxQuantity = 4, PlayerCost = 80000, MovementAllowance = 9, Strenght = 2, Agility = 4, ArmorValue = 7, TeamID = 2, NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,   DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing | SkillCategory.Mutation},
                new PlayerProfile{ID = 9, Role = "Blitzer", MaxQuantity = 2, PlayerCost = 90000, MovementAllowance = 7,         Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 2, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght,  DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing | SkillCategory.Mutation},
                new PlayerProfile{ID = 10, Role = "Rat Ogre", MaxQuantity = 1, PlayerCost = 150000, MovementAllowance = 6,       Strenght = 5, Agility = 2, ArmorValue = 8, TeamID = 2, NormalSkillGroup = SkillCategory.Strenght,                          DoubleSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing| SkillCategory.Mutation},  
                //Nurgle
                new PlayerProfile{ID = 11, Role = "Rotters", MaxQuantity = 16, PlayerCost = 40000, MovementAllowance = 5, Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 3, NormalSkillGroup = SkillCategory.General | SkillCategory.Mutation, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 12, Role = "Pestigors", MaxQuantity = 4, PlayerCost = 80000, MovementAllowance = 6, Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 3, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght | SkillCategory.Mutation, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 13, Role = "Bloaters", MaxQuantity = 4, PlayerCost = 110000, MovementAllowance = 4, Strenght = 4, Agility = 2, ArmorValue = 9, TeamID = 3, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght | SkillCategory.Mutation, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 14, Role = "Rotspawn", MaxQuantity = 1, PlayerCost = 140000, MovementAllowance = 4, Strenght = 5, Agility = 1, ArmorValue = 9, TeamID = 3, NormalSkillGroup = SkillCategory.Strenght, DoubleSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing| SkillCategory.Mutation},
                //Dwarf
                new PlayerProfile{ID = 15, Role = "Blockers", MaxQuantity = 16, PlayerCost = 70000, MovementAllowance = 4,      Strenght = 3, Agility = 2, ArmorValue = 9, TeamID = 4, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght,            DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 16, Role = "Runners", MaxQuantity = 2, PlayerCost = 80000, MovementAllowance = 6,        Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 4, NormalSkillGroup = SkillCategory.General | SkillCategory.Passing,            DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght},
                new PlayerProfile{ID = 17, Role = "Blitzers", MaxQuantity = 2, PlayerCost = 80000, MovementAllowance = 5,       Strenght = 3, Agility = 3, ArmorValue = 9, TeamID = 4, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght,          DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 18, Role = "Troll Slayers", MaxQuantity = 2, PlayerCost = 90000, MovementAllowance = 5,  Strenght = 3, Agility = 2, ArmorValue = 8, TeamID = 4, NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght, DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 19, Role = "Deathroller", MaxQuantity = 1, PlayerCost = 160000, MovementAllowance = 4,   Strenght = 7, Agility = 1, ArmorValue = 10, TeamID = 4, NormalSkillGroup = SkillCategory.Strenght,                            DoubleSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing},
                //Elven Union
                new PlayerProfile{ID = 20, Role = "Lineman", MaxQuantity = 16, PlayerCost = 60000, MovementAllowance = 6,        Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 5, NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 21, Role = "Thrower", MaxQuantity = 2, PlayerCost = 70000, MovementAllowance = 6,         Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 5, NormalSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing,   DoubleSkillGroup = SkillCategory.Strenght},
                new PlayerProfile{ID = 22, Role = "Catcher", MaxQuantity = 4, PlayerCost = 100000, MovementAllowance = 8,        Strenght = 2, Agility = 4, ArmorValue = 7, TeamID = 5, NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 23, Role = "Blitzer", MaxQuantity = 2, PlayerCost = 110000, MovementAllowance = 7,        Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 5, NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                //Hight Elf
                new PlayerProfile{ID = 24, Role = "Lineman", MaxQuantity = 16, PlayerCost = 70000, MovementAllowance = 6,   Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 6,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 25, Role = "Thrower", MaxQuantity = 2, PlayerCost = 90000, MovementAllowance = 6,    Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 6,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing,   DoubleSkillGroup = SkillCategory.Strenght},
                new PlayerProfile{ID = 26, Role = "Catcher", MaxQuantity = 4, PlayerCost = 90000, MovementAllowance = 8,   Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 6,   NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 27, Role = "Blitzer", MaxQuantity = 2, PlayerCost = 100000, MovementAllowance = 7,   Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 6,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                //Dark Elf
                new PlayerProfile{ID = 28, Role = "Lineman", MaxQuantity = 16, PlayerCost = 70000, MovementAllowance = 6,       Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 7,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 29, Role = "Runners", MaxQuantity = 2, PlayerCost = 80000, MovementAllowance = 7,        Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 7,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility | SkillCategory.Passing,   DoubleSkillGroup = SkillCategory.Strenght},
                new PlayerProfile{ID = 30, Role = "Assassins", MaxQuantity = 2, PlayerCost = 90000, MovementAllowance = 6,      Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 7,   NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 31, Role = "Blitzer", MaxQuantity = 4, PlayerCost = 100000, MovementAllowance = 7,       Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 7,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 32, Role = "Witch Elves", MaxQuantity = 2, PlayerCost = 110000, MovementAllowance = 7,   Strenght = 3, Agility = 4, ArmorValue = 8, TeamID = 7,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                //Wood Elf
                new PlayerProfile{ID = 29, Role = "Lineman", MaxQuantity = 16, PlayerCost = 70000, MovementAllowance = 7,      Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 8,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 30, Role = "Catchers", MaxQuantity = 4, PlayerCost = 90000, MovementAllowance = 8,      Strenght = 2, Agility = 4, ArmorValue = 7, TeamID = 8,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility ,                          DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 31, Role = "Throwers", MaxQuantity = 2, PlayerCost = 90000, MovementAllowance = 7,      Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 8,   NormalSkillGroup = SkillCategory.General | SkillCategory.Agility| SkillCategory.Passing,   DoubleSkillGroup = SkillCategory.Strenght },
                new PlayerProfile{ID = 32, Role = "Wardancers", MaxQuantity = 2, PlayerCost = 120000, MovementAllowance = 8,   Strenght = 3, Agility = 4, ArmorValue = 7, TeamID = 8,  NormalSkillGroup = SkillCategory.General | SkillCategory.Agility,                           DoubleSkillGroup = SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 33, Role = "Treeman", MaxQuantity = 1, PlayerCost = 120000, MovementAllowance = 2,      Strenght = 6, Agility = 1, ArmorValue = 10,TeamID = 8,  NormalSkillGroup = SkillCategory.Strenght,                                                  DoubleSkillGroup = SkillCategory.General | SkillCategory.Agility| SkillCategory.Passing},
                //Orc
                new PlayerProfile{ID = 34, Role = "Lineman",            MaxQuantity = 16, PlayerCost =50000, MovementAllowance = 5, Strenght = 3, Agility = 3, ArmorValue = 9, TeamID = 9,  NormalSkillGroup = SkillCategory.General,                           DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 35, Role = "Goblin",             MaxQuantity = 4, PlayerCost = 40000, MovementAllowance = 6, Strenght = 2, Agility = 3, ArmorValue = 7, TeamID = 9,  NormalSkillGroup = SkillCategory.Agility ,                          DoubleSkillGroup = SkillCategory.General | SkillCategory.Strenght | SkillCategory.Passing},
                new PlayerProfile{ID = 36, Role = "Throwers",           MaxQuantity = 2, PlayerCost = 70000, MovementAllowance = 5, Strenght = 3, Agility = 3, ArmorValue = 8, TeamID = 9,  NormalSkillGroup = SkillCategory.General | SkillCategory.Passing,   DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Strenght },
                new PlayerProfile{ID = 37, Role = "Black Orc Blockers", MaxQuantity = 4, PlayerCost = 80000, MovementAllowance = 4, Strenght = 4, Agility = 2, ArmorValue = 9, TeamID = 9,  NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght,  DoubleSkillGroup = SkillCategory.Agility | SkillCategory.Passing},
                new PlayerProfile{ID = 38, Role = "Blitzers",           MaxQuantity = 4, PlayerCost = 80000, MovementAllowance = 6, Strenght = 3, Agility = 3, ArmorValue = 9, TeamID = 9,  NormalSkillGroup = SkillCategory.General | SkillCategory.Strenght,  DoubleSkillGroup = SkillCategory.General | SkillCategory.Passing},
                new PlayerProfile{ID = 39, Role = "Troll",              MaxQuantity = 1, PlayerCost = 110000, MovementAllowance =4, Strenght = 5, Agility = 1, ArmorValue = 9, TeamID = 9,  NormalSkillGroup = SkillCategory.Strenght,                          DoubleSkillGroup = SkillCategory.General | SkillCategory.Agility| SkillCategory.Passing},

            };
            playerList.ForEach(p => context.PlayerProfile.Add(p));
            context.SaveChanges();

            var startingSkillList = new List<StartingSkill>()
            {
                new StartingSkill{PlayerProfileID = 2, SkillID = 2},
                new StartingSkill{PlayerProfileID = 2, SkillID = 3},
                new StartingSkill{PlayerProfileID = 3, SkillID = 4},
                new StartingSkill{PlayerProfileID = 3, SkillID = 5},
                new StartingSkill{PlayerProfileID = 4, SkillID = 1},
                new StartingSkill{PlayerProfileID = 5, SkillID = 6},
                new StartingSkill{PlayerProfileID = 5, SkillID = 7},
                new StartingSkill{PlayerProfileID = 5, SkillID = 8},
                new StartingSkill{PlayerProfileID = 5, SkillID = 9},
                new StartingSkill{PlayerProfileID = 5, SkillID = 10}
            };
            startingSkillList.ForEach(s => context.StartingSkills.Add(s));
            context.SaveChanges();
        }
    }
}