using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Program
    {

        static void Main(string[] args)
        {
            Central centrale = new Central();

            User client1 = new Client("jean", "j@gmail.com","pass");
            Client client2 = new Client("paul", "p@gmail.com", "pass");
            User vendeur = new Vendor("Momo", "m@gmail.com", "pass");

            centrale.Users.Add(client1);
            centrale.Users.Add(client2);
            centrale.Users.Add(vendeur);

            Product art1 = new Product("velo", "un super velo", 105, (Vendor)vendeur); // on caste vendeur car il est declaré en User (et pas Vendeur comme l'attend Product)
            Product art2 = new Product("montre", "une rolex d'exception", 50000, (Vendor)vendeur); // on caste vendeur car il est declaré en User (et pas Vendeur comme l'attend Product)
            Product art3 = new Product("parapluie", "un parapluie pour 2", 10, (Vendor)vendeur); // on caste vendeur car il est declaré en User (et pas Vendeur comme l'attend Product)

            centrale.AddArticle(art1);
            centrale.AddArticle(art2);
            centrale.AddArticle(art3);
            centrale.UpdateStockArticle(art1, 10);

            client2.Panier.AddArticleToPanier(art1, 11);

            client2.CommanderPanier();

            foreach (Product article in centrale.SearchArticles("velo"))
            {
                Console.WriteLine(article.Name);
                Console.WriteLine(article.Description);
                Console.WriteLine(article.Price);
                Console.WriteLine(article.Stock);
                Console.WriteLine(article.Vendor.Nom);
            }

            Console.ReadKey();

            /**/
            Console.Write("Enter email address: ");
            string mail = Console.ReadLine();
            Console.Write("Enter password: ");
            string passwd = Console.ReadLine();

            User LogClient = Tools.LoginRetry(mail, passwd, centrale);
            Console.WriteLine($"Bonjour {LogClient.Nom} !");
            Console.ReadKey();
            /**/
        }
    }
}
