using System;

namespace Task1810
{
    internal class Program
    {
        private static void Main()
        {
            var rawItems = new[]
            {
                new Item {Name = "1"},
                new Item {Name = "2"},
                new Item {Name = "3"}
            };
            var items = new Items(rawItems);
            
            foreach (Item item in items)
            {
                Console.WriteLine(item);
            }

            for (var i = 0; i < items.Length; i++)
            {
                items[i] = new Item {Name = $"{-i}"};
                Console.WriteLine(items[i]);
            }
        }
    }
}