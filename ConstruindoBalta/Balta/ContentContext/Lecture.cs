using Balta.ContentContext.Enums;
using Balta.SharedContext;

namespace Balta.ContentContext
{
     //Classe de Aulas do Curso
    public class Lecture : Base
    {
        public int Order { get; set; }
        public string Title { get; set; }

        public int DurationInMinutes { get; set; }
        
        //Iniciando a clsse de Enumeradores da propriedade Levels.
        //Esta classe e necessária pois quando for necessário acessar
        //ou atribuir um nivel a um Curso, saberemos qual nivel ele é.
        public EContentLevel Level { get; set; }
    }
}