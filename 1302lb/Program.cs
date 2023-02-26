using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1302lb
{
    class Program
    {
        static void Main(string[] args)
        {

            //Animal[] zoo = new Animal[2];
            //zoo[0] = new Tiger();
            //zoo[1] = new Crocodile();
            //foreach(var i in zoo){
            //    i.Print();
            //    Console.WriteLine();
            //}



            Figure[] figures = new Figure[4];
            figures[0] = new Circle(2);
            figures[1] = new Right_tirangle(2, 2);
            figures[2] = new Trapez(2, 4, 2);
            figures[3] = new Rectangle(2, 2);
            foreach (var f in figures)
            {
                Console.WriteLine(f.Area());
            }

            Console.ReadKey();
        }
    }
}
