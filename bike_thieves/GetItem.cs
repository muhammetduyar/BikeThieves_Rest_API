using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace bike_thieves
{
    public class GetItem
    {
        public static async Task GetItemAsync(string location, string distance, string stolenness,string per_page)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://bikeindex.org/api/v3/search?page=1&per_page="+ per_page + "&location=" + location + "&distance=" + distance + "&stolenness=" + stolenness);
                HttpResponseMessage response = await client.GetAsync(client.BaseAddress);
                if (response.IsSuccessStatusCode)
                {
                    Root itemlist = new Root();
                    itemlist = await JsonSerializer.DeserializeAsync<Root>(await response.Content.ReadAsStreamAsync());
                    foreach (Bike item in itemlist.bikes)
                    {
                        Console.WriteLine();
                        Console.WriteLine();
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine("---------------------- Bisiklet Bilgileri --------------------");
                        Console.WriteLine("--------------------------------------------------------------");
                        Console.WriteLine();
                        Console.WriteLine($"Bike Id                 : {item.id}");
                        Console.Write($"Bike Color                  :          ");
                        if (item.frame_colors != null) { foreach (var color in item.frame_colors) { Console.Write(color); } }
                        Console.WriteLine();
                        Console.WriteLine($"Model                   : {item.frame_model}");
                        Console.WriteLine($"Manufacturer Name       : {item.manufacturer_name}");
                        Console.WriteLine($"Serial                  : {item.serial}");
                        Console.WriteLine($"Status                  : {item.status}");
                        Console.WriteLine($"Stollen                 : {item.stolen}");
                        Console.Write($"Stolen Coordinates      :");
                        if (item.stolen_coordinates != null) { foreach (var coordinate in item.stolen_coordinates) { Console.Write(coordinate); } }
                        Console.WriteLine();
                        Console.WriteLine($"Stollen Location        : {item.stolen_location}");
                        Console.WriteLine($"title                   : {item.title}");
                        Console.WriteLine($"Url                     : {item.url}");
                        Console.WriteLine($"year                    : {item.year}");
                        Console.WriteLine();
                        Console.WriteLine();
                    }

                }

            }
        }
    }
}
