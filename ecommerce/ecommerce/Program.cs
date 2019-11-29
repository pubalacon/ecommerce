using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Program
    {
        static void CentraleProductsResults(string searchInput, Central centrale)
        {
            Console.Write("Search Result: ");
            Console.WriteLine("Name | Description | Price | Stock | Vendor");
            // foreach (Product article in centrale.SearchArticles("velo")) // attention, si liste nulle ?
            //foreach (Product item in centrale.SearchArticles("velo") ?? new List<Product>())
            foreach (Product item in centrale.SearchArticles(searchInput) ?? new List<Product>())
            {
                Console.WriteLine($"{item.Name} | {item.Description}  | {item.Price} | {item.Stock} | {item.Vendor.Name}");
            }
        }

        static void BasketProductsList(Basket basket)
        {
            Console.Write("Products found in basket: ");
            Console.WriteLine("Name | Description | Price | Stock | Vendor");
            foreach (KeyValuePair<Product,int> item in basket.ArticlesQte)
            {
                Console.WriteLine($"{item.Key.Name} | {item.Key.Description}  | {item.Key.Price} | {item.Key.Stock} | {item.Key.Vendor.Name}");
            }
        }
        static void Main(string[] args)
        {
            Central centrale = new Central();

            // USERS
            /*
            User client1 = new Client("jean", "j@gmail.com","pass");
            Client client2 = new Client("paul", "p@gmail.com", "pass");
            User vendor1 = new Vendor("Momo", "m@gmail.com", "pass");
            centrale.Users.Add(client1);
            centrale.Users.Add(client2);
            centrale.Users.Add(vendor1);
            */

            // CREATE USER


            // USER INPUT
            /*
            Console.Write("Enter email address: ");
            string mail = Console.ReadLine();
            Console.Write("Enter password: ");
            string password = Console.ReadLine();

            User LogClient = Tools.LoginRetry(mail, password, centrale);
            Console.WriteLine($"Bonjour {LogClient.Name} !");
            Console.ReadKey();
            */

            // PRODUCTS
            Client client1 = null;
            User vendor1 = null;


            client1 = (Client)centrale.InputUserAccount();
            vendor1 = (Vendor)centrale.InputUserAccount();

            if (client1 != null && vendor1 != null)
            {
                Product art1 = new Product("velo", "un super velo", 105, (Vendor)vendor1); // on caste vendeur car il est declaré en User (et pas Vendeur comme l'attend Product)
                Product art2 = new Product("montre", "une rolex d'exception", 50000, (Vendor)vendor1); // on caste vendeur car il est declaré en User (et pas Vendeur comme l'attend Product)
                Product art3 = new Product("parapluie", "un parapluie pour 2", 10, (Vendor)vendor1); // on caste vendeur car il est declaré en User (et pas Vendeur comme l'attend Product)

                centrale.AddArticle(art1);
                centrale.AddArticle(art2);
                centrale.AddArticle(art3);

                centrale.UpdateStockArticle(art1, 1);
                centrale.UpdateStockArticle(art2, 0);
                centrale.UpdateStockArticle(art3, 1);

                CentraleProductsResults("", centrale);

                client1.Panier.AddArticleToPanier(art1, 1);
                client1.Panier.AddArticleToPanier(art2, 1);
                client1.Panier.AddArticleToPanier(art3, 1);

                BasketProductsList(client1.Panier);

                client1.Panier.RemoveArticleFromPanier(art1, 1);

                BasketProductsList(client1.Panier);

                centrale.UpdateStockArticle(art2, 3);
                client1.Panier.ModifyQuantity(art2, 3);

                BasketProductsList(client1.Panier);

                client1.CommanderPanier();
            }

            Console.ReadKey();

        }
    }
}
