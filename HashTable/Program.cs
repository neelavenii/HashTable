using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Hash Table");

            MyMapNode<string, string> hash = new MyMapNode<string, string>(5);
            hash.Add("0", "To");
            hash.Add("1", "be");
            hash.Add("2", "or");
            hash.Add("3", "not");
            hash.Add("4", "To");
            hash.Add("5", "be");
            string hash5 = hash.Get("5");
            Console.WriteLine("5 th index value :" + hash5);
            //hash .Remove("2");
            string hash2 = hash.Get("2");
            Console.WriteLine("2 nd index value :" + hash2);

            Console.ReadLine();
        }
        

    }
}
