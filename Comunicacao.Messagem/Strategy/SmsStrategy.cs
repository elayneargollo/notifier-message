using System;

namespace Comunicacao.Messagem
{
    public class SmsStrategy : BaseStrategy 
    {
        public SmsStrategy(INotifierComponent envioComponent) : base(envioComponent) { }

        public override void Send(Message msg)
        {
            msg.PhoneNumberDestiny = String.Concat(CodPhone, msg.PhoneNumberDestiny);
            msg.PhoneOrigin = PhoneSmsAndMms;

            base.Send(msg);
        }
    }
}