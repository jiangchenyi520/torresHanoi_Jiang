using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Torres_de_Hanoi
{
    class Pila
    {
        public int Size 
        { get {
                return Elementos.Count; 
            }
        }
        // como son propiedades de consulta no hace falta set, por lo que se ha quitado. 

        //public int Top { get; set; }

        public string Nombre { get; set; }

        public Disco Top
        {
            get
            {
                if (isEmpty() == false)
                {
                    return Elementos[Elementos.Count-1];
                }
                else
                {
                    return null;
                }
            }
        }
        public List<Disco> Elementos { get; set; }

        /* TODO: Elegir tipo de Top
        public int Top { get; set; }
        public String Top { get; set; }        
        */
        /* TODO: Elegir tipo de Elementos
        public Disco[] Elementos { get; set; }
        public List<Disco> Elementos { get; set; }
        */

        /* TODO: Implementar métodos */
    
        //Constructor
        public Pila(string n) 
        {
            Elementos = new List<Disco>();
            Nombre = n;
        }


        //constructor de la clase
        public Pila(int n, string nombre) {
            Elementos = new List<Disco>();
            Nombre = nombre; 
            for (int i = n; i > 0; i--) {
                Disco d = new Disco();
                d.Valor = i;
                push(d);
            }
        }

        //Permite colocar un disco en la pila de discos 
        public void push(Disco d)
        {
            Elementos.Add(d); 
        }

        //Permite extraer el disco de la parte superior de la pila. 
        public Disco pop()
        {
            Disco d = Top; 
            Elementos.RemoveAt(Size-1);
            return d;
        }                

        //informará si la pila está vacía o no vacía. 
        public bool isEmpty()
        {
            if (Size == 0) 
            {
                return true;
            }
            else
            {
                return false; 
            }
        }

    }
}
