using System;
using PL_02;

namespace PL_02
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа No1\nВыполнил студент группы 6102 Москалев Андрей");
            while (true)
            {
                Console.WriteLine("\nВыберите пункт меню: ");
                Console.WriteLine("1-ArrayVector\n2-Vectors\n3-LinkedListVector\n0-Выход\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Task1();
                        break;
                    case "2":
                        Task2();
                        break;
                    case "3":
                        Task3();
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
                Console.WriteLine("\nВыберите действие:\n1-Изменить значение координаты\n2-Показать координаты вектора\n3-Получть модуль вектора\n4-Количетво координат\n0-Выход ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите номер координаты");
                        int m = -1;
                        bool fl1 = true;
                        while (m > n + 1 || m < 0 || fl1)
                        {
                            try
                            {
                                m = int.Parse(Console.ReadLine());
                                if (m > n + 1 || m < 0)
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
                        Console.WriteLine("Количетво координат: "+av.Len);
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

        static void ShowLLV(LinkedListVector llv)
        {
            for (int i = 0; i < llv.Len; i++)
            {
                Console.Write(llv[i]+" ");
            }
            Console.WriteLine();
        }

        static void Task3()
        {
            int n = 0;
            LinkedListVector llv = new();
            bool f01 = true;
            while (f01)
            {
                try
                {
                    Console.Write("Введите длину списка: ");
                    n = int.Parse(Console.ReadLine());
                    llv = new(n);
                    f01 = false;
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Попробуйте еще раз");
                    f01 = true;
                }
            }
            Console.WriteLine("Заполните сисок");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i+1} элемент: ");
                llv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();

            while (true)
            {
                Console.WriteLine("\nВыберите действие:\n1-Изменить значение координаты\n2-Показать координаты вектора\n3-Получть модуль вектора\n4-Количетво координат\n5-Добавить элемент в начало списка\n6-Добавить элемент в конец списка\n7-Добавить элемент в заданное место\n8-Удалить элемент из начала списка\n9-Удалить элемент из конца списка\n10-Удалить заданный элемент списка\n0-Выход ");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите номер координаты");
                        int m = -1;
                        bool fl1 = true;
                        while (fl1)
                        {
                            try
                            {
                                m = int.Parse(Console.ReadLine());
                                fl1 = false;
                                bool f = true;
                                while (f)
                                {
                                    try
                                    {
                                        Console.WriteLine("Введите целое число");
                                        llv[m - 1] = int.Parse(Console.ReadLine());
                                        f = false;
                                    }
                                    catch (FormatException)
                                    {
                                        Console.WriteLine("Вы ввели неверный формат, попробуйте ещё раз");
                                        f = true;
                                    }
                                }
                                
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Введите номер координаты");
                                fl1 = true;
                            }
                        }
                        break;
                    case "2":
                        ShowLLV(llv);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(string.Format("{0:f3}", llv.GetNorm()));
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Количетво координат: " + llv.Len);
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Введите значение координаты: ");
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Было");
                        ShowLLV(llv);
                        llv.AddToStart(p);
                        Console.WriteLine("Стало");
                        ShowLLV(llv);
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Write("Введите значение координаты: ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Было");
                        ShowLLV(llv);
                        llv.AddToEnd(p);
                        Console.WriteLine("Стало");
                        ShowLLV(llv);
                        Console.ReadLine();
                        break;
                    case "7":
                        bool f02 = true;
                        int index = 0;
                        while (f02)
                        {
                            try
                            {
                                Console.WriteLine("Введите номер координаты");
                                index = int.Parse(Console.ReadLine());
                                Console.Write("Введите значение координаты: ");
                                p = int.Parse(Console.ReadLine());
                                Console.WriteLine("Было");
                                ShowLLV(llv);
                                llv.Add(index - 1, p);
                                Console.WriteLine("Стало");
                                ShowLLV(llv);
                                f02 = false;
                                Console.ReadLine();
                            }
                            catch (Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Попробуйте еще раз");
                                f02 = true;
                            }
                        }
                        break;
                    case "8":
                        Console.WriteLine("Было");
                        ShowLLV(llv);
                        llv.RemoveHead();
                        Console.WriteLine("Стало");
                        ShowLLV(llv);
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.WriteLine("Было");
                        ShowLLV(llv);
                        llv.RemoveEnd();
                        Console.WriteLine("Стало");
                        ShowLLV(llv);
                        Console.ReadLine();
                        break;
                    case "10":
                        bool f03 = true;
                        while (f03)
                        {
                            try
                            {
                                Console.Write("Введите номер координаты: ");
                                index = int.Parse(Console.ReadLine());
                                Console.WriteLine("Было");
                                ShowLLV(llv);
                                llv.Remove(index - 1);
                                Console.WriteLine("Стало");
                                ShowLLV(llv);
                                f03 = false;
                                Console.ReadLine();
                            }
                            catch(Exception ex)
                            {
                                Console.WriteLine(ex.Message);
                                Console.WriteLine("Попробуйте еще раз");
                                f03 = true;
                            }
                        }
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

