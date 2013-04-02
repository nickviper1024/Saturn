using ViperSoft.Saturn.Models.Interfaces;

namespace ViperSoft.Saturn.Repository.Interfaces
{
    public interface IFileRepository : ICrudRepository<IFile>
    {
        long Import(string fileNumber);
    }
}