using System.Collections;
using System.Collections.Generic;

namespace Balta.ContentContext {
    
    public class Career : Content
    {   
        public Career(string title, string url)
        //Passando os construtores de Content por meio do :base
        :base(title, url)
        {
        
            //Inicialização pelo método Construtor da  classe de Career
            //da Lista CareerItem.
            Items = new List<CareerItem>();
        }
        //Criação da Lista de Itens da Carreira.
        public IList<CareerItem> Items { get; set; }

        
        //Propriedade para inputar a quantidade de cursos da Carreira
        //Sempre que tiver apenas um retorno no Get, pode-se utilizar a Expression Body
        //Conforme utilizado abaixo, pois o mesmo resultará no mesmo resultado final.
        public int TotalCourses => Items.Count;
    }
    

}