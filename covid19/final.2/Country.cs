using System;
using System.Collections.Generic;
using System.Net.Http.Headers;
using System.Text;
using CsvHelper.Configuration ;
using TinyCsvParser.Mapping;
using TinyCsvParser;
using System.IO;
using System.Linq;


using CsvHelper;

using System.Globalization;
using Orc.Sort.TemplateSort;
using System.Linq.Expressions;

namespace final._2
{
    
    public class Countrycovid 
    {

       public  List<CsvMappingResult<Country>> a = new List<CsvMappingResult<Country>>();
        public  void reader() {
            CsvParserOptions csvParserOptions = new CsvParserOptions(false, ',');
            CountryMap csvMapper = new CountryMap();
            CsvParser<Country> csvParser = new CsvParser<Country>(csvParserOptions, csvMapper);

            var result = csvParser
                .ReadFromFile(@"\Users\bedri\Desktop\final.2\final.2\covid19.csv", Encoding.ASCII)
                .ToList();
            a = result;
        }

        public void countryinformation(string country)
        {
            foreach (var r in a)
            {
                
                if (r.Result.country == country)
                {
                    
                    Console.WriteLine($"Country:{r.Result.country}\n" +
                        $"Confirmed:{r.Result.Confirmed}\n" +
                        $"Deaths:{r.Result.Deaths}\n" +
                        $"Recovered:{r.Result.Recovered}\n" +
                        $"Active:{r.Result.Active}\n" +
                        $"New cases:{r.Result.Newcases}\n" +
                        $"New deaths:{r.Result.NewDeaths}\n" +
                        $"New recovered:{r.Result.Newrecovered}\n" +
                        $"Deaths / 100 cases:{r.Result.Deathcasespercent}\n" +
                        $"Recovered / 100 cases:{r.Result.Recoveredcasespercent}\n" +
                        $"Deaths / 100 Recovered:{r.Result.DeathsRecoveredpercent}\n" +
                        $"Confirmed last week:{r.Result.Confirmedlastweek}\n" +
                        $"1weekchange:{r.Result.oneweekchange}\n" +
                        $"1week%increase:{r.Result.oneweekincreasepercent}\n" +
                        $"WHORegion:{r.Result.WHOregion}\n");
                }
            }
           
        }

        public void firstncolumnsort()
        {
            List<CsvMappingResult<Country>> b = new List<CsvMappingResult<Country>>();
            for (int i = 0; i < a.Count; i++)
            {
                b.Add(a[i]);

            }

            Console.WriteLine("1-Country/Region\n2-Confirmed\n3-Deaths\n4-Recovered\n5-Active\n6-New cases\n7-New deaths\n8-New recovered\n9-Deaths / 100 Cases\n10-Recovered / 100 Cases\n11-Deaths / 100 Recovered\n12-Confirmed last week\n13-1 week change\n14-1 week % increase\n");
            Console.WriteLine("=====>"); int c = Convert.ToInt32(Console.ReadLine());
            Console.Write("first n column==> enter n:");
            int n= Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:
                    
                    foreach (var r in a)
                    {
                        
                        Console.WriteLine(r.Result);
                    }

                    break;
                case 2:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Confirmed) < Convert.ToInt32(a[i + 1].Result.Confirmed))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int k = 0;
                    foreach (var r in a)
                    {
                        if (k<=n)
                        {

                        
                        Console.WriteLine($"{k}-{ r.Result.country}-{r.Result.Confirmed}");
                        }
                        k++;
                    }

                    break;
                case 3:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Deaths) < Convert.ToInt32(a[i + 1].Result.Deaths))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int e = 0;
                    foreach (var r in a)
                    {
                        if (e<=n)
                        {

                        
                        Console.WriteLine($"{e}-{ r.Result.country}-{r.Result.Deaths}");
                        }
                        e++;
                    }
                    break;
                case 4:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Recovered) < Convert.ToInt32(a[i + 1].Result.Recovered))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int f = 0;
                    foreach (var r in a)
                    {
                        if (f<n)
                        {

                        
                        Console.WriteLine($"{f}-{ r.Result.country}-{r.Result.Recovered}");
                        }
                        f++;
                    }
                    break;
                case 5:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Active) < Convert.ToInt32(a[i + 1].Result.Active))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int q = 0;
                    foreach (var r in a)
                    {
                        if (q<=n)
                        {

                        
                        Console.WriteLine($"{q}-{ r.Result.country}-{r.Result.Active}");
                        }
                        q++;
                    }
                    break;
                case 6:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Newcases) < Convert.ToInt32(a[i + 1].Result.Newcases))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int w = 0;
                    foreach (var r in a)
                    {
                        if (w<n)
                        {

                        
                        Console.WriteLine($"{w}-{ r.Result.country}-{r.Result.Newcases}");
                        }
                        w++;
                    }
                    break;
                case 7:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.NewDeaths) < Convert.ToInt32(a[i + 1].Result.NewDeaths))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int t = 0;
                    foreach (var r in a)
                    {
                        if (t<=n)
                        {

                       
                        Console.WriteLine($"{t}-{ r.Result.country}-{r.Result.NewDeaths}");
                        }
                        t++;
                    }
                    break;
                case 8:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Newrecovered) < Convert.ToInt32(a[i + 1].Result.Newrecovered))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int z = 0;
                    foreach (var r in a)
                    {
                        if (z<=n)
                        {

                        
                        Console.WriteLine($"{z}-{ r.Result.country}-{r.Result.Newrecovered}");
                        }
                        z++;
                    }
                    break;
                case 9:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.Deathcasespercent) < Convert.ToDouble(a[i + 1].Result.Deathcasespercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int u = 0;
                    foreach (var r in a)
                    {
                        if (u<=n)
                        {

                        
                        Console.WriteLine($"{u}-{ r.Result.country}-{r.Result.Deathcasespercent}");
                        }
                        u++;
                    }

                    break;
                case 10:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.Recoveredcasespercent) < Convert.ToDouble(a[i + 1].Result.Recoveredcasespercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int o = 0;
                    foreach (var r in a)
                    {
                        if (o<=n)
                        {

                        
                        Console.WriteLine($"{o}-{ r.Result.country}-{r.Result.Recoveredcasespercent}");
                        }
                        o++;
                    }
                    break;
                case 11:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.DeathsRecoveredpercent) < Convert.ToDouble(a[i + 1].Result.DeathsRecoveredpercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int ı = 0;
                    foreach (var r in a)
                    {
                        if (ı<=n)
                        {

                        
                        Console.WriteLine($"{ı}-{ r.Result.country}-{r.Result.DeathsRecoveredpercent}");
                        }
                        ı++;
                    }
                    break;

                case 12:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Confirmedlastweek) < Convert.ToInt32(a[i + 1].Result.Confirmedlastweek))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int p = 0;
                    foreach (var r in a)
                    {
                        if (p<n)
                        {

                        
                        Console.WriteLine($"{p}-{ r.Result.country}-{r.Result.Confirmedlastweek}");
                        }
                        p++;
                    }
                    break;

                case 13:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.oneweekchange) < Convert.ToInt32(a[i + 1].Result.oneweekchange))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int x = 0;
                    foreach (var r in a)
                    {
                        if (x<=n)
                        {

                        
                        Console.WriteLine($"{x}-{ r.Result.country}-{r.Result.oneweekchange}");
                        }
                        x++;
                    }
                    break;
                case 14:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.oneweekincreasepercent) < Convert.ToDouble(a[i + 1].Result.oneweekincreasepercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int v = 0;
                    foreach (var r in a)
                    {
                        if (v<=n)
                        {

                        
                        Console.WriteLine($"{v}-{ r.Result.country}-{r.Result.oneweekincreasepercent}");
                        }
                        v++;
                    }
                    break;

                default:
                    break;
            }

        }
        public void sortcolumn() 
        {
            List<CsvMappingResult<Country>> b = new List<CsvMappingResult<Country>>();
            for (int i = 0; i < a.Count; i++)
             {
                 b.Add(a[i]);

             }
            
            Console.WriteLine("1-Country/Region\n2-Confirmed\n3-Deaths\n4-Recovered\n5-Active\n6-New cases\n7-New deaths\n8-New recovered\n9-Deaths / 100 Cases\n10-Recovered / 100 Cases\n11-Deaths / 100 Recovered\n12-Confirmed last week\n13-1 week change\n14-1 week % increase\n");
            int c = Convert.ToInt32(Console.ReadLine());
            switch (c)
            {
                case 1:

                    foreach (var r in a)
                    {

                        Console.WriteLine(r.Result);
                    }

                    break;
                case 2:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Confirmed) < Convert.ToInt32(a[i + 1].Result.Confirmed))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int k = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{k}-{ r.Result.country}-{r.Result.Confirmed}");

                        k++;
                    }

                    break;
                case 3:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Deaths) < Convert.ToInt32(a[i + 1].Result.Deaths))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int e = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{e}-{ r.Result.country}-{r.Result.Deaths}");

                        e++;
                    }
                    break;
                case 4:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Recovered) < Convert.ToInt32(a[i + 1].Result.Recovered))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int f = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{f}-{ r.Result.country}-{r.Result.Recovered}");

                        f++;
                    }
                    break;
                case 5:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Active) < Convert.ToInt32(a[i + 1].Result.Active))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int q = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{q}-{ r.Result.country}-{r.Result.Active}");

                        q++;
                    }
                    break;
                case 6:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Newcases) < Convert.ToInt32(a[i + 1].Result.Newcases))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int w = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{w}-{ r.Result.country}-{r.Result.Newcases}");

                        w++;
                    }
                    break;
                case 7:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.NewDeaths) < Convert.ToInt32(a[i + 1].Result.NewDeaths))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int t = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{t}-{ r.Result.country}-{r.Result.NewDeaths}");

                        t++;
                    }
                    break;
                case 8:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Newrecovered) < Convert.ToInt32(a[i + 1].Result.Newrecovered))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int z = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{z}-{ r.Result.country}-{r.Result.Newrecovered}");

                        z++;
                    }
                    break;
                case 9:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.Deathcasespercent) < Convert.ToDouble(a[i + 1].Result.Deathcasespercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int u = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{u}-{ r.Result.country}-{r.Result.Deathcasespercent}");

                        u++;
                    }

                    break;
                case 10:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.Recoveredcasespercent) < Convert.ToDouble(a[i + 1].Result.Recoveredcasespercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int o = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{o}-{ r.Result.country}-{r.Result.Recoveredcasespercent}");

                        o++;
                    }
                    break;
                case 11:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.DeathsRecoveredpercent) < Convert.ToDouble(a[i + 1].Result.DeathsRecoveredpercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int ı = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{ı}-{ r.Result.country}-{r.Result.DeathsRecoveredpercent}");

                        ı++;
                    }
                    break;

                case 12:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.Confirmedlastweek) < Convert.ToInt32(a[i + 1].Result.Confirmedlastweek))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int p = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{p}-{ r.Result.country}-{r.Result.Confirmedlastweek}");

                        p++;
                    }
                    break;

                case 13:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToInt32(a[i].Result.oneweekchange) < Convert.ToInt32(a[i + 1].Result.oneweekchange))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int x = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{x}-{ r.Result.country}-{r.Result.oneweekchange}");

                        x++;
                    }
                    break;
                case 14:
                    for (int j = 0; j < a.Count - 1; j++)
                    {

                        for (int i = 1; i < a.Count - 1; i++)
                        {
                            if (Convert.ToDouble(a[i].Result.oneweekincreasepercent) < Convert.ToDouble(a[i + 1].Result.oneweekincreasepercent))
                            {

                                b[i] = a[i + 1];
                                a[i + 1] = a[i];
                                a[i] = b[i];


                            }

                        }
                    }
                    int v = 0;
                    foreach (var r in a)
                    {
                        Console.WriteLine($"{v}-{ r.Result.country}-{r.Result.oneweekincreasepercent}");

                        v++;
                    }
                    break;

                default:
                    break;
            }
        }

        public void filtering() 
        {
            Console.WriteLine("1-Confirmed\n2-Deaths\n3-Recovered\n4-Active\n5-New cases\n6-New deaths\n7-New recovered\n8-Deaths / 100 Cases\n9-Recovered / 100 Cases\n10-Deaths / 100 Recovered\n11-Confirmed last week\n12-1 week change\n13-1 week % increase\n");
            int c = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the filtering limit");
            int d = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case 1:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Confirmed) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Confirmed}"); } 
                    }
                    break;
                case 2:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Deaths) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Deaths}"); }
                    }
                    break;
                case 3:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Recovered) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Recovered}"); }
                    }
                    break;
                case 4:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Active) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Active}"); }
                    }
                    break;
                case 5:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Newcases) > d) { Console.WriteLine($"{r.Result.Newcases}---{r.Result.Newcases}"); }
                    }
                    break;
                case 6:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.NewDeaths) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.NewDeaths}"); }
                    }
                    break;
                case 7:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Newrecovered) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Newrecovered}"); }
                    }
                    break;
                case 8:
                    foreach (var r in a)
                    {
                        if (Convert.ToDouble(r.Result.Deathcasespercent) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Deathcasespercent}"); }
                    }
                    break;
                case 9:
                    foreach (var r in a)
                    {
                        if (Convert.ToDouble(r.Result.Recoveredcasespercent) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Recoveredcasespercent}"); }
                    }
                    break;
                case 10:
                    foreach (var r in a)
                    {
                        if (Convert.ToDouble(r.Result.DeathsRecoveredpercent) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.DeathsRecoveredpercent}"); }
                    }
                    break;
                case 11:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.Confirmedlastweek) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.Confirmedlastweek}"); }
                    }
                    break;
                case 12:
                    foreach (var r in a)
                    {
                        if (Convert.ToInt32(r.Result.oneweekchange) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.oneweekchange}"); }
                    }
                    break;
                 case 13:
                    foreach (var r in a)
                    {
                        if (Convert.ToDouble(r.Result.oneweekincreasepercent) > d) { Console.WriteLine($"{r.Result.country}---{r.Result.oneweekincreasepercent}"); }
                    }
                    break;
                
                default:
                    break;
            }

        }
    }
    public class Country
    { public string country { get; set; }
        public string Confirmed { get; set; }
        public string Deaths { get; set; }
        public string Recovered { get; set; }
        public string Active { get; set; }
        public string Newcases { get; set; }
        public string NewDeaths { get; set; }
        public string Newrecovered { get; set; }
        public string Deathcasespercent { get; set; }
        public string Recoveredcasespercent { get; set; }
        public string DeathsRecoveredpercent { get; set; }
        public string Confirmedlastweek { get; set; }
        public string oneweekchange { get; set; }
        public string oneweekincreasepercent { get; set; }
        public string WHOregion { get; set; }

    }

    public class CountryMap : CsvMapping<Country>
    {
        public CountryMap() : base()
        {
            MapProperty(0, x => x.country);
            MapProperty(1, x => x.Confirmed);
            MapProperty(2, x => x.Deaths);
            MapProperty(3, x => x.Recovered);
            MapProperty(4, x => x.Active);
            MapProperty(5, x => x.Newcases);
            MapProperty(6, x => x.NewDeaths);
            MapProperty(7, x => x.Newrecovered);
            MapProperty(8, x => x.Deathcasespercent);
            MapProperty(9, x => x.Recoveredcasespercent);
            MapProperty(10, x => x.DeathsRecoveredpercent);
            MapProperty(11, x => x.Confirmedlastweek);
            MapProperty(12, x => x.oneweekchange);
            MapProperty(13, x => x.oneweekincreasepercent);
            MapProperty(14, x => x.WHOregion);


        }

    }

    
}
