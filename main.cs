using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task1();
        }

        static void Task1()
        {
            float[] A = new float[5];
            float[,] B = new float[3, 4];

            for(int i = 0; i < A.Length; i++)
                A[i] = Convert.ToInt32(Console.ReadLine());

            Random randNum = new Random();

            for(int i = 0; i < 3; i++)
            {
                for(int j = 0; j < 4; j++)
                    B[i,j] = randNum.Next(1, 10);
            }

            //вывод
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write(A[i]);
            }

            Console.WriteLine('\n');

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(B[i,j]);
                }
                Console.Write('\n');
            }

            float[] AB = new float[17];
            int index = 0;
            for (int i = 0; i < A.Length; i++)
            {
                AB[index] = A[i];
                index++;
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    AB[index] = B[i, j];
                    index++;
                }
            }

            Console.WriteLine('\n');
            Array.Sort(AB);
            Console.WriteLine(AB[0]); //общий минимальный
            Array.Reverse(AB);
            Console.WriteLine(AB[0]); //общий максимальный

            float sumAB = new float();

            for (int i = 0; i < A.Length; i++)
            {
                sumAB += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumAB += B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(sumAB); //сумма

            float compAB = new float();
            compAB = 1;

            for (int i = 0; i < A.Length; i++)
            {
                compAB *= A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    compAB *= B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(compAB); //произведение

            float oddAB = new float();

            for (int i = 0; i < A.Length; i++)
            {
                if(A[i] % 2 == 0)
                    oddAB += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if(B[i,j] % 2 == 0)
                        oddAB += B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(oddAB); //сумма четных

            float evenAB = new float();

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] % 2 != 0)
                    evenAB += A[i];
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (j % 2 != 0)
                        evenAB += B[i, j];
                }
            }

            Console.WriteLine('\n');
            Console.Write(evenAB); //сумма нечетных

            //общий максимальный элемент
        }
    }
}
