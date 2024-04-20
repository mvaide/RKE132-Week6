string[] snacks = { "sushi", "pizza", "burger", "chicken wings", "asian takeaways" };

Random rnd = new Random();

int randomIndex = rnd.Next(0, snacks.Length);

Console.WriteLine($"tonight we're eating {snacks[randomIndex]}");
