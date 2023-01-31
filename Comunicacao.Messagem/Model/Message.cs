public class Message
{
    public string PhoneNumberDestiny { set; get; }
    public string MessageSend { set; get; }
    public string PhoneOrigin { set; get; }

    public Message(string phoneNumber, string messageSend)
    {
        PhoneNumberDestiny = phoneNumber;
        MessageSend = messageSend;
    }
}
