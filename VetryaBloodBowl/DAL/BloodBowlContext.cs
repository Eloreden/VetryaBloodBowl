using VetryaBloodBowl.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace VetryaBloodBowl.DAL
{
    public class BloodBowlContext : DbContext
    {
        public DbSet<TeamRoster> TeamRoster { get; set; }
        public DbSet<PlayerProfile> PlayerProfile { get; set; }
        public DbSet<Skill> Skill { get; set; }
        public DbSet<StartingSkill> StartingSkills { get; set; }
        public DbSet<Coach> Coachs { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingEntitySetNameConvention>();
        }

        public System.Data.Entity.DbSet<VetryaBloodBowl.Models.CoachTeam> CoachTeam { get; set; }
    }
}