namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface IRole
    {
        long Id { get; set; }
        string Name { get; set; }
        bool Active { get; set; }
    }
}