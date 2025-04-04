namespace linqEk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 10};
            var people = new[] {
                new { Name = "Andrus", Age = 30 },
                new { Name = "Alan", Age = 40 },
                new { Name = "Tom", Age = 25 },
                new { Name = "Allar",Age = 50},
                new { Name = "Toomas", Age = 20}
            };

            


            Console.WriteLine("Max: " + numbers.Max());
            Console.WriteLine("Kõige vanem inimene on " + people.Max(x => x.Age));
            Console.WriteLine("MaxBy:" + people.MaxBy(p => p.Age)?.Name);


        }
    }
    
}