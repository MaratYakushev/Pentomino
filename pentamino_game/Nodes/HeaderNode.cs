using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodes
{
    class HeaderNode : Node
    {
        public int count_nodes;
        public bool isNodeID = false;

        public HeaderNode()
        {
            header = this;
        }

        public void AddNode(Node node)
        {
            node.header = this;
            node.down = this;
            node.up = this.up;
            this.up.down = node;
            this.up = node;
            count_nodes++;
        }
    }
}
