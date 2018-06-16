using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPratice_Task_5
{
    /// <summary>
    /// Дана действительная квадратичная матрица порядка 9
    /// Получить целочисленную квадратную матрицу того же порядка,
    ///  в которой элемент равен еденице, 
    ///     если соответствующий ему элемент исходной матрицы больше элемента, 
    ///         расположенного в его строке на главной диагонали,
    ///  и равен нулю в противном случае.
    /// </summary>
    class Program
    {
        static Random random = new Random();
        static void Main(string[] args)
        {
            Console.WriteLine(
                "Получить целочисленную квадратную матрицу того же порядка, в которой элемент равен еденице," +
                "\nесли соответствующий ему элемент исходной матрицы больше элемента, расположенного в его строке на главной диагонали," +
                "\nи равен нулю в противном случае.\n");
            double[,] matrix = new double[9, 9];
            double diag = 0;//Элемент исходной матрицы по диагонали

            Console.WriteLine("Исходная матрица:");
            //Заполнение матрицы
            for (int i = 0; i < matrix.GetLength(0); i++)
                for (int j = 0; j < matrix.GetLength(1); j++)
                    matrix[i, j] = Math.Round(random.NextDouble(), 3);
            //Печать матрицы
            Print(matrix);
            //Выполнение действия над матрицей
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                diag = matrix[i, i];//Получение элемента матрицы
                for (int j = 0; j < matrix.GetLength(1); j++)
                    if (matrix[i, j] < diag)
                        matrix[i, j] = 1;
                    else
                        matrix[i, j] = 0;
            }
            Console.WriteLine("Итоговая матрица:");
            Print(matrix);
            Console.WriteLine("Для выхода введите любую клавишу");
            Console.Read();
        }

        private static void Print(double[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                    Console.Write($" {matrix[i, j],5} ");
                Console.WriteLine();
            }
        }
    }
}
