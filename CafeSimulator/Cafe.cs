using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulator
{
    internal class Cafe
    {
        public int NetWorth { get; private set; }
        public int NumberOfEmployees { get; private set; }

        private List<Fika> _inventory;
        private int restockQuantity = 5;

        public Cafe(int capital)
        {
            _inventory = new List<Fika>();
            NetWorth = capital;
        }

        public void Restock(List<Fika> items)
        {
            // TODO:
            // For each item, add {restockQuantity} items to inventory
            // decrease networth with the cost of all items
        }
    }
}
