using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace pentamino_game
{
    class Program
    {
        struct point
        {
            public int x;
            public int y;
        }

        static void Main(string[] args)
        {
            int[,] figure_Z = {   { -1, -1 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 1, 1 } };
            int[,] figure_I = { { -2, 0 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 2, 0 } };

            int[,] cur_figure = figure_I;
 
            int[,] arr = ReadFile();

            PentaminoSolver solver = new PentaminoSolver(arr);
            solver.PentaminoSolve();
            Console.WriteLine("Done");

            Console.ReadKey();
        }

        static int[,] ReadFile()
        {
            string str;
            int rows = 0;
            int cols = 0;
            List<string> list = new List<string>();
            StreamReader file = null;
            try
            {
                file = new StreamReader(@"I:\mobirate test\files\3.in");
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка открытия файла");
                return null;
            }

            while ((str = file.ReadLine()) != null)
            {
                rows++;
                cols = cols < str.Length ? str.Length : cols;
                list.Add(str);
            }
            int[,] pict_array = new int[rows, cols];
            int row = 0;
            foreach (string s in list)
            {
                for (int col = 0; col < cols; col++)
                {
                    if (col < s.Length)
                    {
                        pict_array[row, col] = s[col] == 'o' ? 1 : 0;
                    }
                    else
                    {
                        pict_array[row, col] = 0;
                    }
                }
                row++;
            }

            list.Clear();
            file.Close();
            return pict_array;
        }
    }
}
