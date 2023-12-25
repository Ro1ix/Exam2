using System;

namespace Exam2
{
    internal class Array
    {
        private readonly int[,] array;
        public Array(int[,] arrayStart)
        {
            array = arrayStart;
        }
        public void Start()
        {
            Console.WriteLine("\nМАССИВ\n");
            Info();
            Console.WriteLine($"1. Произведение элементов, квадрат которых меньше 25 = {Square25()}");
            Console.WriteLine($"2. Сумма модулей положительных элементов = {Sum()}");
            Console.WriteLine($"3. Среднее арифметическое модулей отрицательных элементов = {AverageArifmetic()}");
            Console.WriteLine($"4. Среднее геометрическое элементов, у которых оба индекса чётные = {AverageGeometricIndex()}");
            Console.WriteLine($"5. Среднее геометрическое квадратов чётных элементов = {AverageGeometricSquare()}");
            Console.WriteLine($"6. Количество элементов, которые при делении на 4 дают остаток 2 = {Count42()}");
            Console.WriteLine($"7. Произведение элементов, модуль которых лежит в диапазоне [15; 50] = {From15To50()}");
            Console.WriteLine($"8. Количество эелементов, которые без остатка делятся на собственный номер = {CountNumber()}");
        }
        private void Info()
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Convert.ToString(array[i, j]).Length == 5)
                    {
                        Console.Write($"{array[i, j]}   ");
                    }
                    else if (Convert.ToString(array[i, j]).Length == 4)
                    {
                        Console.Write($"{array[i, j]}    ");
                    }
                    else if (Convert.ToString(array[i, j]).Length == 3)
                    {
                        Console.Write($" {array[i, j]}    ");
                    }
                    else if (Convert.ToString(array[i, j]).Length == 2)
                    {
                        Console.Write($" {array[i, j]}     ");
                    }
                    else if (Convert.ToString(array[i, j]).Length == 1)
                    {
                        Console.Write($"  {array[i, j]}     ");
                    }
                }
                Console.WriteLine("\n\n");
            }
        }
        private int Square25()
        {
            int answer = 1;
            bool math = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (Math.Pow(array[i, j], 2) < 25)
                    {
                        answer *= array[i, j];
                        math = true;
                    }
                }
            }
            if (math == false)
            {
                answer = 0;
            }
            return answer;
        }
        private int Sum()
        {
            int answer = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > 0)
                    {
                        answer += array[i, j];
                    }
                }
            }
            return answer;
        }
        private double AverageArifmetic()
        {
            double answer = 0;
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < 0)
                    {
                        answer += Math.Abs(array[i, j]);
                        count++;
                    }
                }
            }
            if (count != 0)
            {
                answer /= count;
            }
            return answer;
        }
        private double AverageGeometricIndex()
        {
            double answer = 1;
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        answer *= array[i, j];
                        count++;
                    }
                }
            }
            if (count > 0 && answer >= 0)
            {
                answer = Math.Pow(answer, 1 / count);
            }
            else
            {
                answer = 0;
            }
            return answer;
        }
        private double AverageGeometricSquare()
        {
            double answer = 1;
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 2 == 0)
                    {
                        answer *= Math.Pow(array[i, j], 2);
                        count++;
                    }
                }
            }
            if (count > 0)
            {
                answer = Math.Pow(answer, 1 / count);
            }
            else
            {
                answer = 0;
            }
            return answer;
        }
        private int Count42()
        {
            int answer = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % 4 == 2)
                    {
                        answer++;
                    }
                }
            }

            return answer;
        }
        private int From15To50()
        {
            int answer = 1;
            bool math = false;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if ((array[i, j] >= 15 && array[i, j] <= 50) || (array[i, j] <= -15 && array[i, j] >= -50))
                    {
                        answer *= array[i, j];
                        math = true;
                    }
                }
            }
            if (math == false)
            {
                answer = 0;
            }
            return answer;
        }
        private int CountNumber()
        {
            int answer = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] % (i + 1) == 0 || array[i, j] % (j + 1) == 0)
                    {
                        answer++;
                    }
                }
            }
            return answer;
        }
    }
}
