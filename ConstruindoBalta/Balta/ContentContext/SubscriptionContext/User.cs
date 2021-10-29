using System.Collections.Generic;
using Balta.SharedContext;

namespace Balta.SubscriptionContext
{   

    //Classe destinada ao usuário do curso.
    public class Users : Base
    {
        public string Username { get; set; }

        public string Password { get; set; }
        

        //Lista de Assinaturas do aluno.
        public IList<Subcription> Subscriptions { get; set; }
    }
}