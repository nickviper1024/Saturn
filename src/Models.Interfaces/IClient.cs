namespace ViperSoft.Saturn.Models.Interfaces
{
    public interface IClient
    {
        long Id { get; set; }
        string Name { get; set; }
        string MailingAddress { get; set; }
    }
}