using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bike_thieves
{
    public class Bike
    {
        public int? date_stolen { get; set; }
        public string description { get; set; }
        public List<string> frame_colors { get; set; }
        public string frame_model { get; set; }
        public int id { get; set; }
        public bool is_stock_img { get; set; }
        public string large_img { get; set; }
        public object location_found { get; set; }
        public string manufacturer_name { get; set; }
        public object external_id { get; set; }
        public object registry_name { get; set; }
        public object registry_url { get; set; }
        public string serial { get; set; }
        public string status { get; set; }
        public bool stolen { get; set; }
        public List<double> stolen_coordinates { get; set; }
        public string stolen_location { get; set; }
        public string thumb { get; set; }
        public string title { get; set; }
        public string url { get; set; }
        public int? year { get; set; }

    }
}