using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Client : User
    {
        public Basket Panier { get; set; }

        public Client(string name, string mail, string password) : base(name, mail, password)
        {
            Panier = new Basket(this);
        }
        public void CommanderPanier()
        {
            // envoyer les commandes aux vendeurs
            // compter les achats pour les bons
            // vider le panier            
            
            foreach(KeyValuePair<Product,int> articleQte in Panier.ArticlesQte)
            {
                //articleQte.Key.Vendor.AddToBonus(this, articleQte.Key.Price * articleQte.Value);
                if (articleQte.Key.Stock>= articleQte.Value)
                {
                    articleQte.Key.Stock -= articleQte.Value;
                } 
                else
                {
                    Console.WriteLine(articleQte.Key.Name + " is out of stock, you ordered " + articleQte.Value + " and there are only "+ articleQte.Key.Stock + " left");
                }
                
            }

            Panier.ArticlesQte.Clear();

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
