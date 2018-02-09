using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class Node
    {
        public Node up;
        public Node down;
        public Node left;
        public Node right;
        public Object data;
        public HeaderNode header;

        public Node()
        {
            up = down = left = right = this;
        }
    }
}
