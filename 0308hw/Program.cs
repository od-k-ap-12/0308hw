using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0308hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Device[] devices1 = new Device[2];
            Device[] devices2 = new Device[2];
            devices1[0] = new Device("model1", "manufacturer1", 1);
            devices1[1] = new Device("model2", "manufacturer2", 5);
            devices2[0] = new Device("model3", "manufacturer1", 10);
            devices2[1] = new Device("model4", "manufacturer4", 3);

            var result = devices1.Select(x=>x.Manufacturer).Except(devices2.Select(x=>x.Manufacturer));

            foreach (var s in result)
                Console.WriteLine(s);
            Console.WriteLine();


            result = devices1.Select(x => x.Manufacturer).Intersect(devices2.Select(x => x.Manufacturer));

            foreach (var s in result)
                Console.WriteLine(s);
            Console.WriteLine();


            result = devices1.Select(x => x.Manufacturer).Union(devices2.Select(x => x.Manufacturer));

            foreach (var s in result)
                Console.WriteLine(s);
            Console.WriteLine();
        }
    }
}
