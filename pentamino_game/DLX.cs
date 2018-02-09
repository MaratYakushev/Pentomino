using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pentamino_game
{
    class DLX
    {
        public ArrayList headers_columns = new ArrayList();
        public Nodes.HeaderNode header_root;

        ArrayList solution_array = new ArrayList();

        public ArrayList SolutionArr
        {
            get
            {
                return solution_array;
            }
        }

        int n;
        int d;

        public void CreateHeadersNodes(int count)
        {
            header_root = new Nodes.HeaderNode();
            
            for(int i = 0; i < count; i++)
            {
                Nodes.HeaderNode header_node = new Nodes.HeaderNode();
                headers_columns.Add(header_node);

                header_node.left = header_root.left;
                header_node.right = header_root;
                header_root.left.right = header_node;
                header_root.left = header_node;

               
            }
        }

        private Nodes.HeaderNode ShortColumn()
        {            
            int k = 1;
            Nodes.HeaderNode column = null;
            int min = int.MaxValue;
            
            for(Nodes.HeaderNode col_header = (Nodes.HeaderNode)header_root.right; col_header!= header_root; col_header = (Nodes.HeaderNode)col_header.right)
            {
                Console.WriteLine(k + " Column header is " + ((pentamino_game.PentaminoSolver.NodeCoord)col_header.data).x + " " + ((pentamino_game.PentaminoSolver.NodeCoord)col_header.data).y+
                    " have " + col_header.count_nodes); k++;

                if (col_header.count_nodes < min)
                {                 
                    min = col_header.count_nodes;
                    column = col_header;
                }
            }

            return column;
        }

        public bool Solve()
        {
            if(header_root.right == header_root)
            {
                return true;
            }

            if(headers_columns.Count == 0)
            {
                return true;
            }

            Nodes.HeaderNode header = ShortColumn();

            Remove(header);

            Nodes.Node node = header.down;
            n++;

            while (node != header)
            {
                solution_array.Add(node);
                n++;
                
                for (Nodes.Node node_it = node.right; node_it != node; node_it = node_it.right)
                {
                    Remove(node_it.header);
                }
                d++;
                if (Solve())
                {
                    return true;
                }
                d--;
                solution_array.RemoveAt(solution_array.Count - 1);
                header = node.header;

                for(Nodes.Node node_it = node.left; node_it!=node; node_it = node_it.left)
                {
                    Restore(node_it.header);
                }

                node = node.down;
            }

            Restore(header);
            return false;          
        }



        private void Remove(Nodes.HeaderNode header)
        {
            header.right.left = header.left;
            header.left.right = header.right;

            for(Nodes.Node row = header.down; row != header; row = row.down)
            {
                for(Nodes.Node col = row.right; col != row; col = col.right)
                {
                    col.down.up = col.up;
                    col.up.down = col.down;
                    col.header.count_nodes--;
                }
            }
        }

        private void Restore(Nodes.HeaderNode header)
        {


            for (Nodes.Node row = header.up; row != header; row = row.up)
            {
                for (Nodes.Node col = row.left; col != row; col = col.left)
                {
                    col.header.count_nodes++;
                    col.down.up = col;
                    col.up.down = col;
                   
                }
            }
            header.right.left = header;
            header.left.right = header;
        }
    }
}
