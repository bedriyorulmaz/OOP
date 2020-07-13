using System;
using System.Net.Http;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Data;

namespace final3bonus
{   
    class Program
    {
        public class Team
        {
            public int id { get; set; }
            public string abbreviation { get; set; }
            public string city { get; set; }
            public string conference { get; set; }
            public string division { get; set; }
            public string full_name { get; set; }
            public string name { get; set; }
        }

        public class Datum
        {
            public int id { get; set; }
            public string first_name { get; set; }
            public int? height_feet { get; set; }
            public int? height_inches { get; set; }
            public string last_name { get; set; }
            public string position { get; set; }
            public Team team { get; set; }
            public int? weight_pounds { get; set; }
        }

        public class Meta
        {
            public int total_pages { get; set; }
            public int current_page { get; set; }
            public int next_page { get; set; }
            public int per_page { get; set; }
            public int total_count { get; set; }
        }

        public class balldontlie
        {
            public IList<Datum> data { get; set; }
            public Meta meta { get; set; }
        }
        private static void Jsonread( )
        {


           
            
            string url = @$"https://www.balldontlie.io/api/v1/players";
            string jsonVerisi = "";
            using (WebClient response = new WebClient())
            {
                jsonVerisi = response.DownloadString(url);
            }
            balldontlie account = JsonConvert.DeserializeObject<balldontlie>(jsonVerisi);
            
            foreach (var item in account.data)
            {
               
                Console.WriteLine($"id:{ item.id}\n name:{item.first_name}\nlastname:{item.last_name}\n");
            }
            Console.WriteLine("select player ıd:");
            int n =Convert.ToInt32( Console.ReadLine());
            foreach (var player in account.data)
               {
                var dump = ObjectDumper.Dump(player);
                if (n == player.id)
                   {
                   Console.WriteLine(dump);

                   }
               }
               




        }
        static void Main(string[] args)
        {

            
            Jsonread();
        }
    }
}
