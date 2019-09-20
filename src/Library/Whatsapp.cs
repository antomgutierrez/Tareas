using System;

namespace Library
{
    public class Whatsapp : Message
    {
        public void Send(Whatsapp message)
        {
            // to "+598<Poné tu teléfono acá>"
            // text "Hey there! I'm using WhatsAppUCU"
            const string accountSid = "ACa8395e7223e7719988c09db8dfb68f0f";
            const string authToken = "fdcaac12dc7e5b031908429ee402e7a4";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send(message.To, message.Text);
            Console.WriteLine(sid);

        }

    }

}