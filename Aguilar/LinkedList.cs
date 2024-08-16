using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Aguilar
{
    internal class LinkedList
    {

        public Nodo inicio;

        public LinkedList()
        {
            inicio = null;
        }
        public void InsertarFinal(int item)
        {
            Nodo nuevoNodo = new Nodo { dato = item, siguiente = null };

            if (inicio == null)
            {
                inicio = nuevoNodo;
            }
            else
            {
                Nodo actual = inicio;
                while (actual.siguiente != null)
                {
                    actual = actual.siguiente;
                }
                actual.siguiente = nuevoNodo;
            }
        }

        public void Mostrar()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo actual = inicio;
            while (actual != null)
            {
                Console.Write(actual.dato + " ");
                actual = actual.siguiente;
            }
            Console.WriteLine();
        }

        public void EliminarPorPosicion(int posicion)
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            if (posicion < 0)
            {
                Console.WriteLine("La posición debe ser un número entero positivo.");
                return;
            }

            if (posicion == 1)
            {
                inicio = inicio.siguiente;
                return;
            }

            Nodo actual = inicio;
            Nodo previo = null;
            int indice = 1;

            while (actual != null && indice < posicion)
            {
                previo = actual;
                actual = actual.siguiente;
                indice++;
            }

            if (actual == null)
            {
                Console.WriteLine("Posición fuera de rango.");
                return;
            }

            previo.siguiente = actual.siguiente;
        }
        public void EncontrarNodoMedio()
        {
            if (inicio == null)
            {
                Console.WriteLine("La lista está vacía.");
                return;
            }

            Nodo lento = inicio;
            Nodo rapido = inicio;

            while (rapido != null && rapido.siguiente != null)
            {
                lento = lento.siguiente;
                rapido = rapido.siguiente.siguiente;
            }

            Console.WriteLine($"El nodo del medio tiene el valor: {lento.dato}");
        }
    }

    
}
