using System.Collections.Generic;
using Balta.SharedContext;

namespace Balta.ContentContext
{
     //Classe de Módulos do Curso.
    public class Module : Base
    {   
        public Module ()
        {   
            //Inicializando a classe de Aulas pelo construtor da classe de Modulos.
            Lectures = new List<Lecture>();
        }   
        //Ordem do módulo exemplo 1,2,3,4
        public int Order { get; set; }
        public string Title { get; set; }
        
        //Lista de Aulas
        public IList<Lecture> Lectures { get; set; }
    }
}