using System.ComponentModel.DataAnnotations;

namespace LINQ

{
    internal class Program

    {
        static void main(string[] args)
        {


            List<string> VideoGameNames = new List<string>
        {"Madden",  "2k23", "Warzone" , "Modren Warefare" , "Midnight Club" };




            // Method Syntax
            Console.WriteLine("------Method Syntax------");
            List<string> Games = new List<string>
            {
                "call of duty warzone",//4
                "rocket leage",//3
                "elden ring",//2
                "ark" //1
            };
            //--------------------------------\

            var Order = Games.OrderBy(x => x.Length);// took me so long to see i needed .length
            foreach (string Game in Order)
            {
                Console.WriteLine(Game);
            }
            Console.WriteLine("-------------------------");
            //Query Syntax
            Console.WriteLine("------Query Syntax-------");
            List<string> Gamestwo = new List<string>
            {
                "call of duty warzone",//4
                "rocket leage",//3
                "elden ring",//2
                "ark" //1
            };
            var Length = from GameX in Gamestwo
                         orderby GameX.Length ascending
                         select GameX;
            foreach (string GameX in Length)
            {
                Console.WriteLine(GameX);
            }
            Console.WriteLine("---------------------------");
        }

    }
}




