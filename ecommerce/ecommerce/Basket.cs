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
            ArticlesQte.Add(new KeyValuePair<Product, int>(article, quantity));
        }
        public void ModifyQuantity(Product article, int newQuantity)
        {
            throw new NotImplementedException();
        }
        public void RemoveArticleFromPanier(Product article)
        {
            throw new NotImplementedException();
        }

    }
}
