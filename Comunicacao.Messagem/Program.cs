using System;

namespace Comunicacao.Messagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Send an outgoing SMS with Twilio !");
            string phoneNumberExemple = "61976430594";

            Console.WriteLine($"Provide the phone number. Example: ({phoneNumberExemple}): ");
            string phoneNumber = Console.ReadLine();

            Console.WriteLine("Report the message: ");
            string message = Console.ReadLine();

            INotifierComponent envio = new Notifier();

            INotifierComponent Mms = new MmsDecorator(envio);
            Message msg = new Message(phoneNumber, message);
            Mms.Send(msg);

            // INotifierComponent Sms = new SmsDecorator(envio);
            //Message msg = new Message(phoneNumber, message);
            // Sms.Send(msg);

            // INotifierComponent zap = new WhatsappDecorator(envio);
            //Message msg = new Message(phoneNumber, message);
            // zap.Send(msg);
        }
    }
}
