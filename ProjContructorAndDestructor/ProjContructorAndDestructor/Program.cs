using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProjContructorAndDestructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Ball ball = new Ball("Ball_1"); //<--object ball

            Console.WriteLine("...");
            Thread.Sleep(2000);


            ball = null; //<--usuwam referencje

            GC.Collect(); /* <-- wymuszam uruchomienie Garbage Collector'a 
                           *     który niszczy wszystkie obiekty 
                           *     bez referencji
                           */

            Console.ReadKey();

        }   
    }

    class Ball
    {
        public Ball(string name)
        {
            Console.WriteLine($"[1] The object {name} is created.");
        }


        ~Ball()
        {
            Console.WriteLine($"[2] The object is destroyed.");
        }
    }

}
