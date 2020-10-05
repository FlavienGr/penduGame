using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;

namespace pendu
{
    partial class Program
    {
        static void Main(string[] args)
        {
            
            int numeroEssai = 1;
            int j=0;
            bool trouve = false;
            string motCherche = leMot();
            Console.WriteLine(motCherche);      // pour tester
            char letter;
            
            char[] t = new char[motCherche.Length];
            int [] index;


            for (int i = 0; i < t.Length; i++)
            {
                t[i] = '*';
            }

            while (trouve == false && numeroEssai <= motCherche.Length + 4)
            {
                Console.WriteLine("Lettre svp");
                letter = Convert.ToChar(Console.ReadLine());
                
                if (estPresentLettre(motCherche, letter))
                {
                    index = rangsLettre(motCherche, letter);
                    for (int i=0; i< index.Length; i++)
                    {
                        t[index[i]] = letter;
                        j++;
                    }
                    
                }

                if (j == motCherche.Length)
                {
                    trouve = true;
                }
                Console.WriteLine($"Essaie numéro {numeroEssai} : {String.Join("", t)}");
                Console.WriteLine("         ");
                numeroEssai++;
            }
            if (trouve == true)
            {
                Console.WriteLine("Bravo");
            }
            else
            {
                Console.WriteLine("Perdu");
            }
                Console.ReadKey();

        }
    }
}
