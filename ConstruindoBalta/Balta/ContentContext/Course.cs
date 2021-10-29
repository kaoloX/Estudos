using System.Collections.Generic;
using Balta.ContentContext.Enums;

namespace Balta.ContentContext {
    
    public class Course : Content 
    {    
        
        public  Course (string title,  string url)
        //Passando os construtores de Content por meio do :base
        :base(title,url)
        {
            //Para inicializar uma classe e essencial e de boa prática utiliza-la
            //dentro do método construtor conforme abaixo:
            Modules = new List<Module>();
        }

        public string Tag { get; set; }

        //Lista de Modulos do Curso.
        public IList<Module> Modules { get; set;}

        //Duração do curso em minutos.
        public int DurationInMinutes { get; set; }

        //Iniciando a clsse de Enumeradores da propriedade Levels.
        //Esta classe e necessária pois quando for necessário acessar
        //ou atribuir um nivel a um Curso, saberemos qual nivel ele é.
        public EContentLevel Level { get; set; }

    } 

}