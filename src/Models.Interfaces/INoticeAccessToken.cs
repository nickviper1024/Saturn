using System;

namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface INoticeAccessToken
    {
        long Id { get; set; }
        string User { get; set; }
        NoticeType NoticeType { get; set; }
        long NoticeId { get; set; }
        DateTime Start { get; set; }
        DateTime? End { get; set; }
    }
}