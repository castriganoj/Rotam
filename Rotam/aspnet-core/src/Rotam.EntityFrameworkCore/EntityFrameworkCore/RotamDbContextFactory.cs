using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Rotam.Configuration;
using Rotam.Web;

namespace Rotam.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class RotamDbContextFactory : IDesignTimeDbContextFactory<RotamDbContext>
    {
        public RotamDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<RotamDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            RotamDbContextConfigurer.Configure(builder, configuration.GetConnectionString(RotamConsts.ConnectionStringName));

            return new RotamDbContext(builder.Options);
        }
    }
}
