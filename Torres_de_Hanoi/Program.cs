using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dime el númerod de discos:");

            int n = Convert.ToInt32(Console.ReadLine());
            Pila INI = new Pila(n,"INI");
            Pila AUX = new Pila("AUX");
            Pila FIN = new Pila("FIN"); 
            
            int m = Hanoi.iterativo(n, INI, FIN, AUX);
            Console.WriteLine("Nº movimientos:" + m);
            Console.ReadKey(); 
           
        }
    }
}
