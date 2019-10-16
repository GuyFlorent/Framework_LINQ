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

                //Console.WriteLine(row);
            }

            /*Quel est le nombre d’éléments qui sont des multiples de 3 ?
Quelle est la somme des élements  supérieurs à 20 ?
Quelles est la moyenne des multiples de 3 ?
Inverser l’ordre des données de 2 manières différentes 
Quelle est la valeur minimale de la liste ?*/

            var MultiTrois = list.Where(f => f %3 == 0).Count();
            Console.WriteLine(MultiTrois);


            var Sum = list.Where(f => f >20).Sum();
           

                Console.WriteLine(Sum);

            var Moyenne = list.Where(f => f % 3 == 0).Average();
            Console.WriteLine(Moyenne);


            var OrdreASC = list.OrderBy(f => f);

            foreach (var row in OrdreASC)
            {

             //   Console.WriteLine(row);
            }

            var OrdreDESC = list.OrderByDescending(f => f);

            foreach (var row in OrdreDESC)
            {

               // Console.WriteLine(row);
            }


            var valeurMin = list.Min(f => f);

           // Console.WriteLine(valeurMin);
        }
    }
}
