using FSM.Model.ModelObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Linq;

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


        public int SaveChangesWithDate()
        {
            var addedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Added).ToList();

            foreach(var added in addedEntities)
            {
                var baseEntity = (BaseObject)added.Entity;
                DateTime created = DateTime.UtcNow;
                DateTime.SpecifyKind(created, DateTimeKind.Utc);
                baseEntity.Created = created;
                baseEntity.LastUpdated = created;
            }

            var updatedEntities = ChangeTracker.Entries().Where(e => e.State == EntityState.Modified).ToList();
            
            foreach(var updated in updatedEntities)
            {
                var baseEntity = (BaseObject)updated.Entity;
                DateTime lastUpdate = DateTime.UtcNow;
                DateTime.SpecifyKind(lastUpdate, DateTimeKind.Utc);
                baseEntity.LastUpdated = lastUpdate;
            }

            return SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Foreign Key Cascading Delete
            modelBuilder.Entity<Club>().HasOne(c => c.User).WithMany().HasForeignKey(c => c.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<League>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Country>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PlayerAttribute>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Player>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PlayerContract>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PlayerContractClause>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PlayerPosition>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<PlayerStatistic>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);
            modelBuilder.Entity<Season>().HasOne(l => l.User).WithMany().HasForeignKey(l => l.UserId).OnDelete(DeleteBehavior.Restrict);

            // Alternate Keys
            modelBuilder.Entity<User>().HasAlternateKey(c => c.UserName);
        }
    }
}
