using System;
namespace OP_L6
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Выполнил Москалев А.А., ученик группы 6102-020302D");

            bool key = true;
            while (key)
            {
                Console.WriteLine("Выберете пункт меню");
                Console.WriteLine("1 - Cортировки");
                Console.WriteLine("2 - Матрица");
                Console.WriteLine("3 - Ступенчатые массивы");
                Console.WriteLine("0 - Выйти");

                string menu = Console.ReadLine();

                switch (menu)
                {
                    case "1":
                        Console.Write("Введите размерность массива: ");
                        int k = int.Parse(Console.ReadLine());
                        ArraySorting Sort = new ArraySorting(k);
                        Console.WriteLine("Заполните массив");
                        Sort.Filling();

                        bool key1 = true;
                        while (key1)
                        {
                            Console.WriteLine("Выберете пункт меню");
                            Console.WriteLine("1 - Сортировка пузырьком");
                            Console.WriteLine("2 - Сортировка Шелла");
                            Console.WriteLine("3 - Сортировка выбором");
                            Console.WriteLine("0 - Предыдущий пункт меню");

                            string menu1 = Console.ReadLine();

                            switch (menu1)
                            {
                                case "1":
                                    Console.WriteLine("Было");
                                    Sort.Info();
                                    Sort.BubbleSort();
                                    Console.WriteLine("Стало");
                                    Sort.Info();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Было");
                                    Sort.Info();
                                    Sort.ShellSort();
                                    Console.WriteLine("Стало");
                                    Sort.Info();
                                    Console.ReadLine();
                                    break;

                                case "3":
                                    Console.WriteLine("Было");
                                    Sort.Info();
                                    Sort.SelectionSort();
                                    Console.WriteLine("Стало");
                                    Sort.Info();
                                    Console.ReadLine();
                                    break;

                                case "0":
                                    key1 = false;
                                    break;

                                case "default":
                                    Console.WriteLine("Повторите ввод");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Console.WriteLine("Введите количество строк матрицы");
                        int m = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество столбцов матрицы");
                        int n = int.Parse(Console.ReadLine());
                        MyArray arr = new MyArray(m, n);
                        arr.Filling();

                        bool key2 = true;
                        while (key2)
                        {                        
                            Console.WriteLine("Выберете пункт меню");
                            Console.WriteLine("1 - Сортировка по возрастанию");
                            Console.WriteLine("2 - Сортировка по убыванию");
                            Console.WriteLine("0 - Предыдущий пункт меню");

                            string menu1 = Console.ReadLine();

                            switch (menu1)
                            {
                                case "1":
                                    Console.WriteLine("Было");
                                    arr.Info();
                                    arr.BubbleSortUp();
                                    Console.WriteLine("Стало");
                                    arr.Info();
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.WriteLine("Было");
                                    arr.Info();
                                    arr.BubbleSortDown();
                                    Console.WriteLine("Стало");
                                    arr.Info();
                                    Console.ReadLine();
                                    break;

                                case "0":
                                    key2 = false;
                                    break;

                                case "default":
                                    Console.WriteLine("Повторите ввод");
                                    break;
                            }
                        }
                        break;

                    case "3":

                        Console.Write("Ввеите колличество строк массива: ");
                        int line = int.Parse(Console.ReadLine());
                        Console.WriteLine("Введите количество столбцов матрицы");
                        int[] column = new int[line];
                        for (int i = 0; i < line; i++)
                        {
                            Console.Write($"Введите колличество столбцов в строке {i}: ");
                            column[i] = int.Parse(Console.ReadLine());
                        }
                        StepArray sarr = new StepArray(line,column);
                        sarr.Filling();
                        Console.WriteLine();
                        Console.WriteLine("До сортировки");
                        sarr.Info();
                        sarr.StepSort();
                        Console.WriteLine("После сортировки");
                        sarr.Info();
                        Console.ReadLine();
                        break;

                    case "0":
                        key = false;
                        break;

                    case "default":
                        Console.WriteLine("Повторите ввод");
                        break;
                }
            }



        }
    }
}

