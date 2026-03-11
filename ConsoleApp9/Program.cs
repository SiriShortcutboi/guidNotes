using ConsoleApp9;
public class Program
{
//Console.WriteLine(Guid.NewGuid()); // you will likely want to just make a new Guid
//Console.WriteLine("91dda4d6-2d0c-1cdc-18e5-cd67cd878c33"); // but if there's a guid that you really like you can use that one
    static void Main()
    {
        Engine engine = new Engine()
        {
            Id = Guid.NewGuid(),
            Name = "test",
            Description = "test decription",
        };
        engine engine = new engine("test", "test description");
        Car car = new Car("Toyota", "Tacoma", engine);
        {
        Console.WriteLine(car.Id);
        Console.WriteLine(car.Make);
        Console.WriteLine(car.Model);
        Console.WriteLine(car.EngineType.Id);
        Console.WriteLine(car.EngineType.Name);
        Console.WriteLine(car.EngineType.Description);

        }
    }
}
