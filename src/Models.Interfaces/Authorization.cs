using System.ComponentModel;

namespace ViperSoft.Saturn.Models.Interfaces
{
    public enum Authorization : int
    {
        [Description("Create Notices")]
        CreateNotice = 0,
        [Description("Delete Notices")]
        DeleteNotice
    }
}