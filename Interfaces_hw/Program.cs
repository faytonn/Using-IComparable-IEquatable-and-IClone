using Interfaces_hw;

List<Car> cars = new List<Car> { new("Toyota Highlander", 150, 200, 100000m), new("Lamborghini Urus", 200, 450, 203244) };

Car ogCar = new("Mitsubishi L200", 150, 210, 68000);

CarComparer carComparer = new CarComparer();
cars.Sort(carComparer);


Console.WriteLine("Here are cars sorted by their name:");
foreach (Car car in cars)
{
    Console.WriteLine(car);
}


Car clonedCar = (Car)ogCar.Clone();
Console.WriteLine($"\n\nOriginal car: {ogCar}\nCloned car: {clonedCar}");


Car car1 = new("Toyota Fielder", 100, 150, 30000);
Car car2 = new("Nissan GT-R", 199, 600, 210000);

Console.WriteLine("\n\n");
Console.WriteLine(car1);
Console.WriteLine(car2);

Console.WriteLine("\nSee if its equal");
Console.WriteLine($"Equal?: {car1.Equals(car2)}");