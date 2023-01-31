using System;
using System.Collections.Generic;
using System.Linq;

namespace Comunicacao.Messagem
{
    public class MmsDecorator : BaseDecorator
    {
        protected string CodPhone = ConfiguracaoAppSettings.GetValueKey("codPhone");
        public string _PhoneOrigin = ConfiguracaoAppSettings.GetValueKey("phoneNumber_to_sms");

        public MmsDecorator(INotifierComponent envioComponent) : base(envioComponent) { }

        public override void Send(Message msg)
        {
            Console.WriteLine("Report the uri:");
            string uri = Console.ReadLine();

            msg.PhoneNumberDestiny = String.Concat(CodPhone, msg.PhoneNumberDestiny);
            msg.PhoneOrigin = _PhoneOrigin;

            msg.MediaUrl = new[] {
                new System.Uri(uri)
            }.ToList();

            base.Send(msg);
        }
    }
}