using System.Linq;
using System.Collections.Generic;
namespace LINQ  
{
    public class Program
    {
        static void Main(string[] args)
        {
           var videoGames = new List<string> { "MineCraft", "GTA 5", "BioShock", "Call of Duty", "Portal", "Mass Effect", "Half-Life", "Zelda", "Super Mario", "God of War" };
            var orderOfGames = videoGames.OrderBy(x => x.Length);
            foreach(var game in orderOfGames)
            {
                Console.WriteLine(game);
            }
        }
    }
}
