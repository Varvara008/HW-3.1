using System;

namespace HW_3._1
{
    internal class LineArray
    {
        private int[] array;
        public LineArray(int count, bool isUserInput = false)
        {
            this.array = new int[count];
            if(isUserInput)
            {
                UserInput(count);
            }
            else
            {
                RandomInput(count);
            }
        }
        
        private int GetMax()
        {
            int max = 0;
            for(int i = 0; i < this.array.Length; i++)
            {
               if(Math.Abs(this.array[i]) > Math.Abs(max))
               {
                    max = this.array[i];
               }
            }
            return max;
        }
        private void UserInput(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите элемент с индексом {i}: ");
                this.array[i] = int.Parse(Console.ReadLine());
            }
        }

        private void RandomInput(int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                this.array[i] = random.Next(1, 501);
            }
        }

        public void Display()
        {
            Console.Write("[");
            for(int i = 0; i < this.array.Length; i++)
            {
                string spaces = new string(' ', GetMax().ToString().Length - this.array[i].ToString().Length);
                Console.Write($"{spaces}{this.array[i]}");
            }
            Console.WriteLine(" ]");
        }

        public float GetAverage()
        {
            float sum = 0;

            for(int i = 0; i < this.array.Length; i++)
            {
                sum += this.array[i];
            }
            return sum / this.array.Length;
        }

        public void DeleteElementsUpper100()
        {
            int[] result = {};
            
            for(int i = 0; i < this.array.Length;i++)
            {
                if(this.array[i] <= 100 && this.array[i] >= -100)
                {
                    Array.Resize( ref result, result.Length + 1);
                    result[result.Length - 1] = this.array[i];
                }
            }
            this.array = result;
        }

        public void DeleteDublicates()
        {
            int[] result = { };

            for (int i = 0; i < this.array.Length; i++)
            {
                if (!result.Contains(this.array[i]))
                {
                    Array.Resize(ref result, result.Length + 1);
                    result[result.Length - 1] = this.array[i];
                }
            }
            this.array = result;
        }
    }
}
