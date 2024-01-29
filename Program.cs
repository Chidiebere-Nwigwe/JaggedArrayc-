using System;
class Program
{
    static void Display2D(int[,] x)
    {
        Console.Write("{");
        for (int i = 0; i < x.GetLength(0); i++)
        {
            Console.Write("{");
            for (int j = 0; j < x.GetLength(1); j++)
            {
                Console.Write(x[i, j] + " ");
            }
            Console.Write("}");
        }
        Console.Write("}");
    }

    static void DisplayAll(int[][,] ja3D)
    {
        for(int i = 0; i < ja3D.Length; i++)
        {
            Console.Write("{");
            for (int j = 0; j < ja3D[i].GetLength(0); j++)
            {
                Console.Write("{");
                for(int  d = 0; d < ja3D[i].GetLength(1); d++)
                {
                    Console.Write(ja3D[i][j,d] + ",");
                }
                Console.Write("} ");

            }
            Console.Write("}");
        Console.WriteLine();
    }
    }
    static void Main(string[] args)
    {
        int[][,] ja3D = new int[3][,]
                {
                    new int[,] { {1,2} },
                    new int[,] { {1,4}, {4,8}, {7,12} },
                    new int[,] { {3,2,1,0}, {5,5,4,3}}
                };
        Console.WriteLine("A specific  set of element displayed: ");
        Display2D(ja3D[0]);
        Console.WriteLine();
        Console.WriteLine("All my elements displayed: ");
        DisplayAll(ja3D);
        //Console.WriteLine(ja3D[2][1,2]);
    }
}

