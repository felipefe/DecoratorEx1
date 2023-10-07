namespace Name
{
    class Program
    {
        static void Main(string[] args)
        {
            INotification notifyEmail = new NotificationEmail();
            var notificador_personalizado = new DecoratorMsgAssinatura(notifyEmail);
            var anexo = new DecoratorMsgAnexo(notificador_personalizado); 

            var mensagem = "Mensagem importante!";
            //notificador_personalizado.EnviarMensagem(mensagem);
            anexo.EnviarMensagem(mensagem);
        }
    }
}