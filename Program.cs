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
    var history = new List<History>();

    channels = context.Channels.ToList<Channel>();
    history = context.Histories.ToList<History>();

    Console.WriteLine($"Found {channels.Count} channels");

    while (true)
    {
      foreach (var channel in channels)
      {
        channel.EventImpulseValue = random.NextDouble() / 2;
        channel.EventSystemValue = random.NextDouble();
        channel.EventSystemValue = random.NextDouble() * 5.5f;
        channel.EventDateTime = DateTime.UtcNow;
        channel.UpdatedAt = DateTime.UtcNow;
        channel.EventCount++;

        switch (channel.EventSystemValue > 0.3f)
        {
          case true: channel.ChannelState = States.Warning; break;
          case false: channel.ChannelState = States.Normal; break;
        }

        context.Histories.Add(new History
        {
          ChannelId = (int)channel.Id,
          EventImpulseValue = channel.EventImpulseValue,
          EventSystemValue = channel.EventSystemValue,
          EventNotSystemValue = channel.EventNotSystemValue,
          EventDateTime = channel.EventDateTime,
          UpdatedAt = channel.UpdatedAt,
          CreatedAt = DateTime.UtcNow
        });
      }

      context.SaveChanges();
      Console.WriteLine($"Updated {channels.Count} channels");

      Thread.Sleep(2500);
    }
  }
}
