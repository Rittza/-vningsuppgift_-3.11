using System;
namespace Övningsuppgift_3_11
{
    class Program
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Välj en frågekategori");
            Console.WriteLine("1.Musik");
            Console.WriteLine("2.Geografi");
            Console.WriteLine("3.Historia");

            string kategori = Console.ReadLine();
            string rättsvar = "";

            switch (kategori)
            {
                case "1":
                    Console.WriteLine("Från vilket land kom ABBa";
                    rättsvar = "Sverige";
                    break;  
                    case "2":
                    Console.WriteLine("Vad heter Thailands huvudstad?";
                    rättsvar = "bankcock";
                    break;

                case "3":
                    Console.WriteLine("När fick kvinnor rösträtt i sverige?");
                    rättsvar = "1919";
                    break;

                default:
                    break;

                    string svar = Console.ReadLine().ToLower();
                    if (svar == rättsvar)
                    {
                        Console.WriteLine("Du svarade rätt");

                        else
                        {
                            Console.WriteLine("Du svarade fel");

                        }
        
       
                    }
            }
        }
    }
}