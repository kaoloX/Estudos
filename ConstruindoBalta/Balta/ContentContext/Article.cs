namespace Balta.ContentContext {

    public class Article : Content 
    {
        public Article(string title, string url)
        //Passando os construtores de Content por meio do :base
            :base(title, url)
        {
            
        }
    }
}