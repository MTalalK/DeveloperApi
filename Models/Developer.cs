using System.ComponentModel.DataAnnotations;

namespace DeveloperApi.Models;
public class Developer
{
    [Key]
    public int id {  get; set; }
    public string Name { get; set; } = "";
    public string Projects { get; set; } = "";
    public string Unit { get; set; } = "";
    public string UnitType { get; set; } = "";
    public string Level { get; set; } = "";
    public string Location { get; set; } = "";
    public string Exposure { get; set; } = "";
    public int Size { get; set; } = 0;
    public int BedRoom { get; set; }
    public int BathRoom { get; set; }
    public bool Parking { get; set; }
    public bool Locker { get; set; }
    public bool Balcony { get; set; }
}
