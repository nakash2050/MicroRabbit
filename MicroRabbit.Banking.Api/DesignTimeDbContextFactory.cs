using System.IO;
using MicroRabbit.Banking.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace MicroRabbit.Banking.Api
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<BankingDbContext>
    {
        public BankingDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<BankingDbContext>();
            var connectionString = configuration.GetConnectionString("BankingDbConnection");
            builder.UseSqlServer(connectionString);
            return new BankingDbContext(builder.Options);
        }
    }
}
