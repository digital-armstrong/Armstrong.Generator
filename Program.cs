using Armstrong.Generator.Models;
using Armstrong.Generator.Data;

namespace Armstrong.Generator;
class Program
{
  struct States
  {
    public static string Normal => "normal";
    public static string Warning => "warning";
    public static string Danger => "danger";
  }

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

        switch (channel.EventSystemValue > 0.3f)
        {
          case true: channel.ChannelState = States.Warning; break;
          case false: channel.ChannelState = States.Normal; break;
        }
      }

      context.SaveChanges();
      Console.WriteLine($"Updated {channels.Count} channels");

      Thread.Sleep(2500);
    }
  }
}
