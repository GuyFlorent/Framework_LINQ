using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            var list = Enumerable.Range(0, 500).ToList();

            var filterResult = list.Where(f => f % 2 == 0);
           
            foreach (var row in list)
            {
               

               //Console.WriteLine(row);
            }

            // le where pour filterr les resultat
            var filterResult1 = list.Where(f => f ==250);
            foreach (var row in filterResult1)
            {

              //  Console.WriteLine(row);
            }

            //select c'est pour prendre toutes les valeurs et les modifiés en meme temps

            var filterResult2 = list.Select(f =>(double) f /2);

            
            foreach (var row in filterResult2)
            {

                Console.WriteLine(row);
            }
        }
    }
}
