using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pentamino_game
{
    class Figures
    {

       public class FigureItem
        {
            public int[,] figure;
            public int figure_id;

            public FigureItem(int[,] figure, int id)
            {
                this.figure = figure;
                this.figure_id = id;
            }
        }

        public static int[,] f_Z_base = { { -1, -1 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 1, 1 } };
        public static int[,] f_I_base = { { -2, 0 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 2, 0 } };

        //V 
        public static int[,] V_R_1 = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { -1, 0 }, { -2, 0 } };

        public static int[,] V_R_2 = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 0 }, { 2, 0 } };

        public static int[,] V_R_3 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { 1, 0 }, { 2, 0 } };

        public static int[,] V_R_4 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { -1, 0 }, { -2, 0 } };


        // N
        public static int[,] N_R_1 = { { 0, 0 }, { 0, 1 }, { 1, 1 }, { -1, 0 }, { -2, 0 } };

        public static int[,] N_F_1 = { { 0, 0 }, { 0, -1 }, { 1, 1 }, { -1, 0 }, { -2, 0 } };

        public static int[,] N_R_2 = { { 0, 0 }, { 0, 1 }, { -1, 1 }, { 1, 0 }, { 2, 0 } };

        public static int[,] N_F_2 = { { 0, 0 }, { 0, -1 }, { -1, -1 }, { 1, 0 }, { 2, 0 } };

        public static int[,] N_R_3 = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { -1, 0 }, { -1, -1 } };

        public static int[,] N_F_3 = { { 0, 0 }, { 1, 0 }, { 1, -1 }, { 0, 1 }, { 0, 2 } };

        public static int[,] N_R_4 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { -1, 0 }, { -1, 1 } };

        public static int[,] N_F_4 = { { 0, 0 }, { 1, 0 }, { 1, 1 }, { 0, -1 }, { 0, -2 } };

        //P

        public static int[,] P_R_1 = { { 0, 0 }, { 0, -1 }, { 1, -1 }, { 1, 0 }, { 0, 1 } };

        public static int[,] P_F_1 = { { 0, 0 }, { 0, -1 }, { 1, 1 }, { 1, 0 }, { 0, 1 } };

        public static int[,] P_R_2 = { { 0, 0 }, { 0, -1 }, { -1, -1 }, { -1, 0 }, { 0, 1 } };

        public static int[,] P_F_2 = { { 0, 0 }, { 0, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 } };

        public static int[,] P_R_3 = { { 0, 0 }, { 1, 0 }, { 0, 1 }, { -1, 1 }, { -1, 0 } };

        public static int[,] P_F_3 = { { 0, 0 }, { 0, -1 }, { -1, -1 }, { -1, 0 }, { 1, 0 } };

        public static int[,] P_R_4 = { { 0, 0 }, { -1, 0 }, { 0, 1 }, { 1, 1 }, { 1, 0 } };

        public static int[,] P_F_4 = { { 0, 0 }, { 1, 0 }, { 1, -1 }, { 0, -1 }, { -1, 0 } };

        //U

        public static int[,] U_R_1 = { { 0, 0 }, { 0, -1 }, { -1, 0 }, { -1, 1 }, { 0, 1 } };

        public static int[,] U_R_2 = { { 0, 0 }, { 0, -1 }, { 1, -1 }, { 0, 1 }, { 1, 1 } };

        public static int[,] U_R_3 = { { 0, 0 }, { 1, 0 }, { 1, 1 }, { -1, 0 }, { -1, 1 } };

        public static int[,] U_R_4 = { { 0, 0 }, { 0, -1 }, { -1, -1 }, { 0, 1 }, { 1, 1 } };

        //Y
        public static int[,] Y_R_1 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { 0, 1 }, { -1, 0 } };

        public static int[,] Y_F_1 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { 0, 1 }, { 1, 0 } };

        public static int[,] Y_R_2 = { { 0, 0 }, { 0, -1 }, { 0, 1 }, { 0, 2 }, { -1, 0 } };

        public static int[,] Y_F_2 = { { 0, 0 }, { 0, -1 }, { 0, 1 }, { 0, 2 }, { 1, 0 } };

        public static int[,] Y_R_3 = { { 0, 0 }, { 1, 0 }, { 0, 1 }, { -1, 0 }, { -2, 0 } };

        public static int[,] Y_F_3 = { { 0, 0 }, { 1, 0 }, { 0, -1 }, { -1, 0 }, { -2, 0 } };

        public static int[,] Y_R_4 = { { 0, 0 }, { 1, 0 }, { 2, 0 }, { -1, 0 }, { 0, 1 } };

        public static int[,] Y_F_4 = { { 0, 0 }, { 1, 0 }, { 2, 0 }, { -1, 0 }, { 0, -1 } };

        //W
        public static int[,] W_R_1 = { { 0, 0 }, { 1, 1 }, { 1, 0 }, { 0, -1 }, { -1, -1 } };

        public static int[,] W_F_1 = { { 0, 0 }, { 1, 1 }, { 0, 1 }, { -1, 0 }, { -1, -1 } };

        public static int[,] W_R_2 = { { 0, 0 }, { -1, -1 }, { 0, -1 }, { -1, 0 }, { 1, 1 } };

        public static int[,] W_F_2 = { { 0, 0 }, { 1, 1 }, { 1, 0 }, { 1, 0 }, { -1, 1 } };

        //X
        public static int[,] X_R_1 = { { 0, 0 }, { -1, 0 }, { 0, -1 }, { 1, 0 }, { 0, 1 } };

        //T
        public static int[,] T_R_1 = { { 0, 0 }, { 0, -1 }, { 0, 1 }, { -1, 0 }, { -2, 0 } };

        public static int[,] T_F_1 = { { 0, 0 }, { 0, -1 }, { 0, 1 }, { 1, 0 }, { 2, 0 } };

        public static int[,] T_R_2 = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 1, 0 }, { -1, 0 } };

        public static int[,] T_F_2 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { 1, 0 }, { -1, 0 } };

        //L
        public static int[,] L_R_1 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { 0, -3 }, { -1, 0 } };

        public static int[,] L_F_1 = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { -1, 0 } };

        public static int[,] L_R_2 = { { 0, 0 }, { 0, 1 }, { 0, 2 }, { 0, 3 }, { 1, 0 } };

        public static int[,] L_F_2 = { { 0, 0 }, { 0, -1 }, { 0, -2 }, { 0, -3 }, { 1, 0 } };

        public static int[,] L_R_3 = { { 0, 0 }, { 0, 1 }, { -1, 0 }, { -2, 0 }, { -3, 0 } };

        public static int[,] L_F_3 = { { 0, 0 }, { 0, -1 }, { -1, 0 }, { -2, 0 }, { -3, 0 } };

        public static int[,] L_R_4 = { { 0, 0 }, { 0, 1 }, { 1, 0 }, { 2, 0 }, { 3, 0 } };

        public static int[,] L_F_4 = { { 0, 0 }, { 0, -1 }, { 1, 0 }, { 2, 0 }, { 3, 0 } };

        //F
        public static int[,] F_R_1 = { { 0, 0 }, { 0, -1 }, { 1, 0 }, { -1, 0 }, { -1, 1 } };

        public static int[,] F_F_1 = { { 0, 0 }, { 0, 1 }, { 1, 0 }, { -1, 0 }, { -1, -1 } };

        public static int[,] F_R_2 = { { 0, 0 }, { 0, 1 }, { 0, -1 }, { -1, 1 }, { -1, 0 } };

        public static int[,] F_F_2 = { { 0, 0 }, { 0, 1 }, { 0, -1 }, { 1, 1 }, { -1, 0 } };

        public static int[,] F_R_3 = { { 0, 0 }, { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, -1 } };

        public static int[,] F_F_3 = { { 0, 0 }, { 0, 1 }, { 0, -1 }, { 1, 0 }, { -1, 1 } };

        public static int[,] F_R_4 = { { 0, 0 }, { 1, 0 }, { -1, 0 }, { 0, -1 }, { 1, 1 } };

        public static int[,] F_F_4 = { { 0, 0 }, { 1, 0 }, { -1, 0 }, { 0, 1 }, { 1, -1 } };

        //Z
        public static int[,] Z_R_1 = { { -1, 1 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 1, -1 } };

        public static int[,] Z_F_1 = { { -1, -1 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 1, 1 } };

        public static int[,] Z_R_2 = { { 0, -1 }, { 0, 1 }, { 0, 0 }, { 1, -1 }, { -1, 1 } };

        public static int[,] Z_F_2 = { { -1, -1 }, { 0, -1 }, { 0, 0 }, { 0, 1 }, { 1, 1 } };

        //I
        public static int[,] I_R_1 = { { -2, 0 }, { -1, 0 }, { 0, 0 }, { 1, 0 }, { 2, 0 } };

        public static int[,] I_R_2 = { { 0, 1 }, { 0, 2 }, { 0, 0 }, { 0, -1 }, { 0, -2 } };








        public static List<FigureItem> GetFigures()
        {
            List<FigureItem> list = new List<FigureItem>();
            list.Add(new FigureItem(V_R_1,0));
            list.Add(new FigureItem(V_R_2,0));
            list.Add(new FigureItem(V_R_3,0));
            list.Add(new FigureItem(V_R_4,0));
            list.Add(new FigureItem(N_R_1,1));
            list.Add(new FigureItem(N_F_1,1));
            list.Add(new FigureItem(N_R_2,1));
            list.Add(new FigureItem(N_F_2,1));
            list.Add(new FigureItem(N_R_3,1));
            list.Add(new FigureItem(N_F_3,1));
            list.Add(new FigureItem(N_R_4,1));
            list.Add(new FigureItem(N_F_4,1));
            list.Add(new FigureItem(P_R_1,2));
            list.Add(new FigureItem(P_F_1,2));
            list.Add(new FigureItem(P_R_2,2));
            list.Add(new FigureItem(P_F_2,2));
            list.Add(new FigureItem(P_R_3,2));
            list.Add(new FigureItem(P_F_3,2));
            list.Add(new FigureItem(P_R_4,2));
            list.Add(new FigureItem(P_F_4,2));
            list.Add(new FigureItem(U_R_1,3));
            list.Add(new FigureItem(U_R_2,3));
            list.Add(new FigureItem(U_R_3,3));
            list.Add(new FigureItem(U_R_4,3));
            list.Add(new FigureItem(Y_R_1,4));
            list.Add(new FigureItem(Y_F_1,4));
            list.Add(new FigureItem(Y_R_2,4));
            list.Add(new FigureItem(Y_F_2,4));
            list.Add(new FigureItem(Y_R_3,4));
            list.Add(new FigureItem(Y_F_3,4));
            list.Add(new FigureItem(Y_R_4,4));
            list.Add(new FigureItem(Y_F_4,4));
            list.Add(new FigureItem(W_R_1,5));
            list.Add(new FigureItem(W_F_1,5));
            list.Add(new FigureItem(W_R_2,5));
            list.Add(new FigureItem(W_F_2,5));
            list.Add(new FigureItem(X_R_1,6));
            list.Add(new FigureItem(T_R_1,7));
            list.Add(new FigureItem(T_F_1,7));
            list.Add(new FigureItem(T_R_2,7));
            list.Add(new FigureItem(T_F_2,7));
            list.Add(new FigureItem(L_R_1,8));
            list.Add(new FigureItem(L_F_1,8));
            list.Add(new FigureItem(L_R_2,8));
            list.Add(new FigureItem(L_F_2,8));
            list.Add(new FigureItem(L_R_3,8));
            list.Add(new FigureItem(L_F_3,8));
            list.Add(new FigureItem(L_R_4,8));
            list.Add(new FigureItem(L_F_4,8));
            list.Add(new FigureItem(F_R_1,9));
            list.Add(new FigureItem(F_F_1,9));
            list.Add(new FigureItem(F_R_2,9));
            list.Add(new FigureItem(F_F_2,9));
            list.Add(new FigureItem(F_R_3,9));
            list.Add(new FigureItem(F_F_3,9));
            list.Add(new FigureItem(F_R_4,9));
            list.Add(new FigureItem(F_F_4,9));
            list.Add(new FigureItem(Z_R_1,10));
            list.Add(new FigureItem(Z_F_1,10));
            list.Add(new FigureItem(Z_R_2,10));
            list.Add(new FigureItem(Z_F_2,10));
            list.Add(new FigureItem(I_R_1,11));
            list.Add(new FigureItem(I_R_2,11));
            return list;
        }
    }
}
