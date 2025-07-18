using System;

namespace News_Publisher_Subscriber_Example
{
    public class NewsPublisher2_0
    {
        public class NewsArticle2
        {
            public string Title { get; set; }
            public string Content { get; set; }

            public NewsArticle2(string title, string content)
            {
                Title = title;
                Content = content;
            }
        }

        public class NewsPublicsher
        {
            public event Action<NewsArticle> NewsPublished2;

            public void publish(string title, string content)
            {
                NewsArticle article = new NewsArticle(title, content);
                NewsPublished2?.Invoke(article);
            }
        }

        public class NewsSubscriber
        {
            private string _name;

            public NewsSubscriber(string name)
            {
                _name = name;
            }

            public void Subscribe(NewsPublicsher Publish)
            {
                Publish.NewsPublished2 += OnNewsPublished;
            }
            public void UnSubscribe(NewsPublicsher Publish)
            {
                Publish.NewsPublished2 -= OnNewsPublished;
            }
            private void OnNewsPublished(NewsArticle article)
            {
                Console.WriteLine($"{_name} received news: {article.Title} - {article.Content}");
            }
        }
        
    }
}