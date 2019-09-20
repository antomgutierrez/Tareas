namespace Library
{
    public class Message
    {
        protected Message(string from, string to)
        {
            this.From = from;
            this.To = to;
        }

        public string Text { get; set; }

        public string From { get; }

        public string To { get; }

        public static Message CreateMessage(string from, string to, string text){
            var resultado = new Message(from, to);
            resultado.Text = text;
            return resultado;
        }
    }
}