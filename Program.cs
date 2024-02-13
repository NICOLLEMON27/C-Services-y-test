
using System;
using pkgServices;
namespace appConsDemo
{
    internal class Program
    {
        static T opReadNumber<T>(string prmLabel)
        {
            Console.Write(prmLabel + ":");

            return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
        }
     
        static void Main()
        {
            Console.WriteLine(clsUtilities.opAdd(opReadNumber<int>("a First Number"), opReadNumber<int>("a Second Number")));
            Console.ReadKey();
        }
    }
}
