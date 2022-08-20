using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace bike_thieves
{
    class Program
    {
        
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine("Which of the following cities would you like to see the stolen bike status of ?");
                Console.WriteLine("[1] Amsterdam, The Netherlands");
                Console.WriteLine("[2] Berlin, Germany");
                Console.WriteLine("[3] Copenhagen, Denmark");
                Console.WriteLine("[4] Brussels, Belgium");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        InformationEntry("Amsterdam");
                        break;
                    case 2:
                        InformationEntry("Berlin, Germany");
                        break;
                    case 3:
                        InformationEntry("Copenhagen, Denmark");

                        break;
                    case 4:
                        InformationEntry("Brussels, Belgium");

                        break;
                    default:
                        Console.WriteLine("Incorrect login try again!!");
                        break;
                }
            }

        }

        public static void InformationEntry(string location)
        {
            Console.Write("Distance : ");
            string distance = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("[1] All");
            Console.WriteLine("[2] non");
            Console.WriteLine("[3] stolen");
            Console.WriteLine("[4] proximity");
            Console.Write("Stolenness : ");
            string stolenness = Console.ReadLine();
            Console.WriteLine("how many bikes are listed");
            string per_page = Console.ReadLine();
            GetItem.GetItemAsync(location, distance, stolenness, per_page).Wait();
        }

    }

}