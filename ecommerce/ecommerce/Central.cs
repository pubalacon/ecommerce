using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace ecommerce
{
    public class Central
    {
        public List<Client> Clients { get; set; }
        public List<Vendor> Vendors { get; set; }
        public List<Product> Articles { get; set; }
        public List<User> Users { get; set; }

        public Central()
        {
            Clients = new List<Client> { };
            Vendors = new List<Vendor> { };
            Articles = new List<Product> { };
            Users = new List<User> { };
        }

        // creation de compte
        public Client CreateClientAccount(string nom, string mail, string password)
        {
            throw new NotImplementedException();
        }
        public Vendor CreateVendorAccount(string nom, string mail, string password)
        {
            throw new NotImplementedException();
        }
        public User Login(string mail, string password)
        {
            User LogginIn = null;

            List<User> tmp = Users.Where((user) => user.Mail.Equals(mail)).ToList();

            if (tmp.Count() > 0)
            {
                LogginIn = tmp.First();
            }
            
            if (LogginIn == null)
            {
                throw new ArgumentException("Email not registered");
            }

            if (LogginIn.Password != password)
            {
                throw new ArgumentException("Wrong password");
            }
            return LogginIn;
        }
        public void AddArticle(Product article)
        {
            // add article to list
            if (article == null)
            {
                throw new ArgumentNullException();
            }
            Articles.Add(article);
        }
        public void DeactivateArticle(Product article)
        {
            // remove article from list
            if (article == null)
            {
                throw new ArgumentNullException();
            }
            article.Active = false; ;
        }
        public void UpdateStockArticle(Product article, int stock)
        {
            // Modify product or deactivate and add new product ?
            // add article to list
            if (article == null)
            {
                throw new ArgumentNullException();
            }
            article.Stock = stock;
        }
        public List<Product> SearchArticles (string searchInput)
        {
            List<Product> SearchResults = new List<Product>();
            foreach(Product article in Articles)
            {
                if (article.Active &&  (article.Name.Contains(searchInput) || article.Description.Contains(searchInput)))
                {
                    SearchResults.Add(article);
                }
            }
            return SearchResults;
        }
        public List<Product> SearchArticles(string searchInput, double minPrice, double maxPrice)
        {
            List<Product> SearchResults = SearchArticles(searchInput);

            //return SearchResults.Where((x) => x.Price >= minPrice && x.Price <= maxPrice).ToList();
            // ou
            SearchResults.Where((x) => x.Price >= minPrice && x.Price <= maxPrice);
            return SearchResults;
        }
        public bool ConfirmAccount(User user, string confirmationString)
        {
            throw new NotImplementedException();
        }
    }
}
