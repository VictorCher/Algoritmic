using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmicAndStuctureData
{
    class Graf
    {
        public static string path = "graf.txt";
        public static void CreateGraf()
        {
            byte[,] graf =
            {
                {0, 2, 0, 3},
                {2, 0, 1, 0},
                {0, 1, 0, 4},
                {3, 0, 4, 0},
            };
            StreamWriter file = new StreamWriter(path);
            file.WriteLine(graf.Length);
            for(int i = 0; i < graf.GetLength(0); i++)
            {
                for(int j = 0; j < graf.GetLength(1); j++)
                {
                    file.Write(graf[i, j] + " ");
                }
                file.WriteLine();
            }
            file.Close();
        }
    }
}
