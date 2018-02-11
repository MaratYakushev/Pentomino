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

            Console.WriteLine("Введите путь к файлу с картинкой");
            string pict_path = Console.ReadLine();


            Console.WriteLine("Введите путь сохранения решения");
            string sol_path = Console.ReadLine();

            int[,] arr = ReadFile(pict_path);
            PentaminoSolver solver = new PentaminoSolver(arr);
            solver.PentaminoSolve();
            char[,] solution = solver.solution_res;
            if(solution != null)
            {
                WriteFile(solver.solution_res, sol_path);
                Console.WriteLine("Готово!");
            }

            Console.ReadKey();
        }

        static void WriteFile(char[,] solution, string path)
        {
           
            using(StreamWriter sw = new StreamWriter(path))
            {
                for(int i = 0; i < solution.GetLength(0); i++)
                {
                    for(int j= 0; j < solution.GetLength(1); j++)
                    {
                        sw.Write(solution[i, j] + " ");
                    }
                    sw.WriteLine();
                }     
            }
        }

        static int[,] ReadFile(string path)
        {
            string str;
            int rows = 0;
            int cols = 0;
            List<string> list = new List<string>();
            StreamReader file = null;
            try
            {
                file = new StreamReader(path);
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
