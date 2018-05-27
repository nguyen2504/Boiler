using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Xn.Configuration;
using Xn.Web;

namespace Xn.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class XnDbContextFactory : IDesignTimeDbContextFactory<XnDbContext>
    {
        public XnDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<XnDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            XnDbContextConfigurer.Configure(builder, configuration.GetConnectionString(XnConsts.ConnectionStringName));

            return new XnDbContext(builder.Options);
        }
    }
}
