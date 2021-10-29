using System;
using Balta.NotificationContext;

namespace Balta.SharedContext
{
    public abstract class Base : Notifiable
    {   

        public Base()
        {
            //criando o Guid com o construtor da classe Content.
            Id = Guid.NewGuid();
        }
        //No código abaixo e utilizado o Guid, que basicamente criará automaticamente
        //uma hash de 36 caracteres (código id) no banco de dados.
        public Guid Id { get; set; }
    }
}