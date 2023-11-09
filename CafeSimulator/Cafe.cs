using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulator
{
    internal class Cafe
    {
        /* TODO:
         * - Hire method for new employees
         * - SumOfSalaries that sums the total amount of salary for all employees together
         * - netWorth should update each time a customer shops, add shop sum to netWorth.
         * - When buying more products into inventory: decrease total cost from netWorth.
        */
        public int NetWorth { get; private set; }
        public int NumberOfEmployees { get; private set; }

        private List<Fika> _inventory;
    }
}
