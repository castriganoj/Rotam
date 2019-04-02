using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Rotam.EntityFrameworkCore
{
    public static class RotamDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<RotamDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<RotamDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
