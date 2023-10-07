namespace Name
{
    public abstract class Decorator : INotification
    {
        protected INotification notification;

        public Decorator(INotification _notification)
        {
            notification = _notification;           
        }

        public abstract void EnviarMensagem(string msg);
    }
}