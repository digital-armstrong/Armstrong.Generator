using Microsoft.EntityFrameworkCore;
using Armstrong.Generator.Models;
using Armstrong.Generator.Helpers;
using Microsoft.Extensions.Configuration;

namespace Armstrong.Generator.Data
{
  public class DataContext : DbContext
  {
    public DbSet<Channel>? Channels { get; set; }
    public DbSet<History>? Histories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      var config = SettingsHelper.GetConfiguration();
      var sqlConfig = config.GetSection("SqlConnectionSettings")
                            .Get<SqlConnectionSettings>();
      var connectionStringBuilder = new Npgsql.NpgsqlConnectionStringBuilder
      {
        Host = sqlConfig.Host,
        Username = sqlConfig.Username,
        Password = sqlConfig.Password,
        Database = sqlConfig.Database
      };

      options.UseNpgsql(connectionStringBuilder.ConnectionString);
    }
  }
}
