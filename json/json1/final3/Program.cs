using System;
using System.Net.Http;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace final3
{
    public class Wind10m
    {
        public string direction { get; set; }
        public int speed { get; set; }
    }

    public class Datasery
    {
        public int timepoint { get; set; }
        public int cloudcover { get; set; }
        public int seeing { get; set; }
        public int transparency { get; set; }
        public int lifted_index { get; set; }
        public int rh2m { get; set; }
        public Wind10m wind10m { get; set; }
        public int temp2m { get; set; }
        public string prec_type { get; set; }
    }

    public class weather
    {
        public string product { get; set; }
        public string init { get; set; }
        public IList<Datasery> dataseries { get; set; }
    }


    
    class Program
    {
        private static void Jsonread(string a ,string b)
        {   
            
            string url = @$"http://www.7timer.info/bin/astro.php?lon={a}&lat={b}&ac=0&unit=metric&output=json&tzshift=0";
            string jsonVerisi = "";
            using (WebClient response = new WebClient())
            {
                jsonVerisi = response.DownloadString(url);
            }
            weather account = JsonConvert.DeserializeObject<weather>(jsonVerisi);

            foreach (var datasery in account.dataseries)
            {
              
                Console.WriteLine($"Timepoint:{datasery.timepoint}\nCloudcover:{datasery.cloudcover}\nSeening:{datasery.seeing}\nTransparency:{datasery.transparency}\nlifted_index:{datasery.lifted_index}\nrh2m:{datasery.rh2m}");
                Console.WriteLine($"temp2m:{datasery.temp2m}\nprec_type:{datasery.prec_type}\nwind10m direction:{datasery.wind10m.direction}\nwind10m speed:{datasery.wind10m.speed}\n\n\n");
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("enter a latidude:");
            string a=Console.ReadLine();
            Console.WriteLine("enter a longitude:");
            string b = Console.ReadLine();
            Jsonread(a,b);
        }
    }
}
