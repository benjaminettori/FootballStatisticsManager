using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace FSM.DataAccess
{
    public class FsmContextFactory : IDbContextFactory<FsmContext>
    {
        public FsmContext Create(DbContextFactoryOptions options)
        {            
            var optionsBuilder = new DbContextOptionsBuilder<FsmContext>();
            optionsBuilder.UseSqlServer(@"Data Source = BENJAMINETTORI; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False; Initial Catalog = FootballManagerStatistics");
            return new FsmContext(optionsBuilder.Options);
        }
    }
}
