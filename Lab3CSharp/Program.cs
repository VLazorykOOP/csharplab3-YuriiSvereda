namespace Lab3CSharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lab 3 ");

            /* try
             {
                 Rectangle rect = new Rectangle(5, 5, 10);
                 Console.WriteLine("Rectangle sides:");
                 rect.PrintSides();
                 Console.WriteLine("Perimeter: " + rect.CalculatePerimetr());
                 Console.WriteLine("Area: " + rect.CalculateArea());
                 Console.WriteLine("Is square? " + rect.IsSquare());
                 Console.WriteLine("Color: " + rect.Color);
             }
             catch (Exception ex)
             {
                 Console.WriteLine("An error occurred: " + ex.Message);
             }*/



            // Створюємо масив базового класу
            Country[] countries = new Country[3];

            // Заповнюємо масив різними об'єктами
            countries[0] = new Republic
            {
                Name = "Ukraine",
                Population = 41000000,
                Area = 603500,
                President = "Volodymyr Zelenskyi"
            };

            countries[1] = new Monarchy
            {
                Name = "United Kingdom",
                Population = 66400000,
                Area = 242500,
                Monarch = "Queen Elizabeth II"
            };

            countries[2] = new Kingdom
            {
                Name = "Spain",
                Population = 47300000,
                Area = 505990,
                Monarch = "King Felipe VI",
                NobilityCount = 10000
            };

            // Виводимо дані про об'єкти
            foreach (var country in countries)
            {
                country.Show();
                Console.WriteLine();
            }
        }
    }
}
