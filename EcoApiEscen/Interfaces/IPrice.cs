using System.Collections.Generic;

namespace courses
{
    public interface IPrice
    {
        string helloworld();
        List<Price> GetAllPrice();

        void addPrice(Price price);

        void updatePrice(Price price, int index);

        void deletePrice(int id);

        Price getOnePrice(int id);
    }
}