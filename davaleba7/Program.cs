using System.Runtime.ConstrainedExecution;

namespace davaleba8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"../../../CarsData.txt";

            string[] lines = File.ReadAllLines(path);

            Cars[] car = new Cars[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(',');
                Console.WriteLine(lines[i]);
                car[i] = new Cars();
                car[i].brand = parts[0] + " " + parts[1];
                car[i].year = int.Parse(parts[2]);
                car[i].price = int.Parse(parts[3]);
                car[i].color = parts[4];
            }

            foreach (Cars item in car)
            {
                Console.WriteLine($"Brand: {item.brand}, Year: {item.year}, Price: {item.price}, Color: {item.color}");
            }
        }
    }
}
