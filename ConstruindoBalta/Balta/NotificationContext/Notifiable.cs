using System.Collections.Generic;
using System.Linq;

namespace Balta.NotificationContext 
{
    public abstract class Notifiable
    {   
        //Lista de Notificações.
        public List<Notification> Notifications { get; set; }

        public Notifiable()
        {
            Notifications = new List<Notification>();
        }
        
        //Método para adicionar uma nova notificação
        public void AddNotification(Notification notification)
        {
            Notifications.Add(notification);
        }

        public void AddNotifications(IEnumerable<Notification> notifications)
        {
            Notifications.AddRange(notifications);
        }

        //Propriedade que verifica se a notificação é realmente válida.
        //Por meio da função Any.        
        public bool IsInvalid => Notifications.Any();
    }
}