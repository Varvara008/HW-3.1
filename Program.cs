using HW_3._1;
using System;
using System.Text;

class Program
{
    static void Main()
    {
        Console.OutputEncoding = Encoding.UTF8;

        Console.WriteLine("С какими массивами вы хотите работать?");
        Console.WriteLine("1 - Одномерные, 2 - Двумерные, 3 - Ступенчатые");
        int answer = int.Parse(Console.ReadLine());

        if (answer == 1)
        {
            Console.WriteLine("Сколько элементов вы хотите?");
            int count = int.Parse(Console.ReadLine());

            Console.WriteLine("Вы хотите заполнить массив самостоятельно?");
            Console.WriteLine("1 - Да, 2 - Нет");
            int fill = int.Parse(Console.ReadLine());

            LineArray array = new LineArray(count, fill == 1);

            while (true)
            {
                Console.WriteLine("Какой метод вы хотите вызвать?");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Отобразить");
                Console.WriteLine("2 - Удалить элементы больше 100 по модулю");
                Console.WriteLine("3 - Удалить одиннаковые элементы");
                Console.WriteLine("4 - Показать среднее арифметическое всех элементов");

                int metod = int.Parse(Console.ReadLine());

                if (metod == 0)
                {
                    break;
                }
                if (metod == 1)
                {
                    array.Display();
                }
                if (metod == 2)
                {
                    array.DeleteElementsUpper100();
                }
                if (metod == 3)
                {
                    array.DeleteDublicates();
                }
                if (metod == 4)
                {
                    Console.WriteLine(array.GetAverage());
                }
            }

        }
        else if (answer == 2)
        {
            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Сколько столбцов вы хотите?");
            int columns = int.Parse(Console.ReadLine());

            Console.WriteLine("Вы хотите заполнить массив самостоятельно?");
            Console.WriteLine("1 - Да, 2 - Нет");
            int fill = int.Parse(Console.ReadLine());

            MatrixArray array = new MatrixArray(rows, columns, fill == 1);

            while (true)
            {
                Console.WriteLine("Какой метод вы хотите вызвать?");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Отобразить");
                Console.WriteLine("2 - Показать среднее арифметическое всех элементов");
                Console.WriteLine("3 - Вывести на консоль существующую матрицу, а затем её же, печатая элементы четных строк в обратном порядке");


                int metod = int.Parse(Console.ReadLine());

                if (metod == 0)
                {
                    break;
                }
                if (metod == 1)
                {
                    array.Display();
                }
                if (metod == 2)
                {
                    array.GetAverage();
                }
                if (metod == 3)
                {
                    array.DisplayReversedEvenRows();
                }
            }
        }
        else if (answer == 3)
        {
            Console.WriteLine("Сколько рядов вы хотите?");
            int rows = int.Parse(Console.ReadLine());

            int[] columns = new int[rows];
            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Сколько элементов вы хотите в ряду с индексом {i} ?");
                columns[i] = int.Parse(Console.ReadLine());
            }


            Console.WriteLine("Вы хотите заполнить массив самостоятельно?");
            Console.WriteLine("1 - Да, 2 - Нет");
            int fill = int.Parse(Console.ReadLine());

            StepArray array = new StepArray(rows, columns, fill == 1);

            while (true)
            {
                Console.WriteLine("Какой метод вы хотите вызвать?");
                Console.WriteLine("0 - Выйти");
                Console.WriteLine("1 - Отобразить");
                Console.WriteLine("2 - Показать среднее арифметическое всех элементов");
                Console.WriteLine("3 - Найти средние значения во всех вложенных массивах");
                Console.WriteLine("4 - Изменить все четные по значению элементы массива на произведения их индексов");


                int metod = int.Parse(Console.ReadLine());

                if (metod == 0)
                {
                    break;
                }
                if (metod == 1)
                {
                    array.Display();
                }
                if (metod == 2)
                {
                    Console.WriteLine(array.GetAverage());
                }
                if (metod == 3)
                {
                    float[] averages = array.GetAverageInRows();
                    for (int i = 0; i < rows; i++)
                    {
                        Console.WriteLine($"{i}: {averages[i]}");
                    }
                }
                if (metod == 4)
                {
                    array.ChangeEvenNumbers();
                }
            }
        }
    }


}
