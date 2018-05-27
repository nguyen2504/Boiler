using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Xn.EntityFrameworkCore
{
    public static class XnDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<XnDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<XnDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
