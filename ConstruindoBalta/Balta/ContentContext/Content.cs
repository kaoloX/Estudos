using System;

namespace Balta.ContentContext {

     //Conteúdo é uma classe privada onde as outras classes serão derivadas dela.   
    public abstract class Content 
    {     
        //Construtor da classe Content, passando as propriedades title e url.
        public Content(string title, string url)
        {   
            //criando o Guid com o construtor da classe Content.
            Id = Guid.NewGuid();
            Title = title;
            Url = url;
        }
        //No código abaixo e utilizado o Guid, que basicamente criará automaticamente
        //uma hash de 36 caracteres (código id) no banco de dados.
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Url { get; set; }
    }

}