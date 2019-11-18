using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce
{
    public class Comment
    {
        public string Text { get; set; }
        public Client Author { get; set; }

        public Comment(string text, Client auteur)
        {
            Text = text;
            Author = auteur;
        }
    }
}
