using System;
using System.Collections.Generic;//contiene interfaces y clases que definen colecciones genericas,permiten estar tipadas
using System.Linq;//conjunto de extensiones integradas en c#,permite trabajar mas comodo
using System.Text;//contiene clases que representan codificaciones de caracteres
using System.Threading;//proporciona poder utilizar hilos (subprocesos)

//dado un numero determinar si es primo y encontrar su factorial
namespace Ejercicio5Hilos
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.Write("ingrese  un numero positivo: ");
            num = Int32.Parse(Console.ReadLine());
            Thread x = new Thread(proceso1);
            Thread y = new Thread(proceso2);
            x.Start(num);
            y.Start(num);
        }
        static void proceso1(object n)
        {
            int x = 1;
            int num = Convert.ToInt32(n);
            while (num > 0)
            {
                x = x * num;
                num = num - 1;
            }
            Console.WriteLine("El factorial es: " + x);
        }
        static void proceso2(object n)
        {
            int x = 0;
            int num = Convert.ToInt32(n);
            for(int i=1;i<=num;i++)
            {
                if (num % i == 0)
                {
                    x++;
                }
            }
            if (x == 2)
            {
                Console.WriteLine("El numero es primo");
            }
            else
            {
                Console.WriteLine("El numero NO es primo");
            }
        }
    }
}
