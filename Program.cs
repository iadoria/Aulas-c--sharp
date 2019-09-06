using System;

namespace ConsoleApp29
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3;
            Console.WriteLine("Informe 1° Numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe 2° Numero");
            n2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe 3° Numero");
            n3 = int.Parse(Console.ReadLine());
            if ( n1 > n2 && n1 > n3 )
            {
                Console.WriteLine(" O maior é:" + n1);
            }
            else if  ( n2 > n1 && n2 > n3){
                Console.WriteLine(" Maior é:" + n2);
            }
            else if ( n3 > n1 && n3 > n1)
            {
                Console.WriteLine(" O maior é:" + n3);
            }

            
            }
        }
    }
}
