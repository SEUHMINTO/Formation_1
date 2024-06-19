using System;
using System.ComponentModel.DataAnnotations;
using System.Runtime.Intrinsics;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
       
      
        static void Main(string[] args)
        {
            int V2 = 0;
            int V1 = 0;
            int N = 0;
            try
            {
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("----------------Multiplication---------------------- ");

                Console.WriteLine("Veuillez entrer le chiffre à multiplier par 10");
                string V2_str = Console.ReadLine();
                V2 = int.Parse(V2_str);
                
                for (V1 = 0; V1 < 11; V1++)
                {
                    Console.WriteLine("Le résultat est!" + (V1 * V2));
                }
            }
            catch
            {
                Console.WriteLine("Erreur de saisie, veuillez entrer un chiffre");
            }
        
            try
            {
                Console.WriteLine("-------------------------------------------: ");
                Console.WriteLine("----------------Factorisation-------------- ");
                Console.WriteLine("Veuillez entrer le chiffre à factoriser: ");
                V2 = int.Parse(Console.ReadLine());

                V1 = V2; // Assign n to num

                while (V2 > 0)
                {
                    for (int i = V1 - 1; i > 0; i--)
                    {
                        V1 *= i;
                    }
                    Console.WriteLine("Le Factoriel de {0}! = {1}\n", V2, V1);
                    V2--;
                }
            }
            catch
            {
            }
        }
    }
}