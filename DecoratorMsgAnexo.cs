namespace Name
{
    public class DecoratorMsgAnexo : Decorator
    {
        public DecoratorMsgAnexo(INotification _notification) : base(_notification)
        {
        }

        public override void EnviarMensagem(string msg)
        {
            msg += " Documento anexado";
            base.notification.EnviarMensagem(msg);
        }
    }
}