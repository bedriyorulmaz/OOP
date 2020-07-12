using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using CsvHelper;
using TinyCsvParser;
using System.Globalization;
using System.Text;

namespace final._2
{   

    class Program
    {   
        
        static void Main(string[] args)
        {
            Countrycovid covid = new Countrycovid();
            covid.reader();

            Console.WriteLine("Choose the operations below");
            Console.WriteLine("1. Show results from a specific country \n 2.Sort the data according to any column \n 3.Filter the results(for example, > 10000 cases) \n  4.Print the top or bottom n results");
            Console.Write("=====>"); int a = Convert.ToInt32(Console.ReadLine());

            
            switch (a)
            {
                case 1:Console.WriteLine("select country:");
                    string country = Console.ReadLine();
                    covid.countryinformation(country);


                    break;
                case 2:covid.sortcolumn();
                    break;
                case 3:covid.filtering();
                    break;
                case 4:
                    covid.firstncolumnsort();
                    break;
                default:
                    break;
            }
        }
    }
    }

