using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armstrong.Generator.Models
{
  [Table("histories")]
  public class History
  {
    [Key, Column("id")]
    public long Id { get; set; }
    [Column("channel_id")]
    public int ChannelId { get; set; }
    [Column("event_impulse_value")]
    public double EventImpulseValue { get; set; }
    [Column("event_system_value")]
    public double EventSystemValue { get; set; }
    [Column("event_not_system_value")]
    public double EventNotSystemValue { get; set; }
    [Column("event_datetime")]
    public DateTime EventDateTime { get; set; }
    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
  }
}
