namespace Name
{
    public class NotificationEmail : INotification
    {
        public void EnviarMensagem(string msg)
        {
            System.Console.WriteLine($"Email: {msg}");
        }
    }
}