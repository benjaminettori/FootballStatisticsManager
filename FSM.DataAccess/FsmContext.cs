using FSM.Model.ModelObjects;
using Microsoft.EntityFrameworkCore;

namespace FSM.DataAccess
{
    public class FsmContext : DbContext
    {
        public FsmContext(DbContextOptions<FsmContext> options) : base(options)
        {            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<League> Leagues { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Season> Seasons { get; set; }
        public DbSet<Club> Clubs { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerAttribute> PlayerAttributes { get; set; }
        public DbSet<PlayerContract> PlayerContracts { get; set; }
        public DbSet<PlayerContractClause> PlayerContractClauses { get; set; }
        public DbSet<PlayerPosition> Positions { get; set; }
        public DbSet<PlayerStatistic> PlayerStatistics { get; set; }
        public DbSet<StatisticalCategory> StatisticalCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
        }        
    }
}
