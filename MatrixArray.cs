using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._1
{
    internal class MatrixArray
    {
        private int[,] array;
        public MatrixArray(int rows, int columns, bool isUserInput = false )
        {
            this.array = new int[rows, columns];
            
            if (isUserInput)
            {
                UserInput(rows, columns);
            }
            else
            {
                RandomInput(rows, columns);
            }
        }
        private int GetMax()
        {
            int max = 0;
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for(int j = 0; j < this.array.GetLength(1); j++)
                {
                    if (Math.Abs(this.array[i, j]) > Math.Abs(max))
                    {
                        max = this.array[i, j];
                    }
                }
            }
            return max;
        }
        private void UserInput(int rows, int columns)
        {
            for (int i = 0; i < rows; i++)
            {
               for(int j = 0; j < columns; j++)
               {
                    Console.WriteLine($"Введите элемент с индексами {i}, {j}: ");
                    this.array[i, j] = int.Parse(Console.ReadLine());
               }

            }
        }

        private void RandomInput(int rows, int columns)
        {
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    this.array[i, j] = random.Next(1, 501);
                }

            }
        }

        public void Display()
        {
            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    string spaces = new string(' ', GetMax().ToString().Length - this.array[i, j].ToString().Length + 1);
                    Console.Write($"{spaces}{this.array[i, j]}");
                }
                Console.WriteLine();
            }

        }
        
        public float GetAverage()
        {
            float sum = 0;

            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                for (int j = 0; j < this.array.GetLength(1); j++)
                {
                    sum += this.array[i, j];
                }

            }
            return sum / (this.array.GetLength(0) * this.array.GetLength(1));

        }

        public void DisplayReversedEvenRows()
        {
            Display();

            for (int i = 0; i < this.array.GetLength(0); i++)
            {
                if(i % 2 == 0)
                {
                    for (int j = this.array.GetLength(1) - 1; j >= 0; j--)
                    {
                        string spaces = new string(' ', GetMax().ToString().Length - this.array[i, j].ToString().Length + 1);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                }
                else
                {
                    for (int j = 0; j < this.array.GetLength(1); j++)
                    {
                        string spaces = new string(' ', GetMax().ToString().Length - this.array[i, j].ToString().Length + 1);
                        Console.Write($"{spaces}{this.array[i, j]}");
                    }
                }

                Console.WriteLine();

            }
        }
    }
}
