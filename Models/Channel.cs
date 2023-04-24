using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Armstrong.Generator.Models
{
  [Table("channels")]
  public class Channel
  {
    [Key, Column("id")]
    public long Id { get; set; }

    [Column("name")]
    public string? ChannelName { get; set; }

    [Column("channel_id")]
    public int ChannelId { get; set; }

    [Column("device_id")]
    public int DeviceId { get; set; }

    [Column("room_id")]
    public int RoomId { get; set; }

    [Column("server_id")]
    public int ServerId { get; set; }

    [Column("service_id")]
    public int ServiceId { get; set; }

    [Column("location_description")]
    public string? LocationDescription { get; set; }

    [Column("self_background")]
    public double SelfBackground { get; set; }

    [Column("pre_emergency_limit")]
    public double PreEmergencyLimit { get; set; }

    [Column("emergency_limit")]
    public double EmergencyLimit { get; set; }

    [Column("consumptiom")]
    public double Consumptiom { get; set; }

    [Column("conversion_coefficient")]
    public double ConversionCoefficient { get; set; }

    [Column("event_system_value")]
    public double EventSystemValue { get; set; }

    [Column("event_not_system_value")]
    public double EventNotSystemValue { get; set; }

    [Column("event_impulse_value")]
    public double EventImpulseValue { get; set; }

    [Column("event_datetime")]
    public DateTime EventDatetime { get; set; }

    [Column("event_count")]
    public int EventCount { get; set; }

    [Column("event_error_count")]
    public int EventErrorCount { get; set; }

    [Column("is_special_control")]
    public bool IsSpecialControl { get; set; }

    [Column("is_online")]
    public bool IsOnline { get; set; }

    [Column("state")]
    public string? ChannelState { get; set; }

    [Column("created_at")]
    public DateTime CreatedAt { get; set; }

    [Column("updated_at")]
    public DateTime UpdatedAt { get; set; }
  }
}
