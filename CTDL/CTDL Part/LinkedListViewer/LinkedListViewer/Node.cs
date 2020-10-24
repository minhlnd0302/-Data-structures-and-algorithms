using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListViewer
{
    class Node
    {
        public int value;
        public int vl { get; set; }
        public int addr;
        public int ad { get; set; }
        public Node()
        {
            value = 0;
            addr = 0;
        }
        public Node(int a,int b)
        {
            value = a;
            addr = b;
        }
    }
}
