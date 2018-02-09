using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pentamino_game
{
    class Figures
    {
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








        public static List<int[,]> getFigures()
        {
            List<int[,]> list = new List<int[,]>();
            list.Add(V_R_1);
                list.Add(V_R_2);
                list.Add(V_R_3);
                list.Add(V_R_4);
                list.Add(N_R_1);
                list.Add(N_F_1);
                list.Add(N_R_2);
                list.Add(N_F_2);
                list.Add(N_R_3);
                list.Add(N_F_3);
                list.Add(N_R_4);
                list.Add(N_F_4);
                list.Add(P_R_1);
                list.Add(P_F_1);
                list.Add(P_R_2);
                list.Add(P_F_2);
                list.Add(P_R_3);
                list.Add(P_F_3);
                list.Add(P_R_4);
                list.Add(P_F_4);
                list.Add(U_R_1);
                list.Add(U_R_2);
                list.Add(U_R_3);
                list.Add(U_R_4);
                list.Add(Y_R_1);
                list.Add(Y_F_1);
                list.Add(Y_R_2);
                list.Add(Y_F_2);
                list.Add(Y_R_3);
                list.Add(Y_F_3);
                list.Add(Y_R_4);
                list.Add(Y_F_4);
                list.Add(W_R_1);
                list.Add(W_F_1);
                list.Add(W_R_2);
                list.Add(W_F_2);
                list.Add(X_R_1);
                list.Add(T_R_1);
                list.Add(T_F_1);
                list.Add(T_R_2);
                list.Add(T_F_2);
                list.Add(L_R_1);
                list.Add(L_F_1);
                list.Add(L_R_2);
                list.Add(L_F_2);
                list.Add(L_R_3);
                list.Add(L_F_3);
                list.Add(L_R_4);
                list.Add(L_F_4);
                list.Add(F_R_1);
                list.Add(F_F_1);
                list.Add(F_R_2);
                list.Add(F_F_2);
                list.Add(F_R_3);
                list.Add(F_F_3);
                list.Add(F_R_4);
                list.Add(F_F_4);
                list.Add(Z_R_1);
                list.Add(Z_F_1);
                list.Add(Z_R_2);
                list.Add(Z_F_2);
                list.Add(I_R_1);
                list.Add(I_R_2);
            return list;
        }
    }
}
