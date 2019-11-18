using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    class Client : User
    {
        public Basket Panier { get; set; }

        public Client(string nom, string mail, string password) : base(nom, mail, password)
        {
            Panier = new Basket(this);
        }
        public void CommanderPanier()
        {
            foreach(KeyValuePair<Product,int> articleQte in Panier.ArticlesQte)
            {
                articleQte.Key.Vendor.AddToBonus(this, articleQte.Key.Price * articleQte.Value);
                articleQte.Key.Stock -= articleQte.Value;
            }
            // envoyer les commandes aux vendeurs
            // compter les achats pour les bons
            // vider le panier
        }
        public void Comment(Product article,string text)
        {
            article.Comments.Add(new Comment(text, this));
        }
        public void Reclamation(Product article, string text)
        {
            article.Vendor.Reclamations.Add(new Claim(text,this));
        }

    }
}
