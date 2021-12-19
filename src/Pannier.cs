namespace courses
{
    public class Pannier
    {
        private Produit _produit;
        private int quantite;

        public int Quantite
        {
            set { quantite = value; }
            get { return quantite; }
        }

        public Produit Produit
        {
            set { _produit = value; }
            get { return _produit; }
        }

        public Pannier()
        {

        }

        public Pannier(Produit produit, int quantite)
        {
            _produit = produit;
            this.quantite = quantite;
        }
    }
}
