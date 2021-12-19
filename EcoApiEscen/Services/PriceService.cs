using System.Collections.Generic;
using courses;
using EcoApiEscen.Database;

namespace EcoApiEscen.Services
{
    public class PriceService : IPrice
    {
        
        private EcoDbContext _dbContext;
        private List<Price> _prices = new List<Price>();

        public PriceService(EcoDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public string helloworld()
        {
            return "hello world";
        }

        public PriceService()
        {
        }

        public PriceService(List<Price> prices)
        {
            //_prices = prices;
            _prices.Add(new Price(1,Currency.Dollar));
        }

        public List<Price> GetAllPrice()
        {
            return _prices;
        }

        public void addPrice(Price price)
        {
            _prices.Add(price);
        }

        public void updatePrice(Price price,int index)
        {

            for (int i = 0; i < _prices.Count; i++)
            {
                if (_prices[i].Quantite==index  )
                {
                    _prices[i] = price;
                }
            }


        }

        public void deletePrice(int id)
        {
            _prices.RemoveAt(id);
        }

        public Price getOnePrice(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}