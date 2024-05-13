using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    public class Client
    {
        public string Name { get; set; }

        public Client(string name)
        {
            Name = name;
            NewsProvider.Instance.NewsPublished += OnNewsReceived;
        }

        public void SubscribeToNews(NewsProvider newsProvider, string category)
        {
            newsProvider.Subscribe(category, this);
        }

        public void UnsubscribeFromNews(NewsProvider newsProvider, string category)
        {
            newsProvider.Unsubscribe(category, this);
        }

        private void OnNewsReceived(object sender, NewsEventArgs e)
        {
            if (e.Category == "news")
            {
                Console.WriteLine($"{Name} received news: {e.News}");
            }
        }
    }
}
