using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Basket
    {
        public Client Client { get; set; }
        public List<KeyValuePair<Product, int>> ArticlesQte { get; set; }

        public Basket(Client client)
        {
            Client = client;
            ArticlesQte = new List<KeyValuePair<Product, int>> { };
        }
        public void AddArticleToPanier(Product article, int quantity)
        {
            if (article.Stock >= quantity)
            {
                ArticlesQte.Add(new KeyValuePair<Product, int>(article, quantity));
            }
            else
            {
                Console.WriteLine(article.Name + " is out of stock, you ordered " + quantity + " and there are only " + article.Stock + " left");
            }

        }
        public void ModifyQuantity(Product article, int newQuantity)
        {
            // KeyValuePair is immutable,we need to recreate a new one (and therefore delete the old one)
            List<KeyValuePair<Product, int>> tmp = ArticlesQte.Where(x => x.Key == article).ToList();
            if (tmp != null)
            {
                foreach (KeyValuePair<Product, int> item in tmp)
                {
                    RemoveArticleFromPanier(item.Key, item.Value);
                }
            }
            
            AddArticleToPanier(article, newQuantity);
        }
        public void RemoveArticleFromPanier(Product article, int quantity)
        {
            ArticlesQte.Remove(new KeyValuePair<Product, int>(article,quantity));
        }

    }
}
