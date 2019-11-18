using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Vendor : User
    {
        public List<Product> Articles { get; set; } // catalogue du vendeur
        public List<Claim> Reclamations { get; set; }
        public List<KeyValuePair<Client, double>> Fidelite { get; set; } // CA par client

        public Vendor(string nom, string mail, string password) : base(nom, mail, password)
        {
            Articles = new List<Product> { };
            Reclamations = new List<Claim> { };
            Fidelite = new List<KeyValuePair<Client, double>> { };
        }
        public void AddArticle(Product article, Central centrale)
        {
            throw new NotImplementedException();
        }
        public void AddStockToArticle(Product article, int stock, Central centrale)
        {
            throw new NotImplementedException();
        }
        public void DeactivateArticle(Product article, Central centrale)
        {
            throw new NotImplementedException();
        }
        public void GererCommentaires()
        {
            throw new NotImplementedException();
        }
        public void GererReclamations()
        {
            throw new NotImplementedException();
        }
        public void RecompenseFidelite(Client client)
        {
            throw new NotImplementedException();
        }
        public void AddToBonus(Client client, double money)
        {

        }
    }
}
