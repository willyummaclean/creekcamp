using System.ComponentModel.DataAnnotations;

namespace CreekRiver.Models.DTOs;

public class CampsiteType
{
    public int Id { get; set; }
    public string CampsiteTypeName { get; set; }
    public int MaxReservationDays { get; set; }
    public decimal FeePerNight { get; set; }
}