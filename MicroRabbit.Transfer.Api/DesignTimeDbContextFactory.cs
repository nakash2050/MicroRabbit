using MicroRabbit.Transfer.Data.Context;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace MicroRabbit.Transfer.Api
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<TransferDbContext>
    {
        public TransferDbContext CreateDbContext(string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var builder = new DbContextOptionsBuilder<TransferDbContext>();
            var connectionString = configuration.GetConnectionString("TransferDbConnection");
            builder.UseSqlServer(connectionString);
            return new TransferDbContext(builder.Options);
        }
    }
}
