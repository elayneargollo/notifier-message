using System;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Rest.Conversations.V1;
using Twilio.Types;

namespace Comunicacao.Messagem
{
    public class ConfigurationService : IConfigurationService
    {
        protected string AccountSid = ConfiguracaoAppSettings.GetValueKey("accountSid");
        protected string AuthToken = ConfiguracaoAppSettings.GetValueKey("authToken");
        protected string PhoneNumber = ConfiguracaoAppSettings.GetValueKey("phoneNumber_to");
        protected string CodPhone = ConfiguracaoAppSettings.GetValueKey("codPhone");

        public void MessageSend(Message message)
        {
            TwilioClient.Init(AccountSid, AuthToken);

            // message.PhoneNumber = String.Concat(CodPhone, message.PhoneNumber);

            // MessageResource response = MessageResource.Create(
            //     body: message.MessageSend,
            //     from: new Twilio.Types.PhoneNumber(PhoneNumber),
            //     to: new Twilio.Types.PhoneNumber(message.PhoneNumber)
            // );

            // if (response.ErrorCode != null)
            //     throw new Exception();

            
            MessageResource response = MessageResource.Create(
                body: "mesma coisa?",
                from: new Twilio.Types.PhoneNumber("whatsapp:+14155238886"),
                to: new Twilio.Types.PhoneNumber("whatsapp:+557191724153")
            );   
        }
    }
}