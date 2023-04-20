using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armstrong.Generator.Models
{
  [Table("channels")]
  public class Channel
  {
    [Key, Column("id")]
    public long Id { get; set; }

    [Key, Column("name")]
    public string? ChannelName { get; set; }

    [Key, Column("channel_id")]
    public int ChannelId { get; set; }

    [Key, Column("device_id")]
    public int DeviceId { get; set; }

    [Key, Column("room_id")]
    public int RoomId { get; set; }

    [Key, Column("server_id")]
    public int ServerId { get; set; }

    [Key, Column("service_id")]
    public int ServiceId { get; set; }

    [Key, Column("location_description")]
    public string? LocationDescription { get; set; }

    [Key, Column("self_background")]
    public double SelfBackground { get; set; }

    [Key, Column("pre_emergency_limit")]
    public double PreEmergencyLimit { get; set; }

    [Key, Column("emergency_limit")]
    public double EmergencyLimit { get; set; }

    [Key, Column("consumptiom")]
    public double Consumptiom { get; set; }

    [Key, Column("conversion_coefficient")]
    public double ConversionCoefficient { get; set; }

    [Key, Column("event_system_value")]
    public double EventSystemValue { get; set; }

    [Key, Column("event_not_system_value")]
    public double EventNotSystemValue { get; set; }

    [Key, Column("event_impulse_value")]
    public double EventImpulseValue { get; set; }

    [Key, Column("event_datetime")]
    public DateTime EventDatetime { get; set; }

    [Key, Column("event_count")]
    public int EventCount { get; set; }

    [Key, Column("event_error_count")]
    public int EventErrorCount { get; set; }

    [Key, Column("is_special_control")]
    public bool IsSpecialControl { get; set; }

    [Key, Column("is_online")]
    public bool IsOnline { get; set; }

    [Key, Column("state")]
    public string? ChannelState { get; set; }

    [Key, Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Key, Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
  }
}
