using System;

namespace Comunicacao.Messagem
{
    public class WhatsappStrategy : BaseStrategy 
    {
        public WhatsappStrategy(INotifierComponent notifierComponent) : base(notifierComponent) { }

        public override void Send(Message msg)
        {
            msg.PhoneNumberDestiny = String.Concat("whatsapp:", CodPhone, msg.PhoneNumberDestiny);
            msg.PhoneOrigin = String.Concat("whatsapp:", PhoneWhatsApp);

            base.Send(msg);
        }
    }
}