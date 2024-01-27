using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HW_3._1
{
    internal class StepArray
    {
        private int[][] array;

        public StepArray(int rows, int[] columns, bool isUserInput = false)
        {
            this.array = new int[rows][];

            for(int i = 0; i < rows; i++)
            {
                this.array[i] = new int[columns[i]];
            }

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
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    if (Math.Abs(this.array[i][j]) > Math.Abs(max))
                    {
                        max = this.array[i][j];
                    }
                }
            }
            return max;
        }
        private void UserInput(int rows, int[] columns)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    Console.WriteLine($"Введите элемент с индексами {i}, {j}: ");
                    this.array[i][j] = int.Parse(Console.ReadLine());
                }

            }
        }

        private void RandomInput(int rows, int[] columns)
        {
            Random random = new Random();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns[i]; j++)
                {
                    this.array[i][j] = random.Next(1, 501);
                }

            }
        }

        public void Display()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    string spaces = new string(' ', GetMax().ToString().Length - this.array[i][j].ToString().Length + 1);
                    Console.Write($"{spaces}{this.array[i][j]}");
                }
                Console.WriteLine();
            }

        }

        public float GetAverage()
        {
            float sum = 0;
            int count = 0;

            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                    count++;
                }

            }
            return sum / count;

        }

        public float[] GetAverageInRows()
        {
            float[] averages = new float[this.array.Length];

            for (int i = 0; i < this.array.Length; i++)
            {
                float sum = 0;
                int count = 0;
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    sum += this.array[i][j];
                    count++;
                    averages[i] = sum/ count;
                }

            }
            return averages;
        }

        public void ChangeEvenNumbers()
        {
            for (int i = 0; i < this.array.Length; i++)
            {
                for (int j = 0; j < this.array[i].Length; j++)
                {
                    if(this.array[i][j] % 2 == 0)
                    {
                        this.array[i][j] = i * j;
                    }
                }
                
            }
        }
    }
}
