using System;
namespace PL_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа No1\nВыполнил студент группы 6102 Москалев Андрей");
            while (true)
            {
                Console.WriteLine("\nВыберите пункт меню: ");
                Console.WriteLine("1-ArrayVector\n2-Vectors\n0-Выход\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "0":
                        Console.Clear();
                        return;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }


        static void ShowVector(ArrayVector av)
        {
            for (int i = 0; i < av.coordArray.Length; i++)
            {
                Console.Write(av[i] + " ");
            }
            Console.WriteLine();
        }



        static void Task1()
        {
            int n = -1;
            bool fl = true;
            Console.WriteLine("Введите количество координат");
            while (n <= 0 || fl)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    fl = false;
                    if (n <= 0)
                    {
                        Console.WriteLine("Массив такого размера не существует. Повторите ввод");
                        fl = true;
                    }
                }
                catch (FormatException) 
                {
                    Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                    fl = true;
                }
            }
            ArrayVector av = new ArrayVector(n);
            Console.WriteLine("Заполните массив ");
            for (int i = 0; i < n; i++)
            {
                bool f = true;
                while (f)
                {
                    try
                    {
                        Console.Write($"Введите {i + 1} координату: ");
                        av[i] = int.Parse(Console.ReadLine());
                        f = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                        f = true;
                    }
                }

            }

            while (true)
            {
                Console.WriteLine("\nВыберите действие:\n1-Изменить значение координаты\n2-Показать координаты вектора\n3-Получть модуль вектора\n4-Посчитать сумму положительных элементов с четными номерами\n5-Посчитать сумму элементов с нечетными номерами и значением меньше среднего\n6-Посчитать произведение четных положительных элементов\n7-Посчитать произведение нечетных элементов, не делящихся на три\n8-Отсортировать массив по возрастанию \n9-Отсортировать массив по убыванию\n0-Выход ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите номер координаты");
                        int m = -1;
                        bool fl1 = true;
                        while (m > n + 1|| m<0 || fl1) 
                        {
                            try
                            {
                                m = int.Parse(Console.ReadLine());
                                if (m > n + 1 || m <0)
                                {
                                    Console.WriteLine("Такой координаты не существует, попробуйте еще раз");
                                    fl1 = true;
                                }

                                else
                                {
                                    fl1 = false;
                                    bool f = true;
                                    while (f)
                                    {
                                        try
                                        {
                                            Console.WriteLine("Введите целое число");
                                            av[m - 1] = int.Parse(Console.ReadLine());
                                            f = false;
                                        }
                                        catch (FormatException)
                                        {
                                            Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                                            f = true;
                                        }
                                    }
                                }
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                                fl1 = true;
                            }
                        }
                        break;

                    case "2":
                        ShowVector(av);
                        Console.ReadLine();
                        break;
                    case "3":
                        ShowVector(av);
                        Console.WriteLine(string.Format("{0:f3}", av.GetNorm()));
                        Console.ReadLine();
                        break;
                    case "4":
                        ShowVector(av);
                        int s = av.SumPositivesFromChetIndex(out int k);
                        if (k == 0)
                        {
                            Console.WriteLine("Таких элеметов нет");
                        }
                        else
                        {
                            Console.WriteLine(s);
                        }
                        Console.ReadLine();
                        break;
                    case "5":
                        ShowVector(av);
                        Console.WriteLine(av.SumLessFromNechetIndex());
                        Console.ReadLine();
                        break;
                    case "6":
                        ShowVector(av);
                        int p = av.MultChet(out int g);
                        if (g == 0)
                        {
                            Console.WriteLine("Таких элеметов нет");
                        }
                        else
                        {
                            Console.WriteLine(p);
                        }
                        Console.ReadLine();
                        break;
                    case "7":
                        ShowVector(av);
                        Console.WriteLine(av.MultNechet());
                        Console.ReadLine();
                        break;
                    case "8":
                        Console.WriteLine("Исходный массив:");
                        ShowVector(av);
                        Console.WriteLine("Отсортированный массив по возрастанию:");
                        av.SortUp();
                        ShowVector(av);
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.WriteLine("Исходный массив:");
                        ShowVector(av);
                        Console.WriteLine("Отсортированный массив по убыванию:");
                        av.SortDown();
                        ShowVector(av);
                        Console.ReadLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Такого пункта в меню нет");
                        break;
                }
            }

        }



        static void Task2()
        {
            int n = -1;
            bool fl1 = true;
            Console.WriteLine("Введите количество координат первого вектора");
            while (n <= 0 || fl1)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    fl1 = false;
                    if (n <= 0)
                    {
                        Console.WriteLine("Массив такого размера не существует. Повторите ввод");
                        fl1 = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                    fl1 = true;
                }
            }

            ArrayVector av1 = new ArrayVector(n);
            Console.WriteLine("Заполните массив ");
            for (int i = 0; i < n; i++)
            {
                bool f = true;
                while (f)
                {
                    try
                    {
                        Console.Write($"Введите {i + 1} координату: ");
                        av1[i] = int.Parse(Console.ReadLine());
                        f = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                        f = true;
                    }
                }
            }
            int m = -1;
            bool fl2 = true;
            Console.WriteLine("Введите количество координат второго вектора");
            while (m <= 0 || fl2)
            {
                try
                {
                    m = int.Parse(Console.ReadLine());
                    fl2 = false;
                    if (m <= 0)
                    {
                        Console.WriteLine("Массив такого размера не существует. Повторите ввод");
                        fl2 = true;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                    fl2 = true;
                }
            }

            ArrayVector av2 = new ArrayVector(m);

            Console.WriteLine("Заполните массив");
            for (int i = 0; i < m; i++)
            {
                bool f = true;
                while (f)
                {
                    try
                    {
                        Console.Write($"Введите {i + 1} координату: ");
                        av2[i] = int.Parse(Console.ReadLine());
                        f = false;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                        f = true;
                    }
                }
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("Выберите действие\n1-Сумма векторов\n2-Скалярное произведение векторов\n3-Умножение на число\n4-Модуль вектора\n0-Выход ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Первый вектор:");
                        ShowVector(av1);
                        Console.WriteLine("Второй вектор:");
                        ShowVector(av2);
                        Console.WriteLine("Сумма векторов:");
                        ShowVector(Vectors.Sum(av1, av2));
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Первый вектор:");
                        ShowVector(av1);
                        Console.WriteLine("Второй вектор:");
                        ShowVector(av2);
                        Console.WriteLine("Скалярное произведение векторов:");
                        Console.WriteLine(Vectors.Scalar(av1, av2));
                        Console.ReadLine();
                        break;
                    case "3":
                        int k = 0;
                        bool fl3 = true;
                        while (fl3)
                        {
                            Console.WriteLine("Введите целое число: ");
                            try
                            {
                                k = int.Parse(Console.ReadLine());
                                fl3 = false;
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                                fl3 = true;
                            }
                        }
                        Console.WriteLine("Исходный вектор:");
                        ShowVector(av1);
                        Console.WriteLine("Умноженный вектор:");
                        ShowVector(Vectors.MultNumber(av1, k));
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Исходный вектор:");
                        ShowVector(av1);
                        Console.WriteLine("Длина вектора:");
                        Console.WriteLine(string.Format("{0:f3}", Vectors.GetNormSt(av1)));
                        Console.ReadLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Такого пункта в меню нет");
                        break;
                }
            }
        }
    }
}

