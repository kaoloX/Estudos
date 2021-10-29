namespace Balta.NotificationContext {
    

    //A classe de notificações será selada então toda e qualquer modificação, nem extensão
    //na classe, deverá ser feita na classe de Notificação.
    public sealed class Notification
    {    
        public Notification()
        {
            
        }

        public Notification(string property, string message )
        {
            Property = property;
            Message = message;
        }
        //Propriedade destinada as propriedades que darão erro no sistema.
        public string Property { get; set; }
        //Propriedade destinada a mensagem de Notificação.
        public string Message { get; set; }
    }

    

}