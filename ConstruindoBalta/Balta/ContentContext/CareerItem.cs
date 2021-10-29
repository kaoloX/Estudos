using Balta.NotificationContext;
using Balta.SharedContext;

namespace Balta.ContentContext
{   

    //Classe de Itens que contém dentro da Carreira.
      public class CareerItem : Base
    {
        public CareerItem(int order, string title, string description, Course course)
        {   
            //No código abaixo e realizado a validação se o curso é nulo ou não
            //caso o mesmo sendo nulo ele irá imprimir uma mensagem por meio
            //de uma notificação.
            if(course == null)
                AddNotification(new Notification("Course", "Curso inválido."));
                
            Order = order;
            Title = title;
            Description = description;
            Course = course;
        }

        //Ordem da Carreira
        public int Order { get; set; }
        //Titulo da Carreira
        public string Title { get; set; }
        //Descrição da Carreira
        public string Description { get; set; }

        public Course Course {get; set;}
    }
}
