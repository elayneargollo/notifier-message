using System;

namespace Comunicacao.Messagem
{
    public class SmsAdapter : BaseAdapter
    {
        protected string CodPhone = ConfiguracaoAppSettings.GetValueKey("codPhone");
        public string _PhoneOrigin = ConfiguracaoAppSettings.GetValueKey("phoneNumber_to_sms");

        public SmsAdapter(INotifierComponent envioComponent) : base(envioComponent) { }

        public override void Send(Message msg)
        {
            msg.PhoneNumberDestiny = String.Concat(CodPhone, msg.PhoneNumberDestiny);
            msg.PhoneOrigin = _PhoneOrigin;

            base.Send(msg);
        }
    }
}