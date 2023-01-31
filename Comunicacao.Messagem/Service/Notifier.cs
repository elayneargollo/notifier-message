using System.Linq;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Comunicacao.Messagem
{
    public class Notifier : INotifierComponent
    {
        
        protected string AccountSid = ConfiguracaoAppSettings.GetValueKey("accountSid");
        protected string AuthToken = ConfiguracaoAppSettings.GetValueKey("authToken");

        public void Send(Message message)
        {
            TwilioClient.Init(AccountSid, AuthToken);

            MessageResource response = MessageResource.Create(
                body: message.MessageSend,
                from: new Twilio.Types.PhoneNumber(message.PhoneOrigin),
                mediaUrl: message.MediaUrl,
                to: new Twilio.Types.PhoneNumber(message.PhoneNumberDestiny)
            );
        }
    }
}