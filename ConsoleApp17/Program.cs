using ConsoleApp17.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "";
            Teftel player1 = new Teftel();
            Console.WriteLine("Введите имя");
            name = Console.ReadLine();
            player1.CharInfo(name);

            Thread.Sleep(5000);
        }

        
    }
    
}
