namespace Estrutura_dio
{
    using System;
    public class Matriz
    {
        public int[,,] Matrix = new int [0,0,0];

        public Matriz()
        {
                int[,,,] matriz = new int[5, 5, 5, 5];

            Random rand = new Random();


            for (var i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    for (int k = 0; k < 5; k++)
                    {
                        for (int l = 0; l < 5; l++)
                        {
                            var teste = rand.Next(1, 9);
                            matriz[i, j, k, l] = teste;
                            Console.Write($"[{matriz[i, j, k, l]}]");
                        }
                        Console.Write("\n");
                    }
                    Console.Write("\n");
                }
                Console.Write("\n");

            }
        }

        
    }
}