using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace News
{
    public class NewsProvider
    {
        private static NewsProvider instance;
        private Dictionary<string, List<Client>> subscribers = new Dictionary<string, List<Client>>();

        private NewsProvider() { }

        public static NewsProvider Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new NewsProvider();
                }

                return instance;
            }
        }

        public void Subscribe(string category, Client client)
        {
            if (!subscribers.ContainsKey(category))
            {
                subscribers[category] = new List<Client>();
            }

            if (!subscribers[category].Contains(client))
            {
                subscribers[category].Add(client);
            }
        }

        public void Unsubscribe(string category, Client client)
        {
            if (subscribers.ContainsKey(category) && subscribers[category].Contains(client))
            {
                subscribers[category].Remove(client);
            }
        }

        public event Action<object, NewsEventArgs> NewsPublished;

        public void PublishNews(string category, string news)
        {
            if (NewsPublished != null)
            {
                NewsPublished(this, new NewsEventArgs { Category = category, News = news });
            }
        }
    }
}
