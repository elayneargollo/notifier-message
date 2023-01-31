using System;

namespace Comunicacao.Messagem
{
    public class WhatsappAdapter : BaseAdapter
    {
        protected string CodPhone = ConfiguracaoAppSettings.GetValueKey("codPhone");
        public string _PhoneOrigin = ConfiguracaoAppSettings.GetValueKey("phoneNumber_to_whats");

        public WhatsappAdapter(INotifierComponent notifierComponent) : base(notifierComponent) { }

        public override void Send(Message msg)
        {
            msg.PhoneNumberDestiny = String.Concat("whatsapp:", CodPhone, msg.PhoneNumberDestiny);
            msg.PhoneOrigin = String.Concat("whatsapp:", msg.PhoneOrigin);

            base.Send(msg);
        }
    }
}