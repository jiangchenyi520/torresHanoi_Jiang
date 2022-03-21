using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    static class Hanoi
    {
        private static int num_movimientos; 
        private static int num_discos;
        private static Pila INI, FIN, AUX;

        private static bool Solucion() {
            return FIN.Size == num_discos; 
        }

        /*TODO: Implementar métodos*/
        private static void mover_disco(Pila a, Pila b)
        {
            if (!Solucion()) {
                if (!a.isEmpty())
                {

                    if (b.isEmpty())
                    {
                        b.push(a.pop());
                        num_movimientos++;
                        Console.WriteLine(a.Nombre + "--->" + b.Nombre);
                    }
                    else if (a.Top.Valor < b.Top.Valor)
                    {
                        b.push(a.pop());
                        num_movimientos++;
                        Console.WriteLine(b.Nombre + "--->"+  b.Top.Valor + "--->" + a.Nombre);
                    }
                    else
                    {
                        a.push(b.pop());
                        num_movimientos++;
                        Console.WriteLine(b.Nombre + "--" + a.Top.Valor + "--->" + a.Nombre);
                    }

                }
                else
                {
                    if (!b.isEmpty())
                    {
                        a.push(b.pop());
                        num_movimientos++;
                    }
                }
            }
        }
            

        public static int iterativo(int n, Pila ini, Pila fin, Pila aux)
        {
            INI = ini;
            FIN = fin;
            AUX = aux;
            num_discos= n;
            num_movimientos = 0;
            if (n % 2 != 0) {
                while (!Solucion()) 
                { 
                    mover_disco(ini, fin);
                    mover_disco(ini, aux);
                    mover_disco(aux, fin);
                }            
            }
            else {

                while (!Solucion()) {
                    mover_disco(ini, aux);
                    mover_disco(ini, fin);
                    mover_disco(aux, fin);
                }
            
            }
            return num_movimientos;
        }
        
    }
}
