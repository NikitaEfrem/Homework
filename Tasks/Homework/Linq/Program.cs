namespace Linq
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

   

    public class Character
    {
        public string Clazz { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public int Health { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var avgLevelByClass =
                from character in CharacterData.Characters
                group character by character.Clazz into g
                select new { Class = g.Key, AvgLevel = g.Average(c => c.Level) };

            Console.WriteLine("Average level of characters for each class:");
            foreach (var avg in avgLevelByClass)
            {
                Console.WriteLine($"Class: {avg.Class}, Average level: {avg.AvgLevel}");
            }

            var maxExperience =
                CharacterData.Characters.OrderByDescending(c => c.Experience).First();

            Console.WriteLine($"\nCharacter with the most experience: {maxExperience.Clazz} (Level {maxExperience.Level}) with {maxExperience.Experience} experience points");

            var percentageByClass =
                from character in CharacterData.Characters
                group character by character.Clazz into g
                let total = CharacterData.Characters.Count
                select new { Class = g.Key, Percentage = (100.0 * g.Count()) / total };

            Console.WriteLine("\nPercentage of characters of each class in the total number of characters:");
            foreach (var percentage in percentageByClass)
            {
                Console.WriteLine($"Class: {percentage.Class}, Percentage: {percentage.Percentage}%");
            }

            var totalHealthByLevel =
                from character in CharacterData.Characters
                group character by character.Level into g
                select new { Level = g.Key, TotalHealth = g.Sum(c => c.Health) };

            Console.WriteLine("\nTotal health of characters for each level:");
            foreach (var totalHealth in totalHealthByLevel)
            {
                Console.WriteLine($"Level {totalHealth.Level}: {totalHealth.TotalHealth} health points");
            }

            var avgHealthByClass =
                from character in CharacterData.Characters
                group character by character.Clazz into g
                select new { Class = g.Key, AvgHealth = g.Average(c => c.Health) };

            var maxAvgHealthClass = avgHealthByClass.OrderByDescending(g => g.AvgHealth).First().Class;

            Console.WriteLine($"\nClass with the highest average health");
            }
    }
}
