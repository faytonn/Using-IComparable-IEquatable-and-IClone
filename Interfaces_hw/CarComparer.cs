using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_hw
{
    public class CarComparer : IComparer<Car>
    {
        public int Compare(Car? carX, Car? carY)
        {
            if (carX == null || carY == null)
                throw new ArgumentException("Is null");

            return carX.Name.CompareTo(carY.Name);
        }
    }
}
