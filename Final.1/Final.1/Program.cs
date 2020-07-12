using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Text.Unicode;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Final._1
{
    class Program
    { static int numbermorethanone2( List<int> arr)
        {
            arr.Sort();
            for (int i = 0; i < arr.Count; i++)
            {
                if (arr[i] == arr[i + 1]) { return arr[i]; }

            }
            return -1;

        }

        
        static int numbermorethanone( List<int> a)
        {
           
            for (int i = 0; i <a.Count; i++)
            {
                
                for (int j = i+1; j < a.Count; j++)
                {
                    if (a[i]==a[j])
                    {
                        return a[i];
                        
                    }
                }
                
            }
            return -1;
           
        }
        static void Main(string[] args)
        {
            var watch = new Stopwatch();
            var watch2 = new Stopwatch();
            List<Int64> watchmethod1 = new List<Int64>();
            List<Int64> watchmethod2 = new List<Int64>();

            var numbers = "numbers.txt";
            
            string[] lines = File.ReadAllLines(numbers);
            for (int i = 0; i < 10; i++)
            {

            
            watch.Restart();
            foreach (var line in lines)
            { var a = line.Trim().Split(' ').Select(Int32.Parse).ToList();
                

                Console.WriteLine(numbermorethanone(a));
                

             }
            watch.Stop();
            watch2.Restart();
            foreach (var line in lines)
            {
                var a = line.Trim().Split(' ').Select(Int32.Parse).ToList();


               


                Console.WriteLine("------"+numbermorethanone2(a));

            }
            watch2.Stop();
                watchmethod1.Add(watch.ElapsedMilliseconds);
                watchmethod2.Add(watch2.ElapsedMilliseconds);
            }
            for (int i = 0; i < 10; i++)
            {

            
            Console.WriteLine(watchmethod1[i] + "-----------" + watchmethod2[i]);
             }

            using (StreamWriter sw = new StreamWriter("output.txt"))
            { sw.WriteLine("1.method time:");
                foreach (var num in watchmethod1)
                {
                    sw.WriteLine(num);
                }
                sw.WriteLine("1.method average time:" + watchmethod1.Average());
                sw.WriteLine("2.method time:");
                foreach (var num in watchmethod2)
                {
                    sw.WriteLine(num);
                }
                sw.WriteLine("2.method average time:" + watchmethod2.Average());
            }
            var fileToOpen = "output.txt";
            var process = new Process();
            process.StartInfo = new ProcessStartInfo()
            {
                UseShellExecute = true,
                FileName = fileToOpen
            };

            process.Start();
            process.WaitForExit();

        }
    }
}
