using System;
using System.Collections.Generic;
using System.Xml.Linq;

public class NewsEventArgs : EventArgs
{
    public string Category { get; set; }
    public string News { get; set; }
}

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