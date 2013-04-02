using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViperSoft.Saturn.Models.Interfaces;

namespace Repository.Interfaces
{
    public interface INoticeRepository
    {
        INotice GetById(long noticeId);
        
    }
}
