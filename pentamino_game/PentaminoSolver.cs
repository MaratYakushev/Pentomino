using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pentamino_game
{
    class PentaminoSolver
    {

        public class NodeCoord
        {
            public int x;
            public int y;

            
            public override bool Equals(object obj)
            {
                NodeCoord o = (NodeCoord)obj;
                return (o.x == x) && (o.y == y);
            }

            // override object.GetHashCode
            public override int GetHashCode()
            {
                // TODO: write your implementation of GetHashCode() here
                throw new NotImplementedException();
                return base.GetHashCode();
            }
        }

        private NodeCoord[,] node_coord;
        int[,] board_array;
        private DLX dlx;

        public PentaminoSolver(int[,] arr)
        {
            this.board_array = arr;
            dlx = new DLX();
            node_coord = new NodeCoord[board_array.GetLength(0), board_array.GetLength(1)];
            CreateMatrixStructur();
        }

        char[,] solution_res;

        public void PentaminoSolve()
        {
            Console.WriteLine("Solve is " + dlx.Solve() + " " + dlx.SolutionArr.Count);
            solution_res = new char[board_array.GetLength(0), board_array.GetLength(1)];

            for(int i = 0; i < solution_res.GetLength(0); i++)
            {
                for(int j = 0; j < solution_res.GetLength(1); j++)
                {
                    solution_res[i, j] = ' ';
                }
            }
            char key = 'A';
            foreach(Nodes.Node sol in dlx.SolutionArr)
            {
                Console.WriteLine(((NodeCoord)sol.data).x + " and " + ((NodeCoord)sol.data).y);
                Nodes.Node node = sol;
                do
                {
                    NodeCoord coord = ((NodeCoord)node.data);
                    if(coord != null)
                    {
                        solution_res[coord.x, coord.y] = key;
                    }
                    node = node.right;
                } while (node != sol);
                key++;
            }
            print();
        }

        void print()
        {
            for (int i = 0; i < solution_res.GetLength(0); i++)
            {
                for (int j = 0; j < solution_res.GetLength(1); j++)
                {
                    Console.Write(solution_res[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        public void CreateMatrixStructur()
        {
            int headerCount = 0;
            for (int i = 0; i < board_array.GetLength(0); i++)
            {
                for (int j = 0; j < board_array.GetLength(1); j++)
                {
                    if (board_array[i, j] == 1)
                    {
                        node_coord[i, j] = new NodeCoord() { x = i, y = j };
                        headerCount++;

                    }
                }
            }
            Console.WriteLine();
            for (int i = 0; i < node_coord.GetLength(0); i++)
            {
                for(int j = 0; j < node_coord.GetLength(1); j++)
                {
                    if(node_coord[i, j]!=null)
                    Console.Write(node_coord[i, j].x + "  "+ node_coord[i, j].y + " || ");
                }
                Console.WriteLine();
            }


            dlx.CreateHeadersNodes(headerCount);
            Nodes.Node header_node = dlx.header_root.right;
            int count = 0;
            for (int i = 0; i < board_array.GetLength(0); i++)
            {
                for (int j = 0; j < board_array.GetLength(1); j++)
                {
                    if (node_coord[i, j] != null)
                    {
                        header_node.data = node_coord[i, j];
                        header_node = header_node.right;
                        count++;
                    }
                }
            }


            

            foreach (int[,] fig in Figures.getFigures())
            {
                int[,] cur_figures = (int[,])fig.Clone();
                for (int i = 0; i < board_array.GetLength(0); i++)
                {
                    for (int j = 0; j < board_array.GetLength(1); j++)
                    {
                        if (board_array[i, j] == 1)
                        {
                            NodeCoord[] c = CheckFigures(cur_figures, i, j);
                            if (c != null)
                            {
                                AddToStructureMatrix(cur_figures, i, j, c);
                            }

                        }
                    }
                }
            }

        }


        private NodeCoord[] CheckFigures(int[,] cur_figure, int i, int j)
        {
            bool flag = true;
            NodeCoord[] coord = new NodeCoord[5];
            for (int dot = 0; dot < cur_figure.GetLength(0); dot++)
            {
                int row = i + cur_figure[dot, 0];
                int col = j + cur_figure[dot, 1];


                try
                {
                    if (board_array[row, col] != 1)
                    {
                        flag = false;
                        coord = null;
                        break;
                    }
                }
                catch (IndexOutOfRangeException e)
                {
                    flag = false;
                    coord = null;
                    break;
                }

                coord[dot] = new NodeCoord() { x = row, y = col };

            }

            return flag ? coord : null;
        }

        private void AddToStructureMatrix(int[,] figure, int i, int j, NodeCoord[] coord)
        {
            int count = 0;
            ArrayList rows = new ArrayList();
            foreach (Nodes.HeaderNode header in dlx.headers_columns)
            {
                foreach (NodeCoord cord in coord)
                {
                    if (header.data.Equals(cord))
                    {
                        Nodes.Node newNode = new Nodes.Node();
                        newNode.data = cord;
                        header.AddNode(newNode);
                        rows.Add(newNode);
                        Console.WriteLine("Item " + ((NodeCoord)header.data).x + " " + ((NodeCoord)header.data).y);
                        count++;
                        break;
                    }
                }
                if (count == coord.Length)
                {
                    break;
                }
            }

            

            Nodes.Node first_node = null;
            Nodes.Node last_node = null;

            for (Nodes.Node node = dlx.header_root.right; node != dlx.header_root; node = node.right)
            {
                foreach (Nodes.Node row in rows)
                {
                    if ((first_node == null) && (row.data.Equals(node.data)))
                    {
                        first_node = row;
                        last_node = row;
                        continue;
                    }

                    if ((first_node != null) && (row.data.Equals(node.data)))
                    {
                        
                        last_node.right = row;
                        row.left = last_node;
                        last_node = row;
                    }
                }
            }
            last_node.right = first_node;
            first_node.left = last_node;
        }

    }

}

