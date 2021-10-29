using System;
using System.Collections.Generic;
using System.Linq;
using Balta.ContentContext;
using Balta.SubscriptionContext;

namespace Balta
{
    class Program
    {
        static void Main(string[] args)
        {   
            //Inserindo uma nova lista de Artigos
            var articles = new List<Article>();
            //Adicionando um conteúdo a lista de Artigos
            articles.Add(new Article("Artigo sobre OOP", "orientacao-objetos"));
            articles.Add(new Article("Artigo sobre C#", "csharp"));
            articles.Add(new Article("Artigo sobre ASP.NET", "aspnetcore"));
            articles.Add(new Article("Artigo sobre .NETCORE", ".dotnetcore"));

            foreach (var article in articles)
            {
                Console.WriteLine(article.Id);
                Console.WriteLine(article.Title);
                Console.WriteLine(article.Url);
            }
            //Iniciando uma nova lista de Cursos.
            var courses = new List<Course>();
            var courseOOP = new Course("Fundamentos OOP", "fundamentos-oop");
            var courseCsharp = new Course("Fundamentos C#", "fundamentos-c#");
            var courseAspNet = new Course("Fundamentos ASP.NET", "fundamentos-aspnet");

            //Adicionando os novos Cursos
            courses.Add(courseOOP);
            courses.Add(courseCsharp);
            courses.Add(courseAspNet);


            //Criando uma nova lista de Carreiras e implementando os cursos.
            var careers = new List<Career>();
            var careerDotNet = new Career("Especialista .NET", "especialista-dotnet");
            var careerItem2 = new CareerItem(2,"Aprenda .NET", "", courseOOP);
            var careerItem1 = new CareerItem(1,"Comece por aqui", "", courseCsharp);
            var careerItem3 = new CareerItem(3,"Aprenda AspNet", "", null);
            
            //Adicionando novos Itens de Carreiras.
            careerDotNet.Items.Add(careerItem2);
            careerDotNet.Items.Add(careerItem1);
            careerDotNet.Items.Add(careerItem3);
            careers.Add(careerDotNet);


            //Percorrendo as Carreiras
            foreach (var career in careers)
            {
                Console.WriteLine(career.Title);
                //Percorrendo as listas e ordenando as utilizando o Orderby.
                foreach (var item in career.Items.OrderBy(x => x.Order))
                {
                    Console.WriteLine($"{item.Order} - {item.Title}");
                    //Imprimindo um titulo do curso.
                    Console.WriteLine(item.Course?.Title);
                    //Imprimindo um level do Curso.
                    Console.WriteLine(item.Course?.Level);

                    //Se houver alguma notificação dentro da carreira
                    //a mesma será exibida.
                    foreach (var notification in item.Notifications)
                    {
                        Console.WriteLine($"{notification.Property} - {notification.Message}");
                    }
                }

                //Criando uma assinatura para o aluno
                var payPalSubscription = new PayPalSubscription();
                var student = new Student();
                student.Subscriptions.Add(payPalSubscription);
            }

            /*Console.WriteLine("Hello World!");
            var course = new Course();
            //Iniciando a classe de Enum do level do Curso.
            course.Level = ContentContext.Enums.EContentLevel.Advanced;
            foreach (var item in course.Modules)
            {

            }
            //criação da variável de Carreira.
            var career = new Career();
            //Adicionando um novo Item na Carreira.
            career.Items.Add(new CareerItem());
            Console.WriteLine(career.TotalCourses);
            */
        }
    }
}
