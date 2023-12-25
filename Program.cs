using System;

namespace Exam2
{
    internal class Program
    {
        static void Main()
        {
            Console.Title = "Действия над массивом";
            Random random = new Random();
            Console.Write("Строки: ");
            int row = Convert.ToInt32(Console.ReadLine());
            Console.Write("Столбцы: ");
            int column = Convert.ToInt32(Console.ReadLine());
            Console.Write("От: ");
            int from = Convert.ToInt32(Console.ReadLine());
            Console.Write("До: ");
            int to = Convert.ToInt32(Console.ReadLine());
            int[,] arrayStart = new int[row, column];
            for (int i = 0; i < arrayStart.GetLength(0); i++)
            {
                for (int j = 0; j < arrayStart.GetLength(1); j++)
                {
                    arrayStart[i, j] = random.Next(from, to);
                }
            }
            Array array = new Array(arrayStart);
            array.Start();
        }
    }
}
