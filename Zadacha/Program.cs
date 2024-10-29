using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Zadacha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Thread threadA = new Thread(() =>
            {
                Console.WriteLine("Nishka A e startirana...");
                Thread.Sleep(1000);
                Console.WriteLine("Nishka A prikluchi...");
            });

            Thread threadZ = new Thread(() =>
            {
                Console.WriteLine("Nishka Z e startirana...");
                Thread.Sleep(1500);
                Console.WriteLine("Nishka Z prikluchi...");
            });

            threadA.Start();
            threadZ.Start();

            Thread dashternaThread = new Thread(() =>
            {
                Console.WriteLine("Dashternata nishka e startirana...");
                Thread.Sleep(2000);
                Console.WriteLine("Dashternata nishka prikluchi...");
            });
            dashternaThread.Start();
            threadA.Join();
            threadZ.Join();
            dashternaThread.Join();

            Console.WriteLine("Vsichki nishki prikluchiha...");
        }
    }
}
