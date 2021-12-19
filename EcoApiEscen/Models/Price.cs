namespace courses
{
    public class Price
    {
        public float Quantite { get; }

        public Currency Devise { get; }

        public Price()
        {
        }

        public Price(float quantite, Currency devise)
        {
            Quantite = quantite;
            Devise = devise;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}