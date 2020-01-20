using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace VetryaBloodBowl.DAL
{
    public class BloodBowlConfiguration : DbConfiguration
    {
        public BloodBowlConfiguration()
        {
            SetExecutionStrategy("System.Data.SqlClient", () => new SqlAzureExecutionStrategy());
        }
    }
}