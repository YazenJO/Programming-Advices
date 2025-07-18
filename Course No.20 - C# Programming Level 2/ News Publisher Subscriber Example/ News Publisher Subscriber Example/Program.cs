using System;

namespace News_Publisher_Subscriber_Example
{
    public class NewsArticle
    {
        public string Title { get; set; }
        public string Content { get; set; }

        public NewsArticle(string title, string content)
        {
            Title = title;
            Content = content;
        }
    }
    
    public class NewsPublisher
    {
       

        public event Action<NewsArticle> NewsPublished;

        public void publish(string title, string content)
        {
            NewsArticle article = new NewsArticle(title, content);
            OnNewsPublished(article);
        }

        protected virtual void OnNewsPublished(NewsArticle article)
        {
            NewsPublished?.Invoke(article);
        }
    }
    public class NewsSubscriber
    {
        private string _name;

        public NewsSubscriber(string name)
        {
            _name = name;
        }

        public void Suscribee(NewsPublisher publisher)
        {
            publisher.NewsPublished += OnNewsPublished;
        }

        public void Unsubscribe(NewsPublisher publisher)
        {
            publisher.NewsPublished -= OnNewsPublished;
        }

        private void OnNewsPublished(NewsArticle article)
        {
            Console.WriteLine($"{_name} received news: {article.Title} - {article.Content}");
        }
    }
    
    
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            NewsPublisher newsPublisher = new NewsPublisher();

            NewsSubscriber subscriber1 = new NewsSubscriber("Subscriber 1");
            NewsSubscriber subscriber2 = new NewsSubscriber("Subscriber 2");

            subscriber1.Suscribee(newsPublisher);
            subscriber2.Suscribee(newsPublisher);

            newsPublisher.publish("Breaking News", "This is the content of the breaking news.");

            subscriber1.Unsubscribe(newsPublisher);

            newsPublisher.publish("Another Breaking News", "This is the content of another breaking news.");
        }
    }
}