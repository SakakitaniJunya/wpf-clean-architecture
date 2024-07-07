using WPFCleanArchitecture.InterfaceAdapter.Interfaces;

namespace WPFCleanArchitecture.Infrastructure.ExternalService
{
   public class EmailGateway : IEmailGateway
   {
        public void SendEmail(string to, string subject, string content)
            {
               return ;
            }
   }
}