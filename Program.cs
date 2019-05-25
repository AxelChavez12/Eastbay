using System;

namespace ERICK_LINO
{
    class Program
    {
        static void Main(string[] args)
        {
          int[,] mat1 = new int[,]{{1,2,3},{4,5,6},{6,7,8}};
            int[,] mat2 = new int[,]{{2,3},{5,6},{7,8}};
            int[,] resul = new int[3,3];
            int c, suma;

            for(int i=0; i<3; i++)
            {
                c = 0;
                while (c < 3)
                {
                    suma = 0;
                    for (int j = 0; j < 3; j++)
                    {
                        suma = suma + (mat1[i, j] * mat2[j, c]);

                        resul[i, c] = suma;
                        c = c + 1;
                    }
                }

                NewMethod(resul);
            }
        }

        private static void NewMethod(int[,] resul)
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(resul[i, j] + "\t");
                    Console.WriteLine();
                }
                Console.ReadKey();
            }
        }
    }
}

