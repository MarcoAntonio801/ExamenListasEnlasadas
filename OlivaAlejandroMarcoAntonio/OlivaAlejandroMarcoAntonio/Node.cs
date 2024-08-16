using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OlivaAlejandroMarcoAntonio
{
    internal class Node
    {
        public int Data { get; set; } // Valor del nodo
        public Node Next { get; set; } // Referencia al siguiente nodo

        public Node(int value)
        {
            Data = value;
            Next = null;
        }
    }
}
