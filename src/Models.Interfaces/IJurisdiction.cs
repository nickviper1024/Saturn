namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface IJurisdiction
    {
        long Id { get; set; }
        string State { get; set; }
        string District { get; set; }
        string Division { get; set; }
    }
}