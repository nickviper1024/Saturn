using System.Security.Principal;

namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface IUser 
    {
        long Id { get; set; }
        string Login { get; set; }
        bool Active { get; set; }
    }
}