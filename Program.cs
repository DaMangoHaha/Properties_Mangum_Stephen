namespace Properties_Mangum_Stephen
{
    using System;

    public class Car
    {
        // Private field
        private string model;

        // Property with manual getter and setter
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        // Automatic property
        public string Make { get; set; }
    }
class Program
    {
        static void Main(string[] args)
        {
            // First car!!1!
            Car car1 = new Car();
            car1.Model = "Civic";
            car1.Make = "Honda";

            Console.WriteLine("First Car:");
            Console.WriteLine($"Make: {car1.Make}");
            Console.WriteLine($"Model: {car1.Model}");

            Console.WriteLine(); // Only here to space things out

            // Second car1!!1
            Car car2 = new Car();
            car2.Model = "Cybertruck";
            car2.Make = "Tesla";

            Console.WriteLine("Second Car:");
            Console.WriteLine($"Make: {car2.Make}");
            Console.WriteLine($"Model: {car2.Model}");
        }
    }
}