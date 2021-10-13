using System;

namespace AjouteTab
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Entrez la dimension du tableau: ");
            int dim = int.Parse(Console.ReadLine());
            int[] t = new int[dim];

            Console.WriteLine("-------------------------------------------");

            int i;
            for (i=0; i<dim; i++) {
                Console.Write("Entrez l'élément n°" + (i+1) + " du tableau: ");
                t[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("-------------------------------------------");

            Array.Sort(t);

            for (i=0; i<dim; i++) {
                Console.WriteLine("L'élément n°" + (i+1) + " est: " + t[i]);
            }

            Console.WriteLine("-------------------------------------------");

            int eval=1;
            while (eval != 0) {
                Console.Write("Voulez-vous ajouter un élément? (yY/nN): ");
                String r = Console.ReadLine();

                Console.WriteLine("-------------------------------------------");

                if (r == "y" || r == "Y") {
                    Console.Write("Entrez le nouvel élément du tableau: ");
                    int val = int.Parse(Console.ReadLine());
                    Array.Resize<int>(ref t, t.Length+1);
                    t[i] = val;

                    Console.WriteLine("-------------------------------------------");

                    for (i = 0; i < t.Length; i++) {
                        Console.WriteLine("L'élément n°" + (i + 1) + " est: " + t[i]);
                    }

                    Console.WriteLine("-------------------------------------------");

                    continue;
                }
                else if (r == "n" || r == "N") {
                    break;
                }
                else {
                    Console.WriteLine("Entrez soit \"yY\", soit \"nN\"!");
                    Console.WriteLine("-------------------------------------------");

                    continue;
                }
            }
        }
    }
}
