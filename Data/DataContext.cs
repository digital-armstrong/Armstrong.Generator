using Microsoft.EntityFrameworkCore;
using Armstrong.Generator.Models;
using Armstrong.Generator.Helpers;

namespace Armstrong.Generator.Data
{
  public class DataContext : DbContext
  {
    public DbSet<Channel>? Channels { get; set; }
    // public DbSet<History>? Histories { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
      // var _host = EnvironmentHelper.GetEnvirovmentVariable("DB_HOST");
      // var _username = EnvironmentHelper.GetEnvirovmentVariable("DB_USER");
      // var _pswd = EnvironmentHelper.GetEnvirovmentVariable("DB_PSWD");
      // var _database = EnvironmentHelper.GetEnvirovmentVariable("DB_NAME");

      var _host = "localhost";
      var _username = "postgres";
      var _pswd = "postgres";
      var _database = "arms_webapp_development";

      var connectionStringBuilder = new Npgsql.NpgsqlConnectionStringBuilder
      {
        Host = _host,
        Username = _username,
        Password = _pswd,
        Database = _database
      };

      options.UseNpgsql(connectionStringBuilder.ConnectionString);
    }
  }
}
