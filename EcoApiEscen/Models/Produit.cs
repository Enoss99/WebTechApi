using System;

namespace courses
{
    public class Produit : IProduit
    {

        public String Nom { get; }
        public String Description { get; }

        public Price Prix { get; }

        public Produit()
        {
        }

        public Produit(string nom, string description, Price prix)
        {
            Nom = nom;
            Description = description;
            Prix = prix;
        }
    }
}