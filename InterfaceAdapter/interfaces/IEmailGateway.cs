
namespace WPFCleanArchitecture.InterfaceAdapter.Interfaces
{
    public interface IEmailGateway
        {
            void SendEmail(string to, string subject, string content);            
        }
}