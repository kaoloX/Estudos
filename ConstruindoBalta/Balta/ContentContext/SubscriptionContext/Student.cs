using System.Collections.Generic;
using System.Linq;
using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{
    public class Student : Base
    {   
        public Student()
        {
            Subscriptions = new List<Subcription>();
        }
        public string Name { get; set; }

        public string Email { get; set; }
        public Users User { get; set; }

        //Criando uma lista de Assinaturas para o Estudante
        public IList<Subcription> Subscriptions { get; set; }


        //Método para criar uma nova assinatura.
        public void CreateSubscription (Subcription subcription)
        {   
            //verifica se o usuário é premium
            if (IsPremium)
            {
                AddNotification(new Notification("Premium", "O aluno já tem uma assinatura ativa"));
                //return para ele não continuar no método.
                return;
            }
            //Se não ele adiciona uma nova assinatura.
            Subscriptions.Add(subcription);
        }

        //Verificação se a assinatura do estudante estiver inativa o acesso
        //será negado.
        public bool IsPremium => Subscriptions.Any(x=>!x.IsInactive);
    } 
}