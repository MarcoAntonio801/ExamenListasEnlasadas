using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlivaAlejandroMarcoAntonio
{
    internal class LikedList
    {
        public Node Head { get; private set; }

        public LikedList()
        {
            Head = null;
        }

        // Método para insertar un nodo al inicio de la lista
        public void InsertarInicio(int value)
        {
            Node newNode = new Node(value);
            newNode.Next = Head;
            Head = newNode;
        }

        // Método para insertar un nodo al final de la lista
        public void InsertarFinal(int value)
        {
            Node newNode = new Node(value);

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                Node current = Head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
            }
        }

        // Método para mostrar todos los elementos de la lista
        public void PrintList()
        {
            if (Head == null)
            {
                Console.WriteLine("La lista está vacía.");
            }
            else
            {
                Node current = Head;
                while (current != null)
                {
                    Console.Write(current.Data + " -> ");
                    current = current.Next;
                }
                Console.WriteLine("null");
            }
        }

        // Método para eliminar un nodo dado un valor específico
        public void EliminarNodo(int value)
        {
            if (Head == null)
            {
                Console.WriteLine("La lista está vacía. No se puede eliminar el nodo.");
                return;
            }

            // Si el nodo a eliminar es el primero
            if (Head.Data == value)
            {
                Head = Head.Next;
                return;
            }

            // Buscar el nodo a eliminar
            Node current = Head;
            while (current.Next != null && current.Next.Data != value)
            {
                current = current.Next;
            }

            // Si llegamos al final de la lista y no encontramos el nodo
            if (current.Next == null)
            {
                Console.WriteLine("Nodo no encontrado.");
            }
            else
            {
                // Eliminar el nodo
                current.Next = current.Next.Next;
            }
        }

        public Node EncontrarNodoMedio()
        {
            if (Head == null)
            {
                Console.WriteLine("La lista está vacía.");
                return null;
            }

            Node lento = Head;
            Node rapido = Head;

            while (rapido != null && rapido.Next != null)
            {
                lento = lento.Next;
                rapido = rapido.Next.Next;
            }

            Console.WriteLine($"El nodo del medio tiene el valor: {lento.Data}");
            return lento;
        }

        public void InvertirLista()
        {
            if (Head == null)
            {
                Console.WriteLine("La lista está vacía. No se puede invertir.");
                return;
            }

            Node previo = null;
            Node actual = Head;
            Node siguiente = null;

            while (actual != null)
            {
                siguiente = actual.Next; // Guardamos el siguiente nodo
                actual.Next = previo;    // Invertimos el enlace
                previo = actual;         // Movemos 'previo' y 'actual' un paso adelante
                actual = siguiente;
            }

            Head = previo; // Ajustamos la cabeza de la lista
            Console.WriteLine("La lista ha sido invertida.");
        }
    }
}
