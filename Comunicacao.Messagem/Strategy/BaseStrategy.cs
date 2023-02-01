using System;
using Comunicacao.Messagem.Validations;
using FluentValidation.Results;

namespace Comunicacao.Messagem
{
    public class BaseStrategy : INotifierComponent
    {
        private readonly INotifierComponent _notifierComponent;
        protected string CodPhone = ConfiguracaoAppSettings.GetValueKey("codPhone");
        public string PhoneSmsAndMms = ConfiguracaoAppSettings.GetValueKey("phoneNumber_to_sms");
        public string PhoneWhatsApp = ConfiguracaoAppSettings.GetValueKey("phoneNumber_to_whats");

        public BaseStrategy (INotifierComponent notifierComponent)
        {
            _notifierComponent = notifierComponent;
        }

        public virtual void Send(Message message)
        {
            try
            {
                CustomerValidator validator = new CustomerValidator();
                ValidationResult result = validator.Validate(message);

                // Write types
                ILogComponentDecorator writeFile = new MemoryStreamDecorator();
                writeFile.WriteData(message);

                // ILogComponentDecorator writeFile = new FileDecorator();
                // writeFile.WriteData(message);

                _notifierComponent.Send(message);

                Console.WriteLine("Message sent successfully !");
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
                throw new Exception(exception.Message);
            }
        }
    }
}