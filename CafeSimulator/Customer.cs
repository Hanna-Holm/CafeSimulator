using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeSimulator
{
    internal class Customer
    {
        public EnergyLevel Energy;
        private int _numberOfEnergyLevels = Enum.GetNames(typeof(EnergyLevel)).Length;

        public Customer()
        {
            int random = new Random().Next(0, _numberOfEnergyLevels);
            Energy = (EnergyLevel)random;
        }

        public enum EnergyLevel
        {
            Low,
            Medium,
            High
        }
    }
}
