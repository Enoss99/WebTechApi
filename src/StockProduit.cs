using System.Collections.Generic;

namespace courses
{
    public class StockProduit
    {
        public List<Produit> _produits { get; }
        public List<int> _quantites { get; }

        public StockProduit(List<Produit> produits, List<int> quantites)
        {
            _produits = produits;
            _quantites = quantites;
        }
    }
}