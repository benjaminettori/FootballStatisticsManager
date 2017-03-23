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

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {            
        }        
    }
}
