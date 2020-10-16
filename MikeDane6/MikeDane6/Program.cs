using System;

namespace MikeDane6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Math.Sqrt(144));

            UsefulTools.SayHi("User");

            UsefulTools usefulToolsObject = new UsefulTools();
            usefulToolsObject.SayGoodBye("User");

            Chef chefObject = new Chef();
            chefObject.MakeChicken();
            chefObject.MakeSpecialDish();

            ItalianChef italianChefObject = new ItalianChef();
            italianChefObject.MakePasta();
            italianChefObject.MakeSpecialDish();
        }
    }
}
