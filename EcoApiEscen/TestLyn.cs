using System.Collections.Generic;
using EcoApiEscen.Models;

namespace EcoApiEscen
{
    public class TestLyn : ILyn
    {
        private List<string> Items;

        public TestLyn(List<string> items)
        {
            Items = items;
        }

        public List<string> Items1
        {
            get => Items;
            set => Items = value;
        }
    }
}