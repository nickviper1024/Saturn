using System.Collections.Generic;

namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface IFile
    {
        long Id { get; set; }
        string FileNumber { get; set; }
        string BankruptcyCaseNumber { get; set; }
        string Jurisdiction { get; set; }
        string BankruptcyChapterNumber { get; set; }
        string BankruptcyJudge { get; set; }
        string BankruptcyTrustee { get; set; }
        string LoanNumber { get; set; }
        string PropertyAddress { get; set; }
        IEnumerable<IDebtor> Debtors { get; set; }
        string Client { get; set; }
    }
}