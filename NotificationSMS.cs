namespace Name
{
    public class NotificationSMS : INotification
    {
        public void EnviarMensagem(string msg)
        {
            System.Console.WriteLine($"SMS: {msg}");
        }
    }
}