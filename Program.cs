using Armstrong.Generator.Models;
using Armstrong.Generator.Data;

namespace Armstrong.Generator;
class Program
{
  static void Main(string[] args)
  {
    Random random = new Random();

    var context = new DataContext();
    var channels = new List<Channel>();

    channels = context.Channels.ToList<Channel>();

    Console.WriteLine($"Found {channels.Count} channels");

    while (true)
    {
      foreach (var channel in channels)
      {
        channel.EventSystemValue = random.NextDouble();
        channel.EventSystemValue = random.NextDouble() * 5.5f;
        channel.EventDatetime = DateTime.UtcNow;
        channel.UpdatedAt = DateTime.UtcNow;
        channel.EventCount++;
      }

      context.SaveChanges();
      Console.WriteLine($"Updated {channels.Count} channels");

      Thread.Sleep(2500);
    }
  }
}
