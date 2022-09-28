using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace MyPrjTest.EntityFrameworkCore
{
    public static class MyPrjTestDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MyPrjTestDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MyPrjTestDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
