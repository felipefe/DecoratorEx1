namespace Name
{
    public class DecoratorMsgAssinatura : Decorator
    {
        public DecoratorMsgAssinatura(INotification _notification) : base(_notification)
        {
        }

        public override void EnviarMensagem(string msg)
        {
            msg += " Assinada digitalmente";
            this.notification.EnviarMensagem(msg);
        }

    }
}