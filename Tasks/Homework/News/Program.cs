namespace News
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;

    

    

    

    class Program
    {
        static void Main(string[] args)
        {
            Client client1 = new Client("Nikita");
            Client client2 = new Client("Fedor");

            client1.SubscribeToNews(NewsProvider.Instance, "news");
            client2.SubscribeToNews(NewsProvider.Instance, "news");

            NewsProvider.Instance.PublishNews("news", "A victory parade will take place in Minsk today");

            Console.ReadLine();
        }
    }
}
