using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_hw
{
    public class Car :  IEquatable<Car>, ICloneable
    {
        public string Name { get; set; }
        public int MaxMph { get; set; }
        public int Horsepower { get; set; }
        public decimal Price { get; set; }

        public Car(string name, int maxmph, int hp, decimal price)
        {
            Name = name;
            MaxMph = maxmph;
            Horsepower = hp;
            Price = price;
        }

        public object Clone()
        {
            var car = new Car(Name,MaxMph,Horsepower,Price);
            car.Name = Name;
            car.MaxMph = MaxMph;
            car.Horsepower = Horsepower;
            car.Price = Price;

            return car;
        }


        public bool Equals(Car? other)
        {
           return Name == other.Name && MaxMph == other.MaxMph && Horsepower == other.Horsepower && Price == other.Price;
        }

        public override string ToString()
        {
            return $"Name: {Name} - MaxMph: {MaxMph} - Horse Power: {Horsepower} - Price: ${Price}";
        }
    }
}
