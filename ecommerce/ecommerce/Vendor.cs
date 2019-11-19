using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Vendor : User
    {
        public List<Product> Articles { get; set; } // catalogue du vendeur
        public List<Claim> Reclamations { get; set; }
        public List<KeyValuePair<Client, double>> Fidelite { get; set; } // CA par client

        public Vendor(string name, string mail, string password) : base(name, mail, password)
        {
            Articles = new List<Product> { };
            Reclamations = new List<Claim> { };
            Fidelite = new List<KeyValuePair<Client, double>> { };
        }
        public void AddArticle(Product article, Central centrale)
        {
            Articles.Add(article); // ajouter au catalogue
            centrale.AddArticle(article); // ajouter a la liste de recherche
        }
        public void AddStockToArticle(Product article, int stock)
        {
            article.Stock += stock;
        }
        public void DeactivateArticle(Product article)
        {
            article.Active = false;
        }
        public void GererCommentaires()
        {
            throw new NotImplementedException();
            // utiliser liste.Remove();
        }
        public void GererReclamations()
        {
            throw new NotImplementedException();
            // utiliser liste.Remove();
        }
        public void RecompenseFidelite(Client client)
        {
            throw new NotImplementedException();
        }
        public void AddToBonus(Client client, double money)
        {
            throw new NotImplementedException();
        }
    }
}
