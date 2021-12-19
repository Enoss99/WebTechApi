using System;
using System.Collections.Generic;

namespace micro_systeme
{
    public class Gestion
    {
        public StockProduit Stock { get; }

        private List<Pannier> _panniers;

        public List<Pannier> Panniers
        {
            set { _panniers = value; }
            get { return _panniers; }

        }


        public Gestion()
        {
        }

        public Gestion(StockProduit stock)
        {
            Stock = stock;
        }


        public void AddProductInStock(Produit produit,int quantity=1)
        {
            Stock._produits.Add(produit);
            Stock._quantites.Add(quantity);
        }

        public void UpdateProduct(string name,int quantity=1)
        {
            
            for (int i = 0; i < Stock._produits.Count; i++)
            {
                if (Stock._produits[i].Name==name  )
                {
                    Stock._quantites[i] = quantity;
                }
            }

           
        }

        public void DeleteProduit(String name)
        {
            
            for (int i = 0; i < Stock._produits.Count; i++)
            {
                if (Stock._produits[i].Name==name  )
                {
                    Stock._produits.RemoveAt(i);
                    Stock._quantites.RemoveAt(i);
                    
                }
            }
            
        }

        public float getChiffreDAffaireStock()
        {
            float totaux = 0;

            for (int i = 0; i <Stock._produits.Count; i++)
            {
                float currentTotal = Stock._produits[i].Price.Quantity * Stock._quantites[i];
                totaux += currentTotal;
            }
            
            return totaux;
        }

        public float getChiffreDAffairePannier()
        {
            float totaux = 0;

            if (_panniers.Count>0)
            {
                foreach (Pannier p in _panniers)
                {
                    float currentTotal = p.Produit.Price.Quantity * p.Quantite;
                    totaux += currentTotal;
                }  
            }
            
            return totaux;
        }
        
        public void getAllProduit(){
            Console.WriteLine("Qte  |   Name");
            Console.WriteLine("--------------");
            
            for (int i = 0; i<Stock._produits.Count;i++) 
            {
                Console.WriteLine(Stock._quantites[i]+"    |   "+Stock._produits[i].Name);
            }
        }
        
        public void getAllProduitPannier(){
            foreach (Pannier pannier in _panniers)
            {
                Console.Write(pannier.Quantite+" - "+pannier.Produit.Name+"\n----------------\n");
            }
        }
        
        
    }
    
    
}
