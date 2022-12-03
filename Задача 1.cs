using System;

namespace Задача_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите количество элементов последовательности: ");
            int np = int.Parse(Console.ReadLine());
            int[] arr = new int[np];
            for (int i = 0; i < np; i++)
            {
                Console.Write("{0} элемент последовательности: ", i + 1);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            Console.Write("Введите размерность матрицы: ");
            int nm = int.Parse(Console.ReadLine());
            int[,] mas = new int[nm, nm];
            Console.WriteLine("Заполните матрицу:");
            for (int i = 0; i < nm; i++)
            {
                for (int j = 0; j < nm; j++)
                {
                    Console.Write("mas[{0},{1}]: ", i + 1, j + 1);
                    mas[i, j] = int.Parse(Console.ReadLine());
                }
            }

            double a = 0;
            int b = 0;
            for (int i = 0; i < nm; i++)
            {
                for (int j = 0; j < nm; j++)
                {
                    a = (double)(i + j + 2) / 2;
                    b = (int)a;
                    a = (double)(a - b);

                    if (a == 0)
                    {
                        for (int k = 0; k < nm; k++)
                        {
                            if (mas[i, j] == arr[k])
                            {
                                mas[i, j] = 0;
                            }
                        }
                    }
                    a = 0;
                    b = 0;
                }
            }

            Console.WriteLine("\nОтвет:");
            for (int i = 0; i < nm; i++)
            {
                for (int j = 0; j < nm; j++)
                {
                    Console.Write("{0} ", mas[i, j]);
                    if (j == nm - 1)
                    {
                        Console.WriteLine();
                    }
                }
            }
        }
    }
}