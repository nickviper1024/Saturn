using System;

namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface IDocument
    {
        byte[] Contents { get; set; }
        DateTime CreateDate { get; set; }
    }
}