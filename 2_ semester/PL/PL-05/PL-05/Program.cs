#pragma warning disable SYSLIB0011
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Runtime.Serialization.Formatters.Binary;

namespace PL_05
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Лабораторная работа No5\nВыполнил студент группы 6102 Москалев Андрей");
            while (true)
            {
                Console.WriteLine("\nВыберите пункт меню: ");
                Console.WriteLine("1-ArrayVector\n2-Vectors\n3-LinkedListVector\n4-Сложить вектора разных типов\n5-Масиив векторов\n6-Потоки\n0-Выход\n");

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
                    case "4":
                        Task4();
                        break;
                    case "5":
                        Task5();
                        break;
                    case "6":
                        Task6();
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
                        Console.WriteLine(av.ToString());
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(av.ToString());
                        Console.WriteLine(string.Format("{0:f3}", av.GetNorm()));
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Количетво координат: " + av.Length);
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
                        Console.WriteLine(av1.ToString());
                        Console.WriteLine("Второй вектор:");
                        Console.WriteLine(av2.ToString());
                        Console.WriteLine("Сумма векторов:");
                        Vectors.Sum(av1, av2).ToString();
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("Первый вектор:");
                        Console.WriteLine(av1.ToString());
                        Console.WriteLine("Второй вектор:");
                        Console.WriteLine(av2.ToString());
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
                        Console.WriteLine(av1.ToString());
                        Console.WriteLine("Умноженный вектор:");
                        Vectors.MultNumber(av1, k).ToString();
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Исходный вектор:");
                        Console.WriteLine(av1.ToString());
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
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine("Попробуйте еще раз");
                    f01 = true;
                }
            }
            Console.WriteLine("Заполните сисок");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} элемент: ");
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
                        Console.WriteLine(llv.ToString());
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine(string.Format("{0:f3}", llv.GetNorm()));
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Количетво координат: " + llv.Length);
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.Write("Введите значение координаты: ");
                        int p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Было");
                        Console.WriteLine(llv.ToString());
                        llv.AddToStart(p);
                        Console.WriteLine("Стало");
                        Console.WriteLine(llv.ToString());
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.Write("Введите значение координаты: ");
                        p = int.Parse(Console.ReadLine());
                        Console.WriteLine("Было");
                        Console.WriteLine(llv.ToString());
                        llv.AddToEnd(p);
                        Console.WriteLine("Стало");
                        Console.WriteLine(llv.ToString());
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
                                Console.WriteLine(llv.ToString());
                                llv.Add(index - 1, p);
                                Console.WriteLine("Стало");
                                Console.WriteLine(llv.ToString());
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
                        Console.WriteLine(llv.ToString());
                        llv.RemoveHead();
                        Console.WriteLine("Стало");
                        Console.WriteLine(llv.ToString());
                        Console.ReadLine();
                        break;
                    case "9":
                        Console.WriteLine("Было");
                        Console.WriteLine(llv.ToString());
                        llv.RemoveEnd();
                        Console.WriteLine("Стало");
                        Console.WriteLine(llv.ToString());
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
                                Console.WriteLine(llv.ToString());
                                llv.Remove(index - 1);
                                Console.WriteLine("Стало");
                                Console.WriteLine(llv.ToString());
                                f03 = false;
                                Console.ReadLine();
                            }
                            catch (Exception ex)
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
        static void Task4()
        {
            int n = -1;
            bool fl = true;
            Console.Write("Введите количество координат для ArrayVector: ");
            while (n <= 0 || fl)
            {
                n = int.Parse(Console.ReadLine());
                fl = false;
                if (n <= 0)
                {
                    Console.WriteLine("Массив такого размера не существует. Повторите ввод");
                    fl = true;
                }
            }
            ArrayVector av = new ArrayVector(n);
            Console.WriteLine("Заполните массив ");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} координату: ");
                av[i] = int.Parse(Console.ReadLine());
            }

            n = 0;
            bool f01 = true;
            Console.Write("Введите количество координат для односвязного списка: ");
            while (n <= 0 || f01)
            {
                n = int.Parse(Console.ReadLine());
                f01 = false;
                if (n <= 0)
                {
                    Console.WriteLine("Массив такого размера не существует. Повторите ввод");
                    f01 = true;
                }
            }
            LinkedListVector llv = new(n);
            Console.WriteLine("Заполните список");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Введите {i + 1} элемент: ");
                llv[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine();
            while (true)
            {
                Console.WriteLine("\nВыберите пункт меню: ");
                Console.WriteLine("1-Сложение\n2-Скалярное произведение\n3-Умножение на число\n4-Длина статическая\n0-Выход\n");

                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("ArrayVector");
                        Console.WriteLine(av.ToString());
                        Console.WriteLine("Односвязный список");
                        Console.WriteLine(llv.ToString());
                        Console.WriteLine("Сумма");
                        IVectorable res = Vectors.Sum(av, llv);
                        Console.WriteLine(res.ToString());
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine("ArrayVector");
                        Console.WriteLine(av.ToString());
                        Console.WriteLine("Односвязный список");
                        Console.WriteLine(llv.ToString());
                        Console.WriteLine("Скалярное произведение");
                        int p = Vectors.Scalar(av, llv);
                        Console.WriteLine(p);
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.Write("Введите число: ");
                        int k = int.Parse(Console.ReadLine());
                        Console.WriteLine("ArrayVector");
                        Console.WriteLine(av.ToString());
                        Console.WriteLine("Умножение k на ArrayVector");
                        IVectorable mul1 = Vectors.MultNumber(av, k);
                        Console.WriteLine(mul1);
                        Console.WriteLine("Односвязный список");
                        Console.WriteLine(llv.ToString());
                        Console.WriteLine("Умножение k на список");
                        IVectorable mul2 = Vectors.MultNumber(llv, k);
                        Console.WriteLine(mul2);
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("ArrayVector");
                        Console.WriteLine(av.ToString());
                        Console.WriteLine("Умножение k на ArrayVector");
                        double dl1 = Vectors.GetNormSt(av);
                        Console.WriteLine(string.Format("{0:f3}", dl1));
                        Console.WriteLine("Односвязный список");
                        Console.WriteLine(llv.ToString());
                        Console.WriteLine("Умножение k на список");
                        double dl2 = Vectors.GetNormSt(llv);
                        Console.WriteLine(string.Format("{0:f3}", dl2));
                        Console.ReadLine();
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

        static void Task5()
        {
            Console.Write("Введите длину массива: ");
            int l = int.Parse(Console.ReadLine());
            while (l < 0)
            {
                Console.WriteLine("Длина должна быть больше 0.Повторите ввод");
                l = int.Parse(Console.ReadLine());
            }
            IVectorable[] vectors = new IVectorable[l];
            Console.WriteLine("Заполните массив");
            int count = 0;
            while (count < l)
            {
                Console.WriteLine("1-Добавить ArrayVector\n2-Добавить LinkedListVector");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите количество координат");
                        int l1 = int.Parse(Console.ReadLine());
                        while (l1 < 0)
                        {
                            Console.WriteLine("Длина должна быть больше 0.Повторите ввод");
                            l1 = int.Parse(Console.ReadLine());
                        }

                        ArrayVector av = new ArrayVector(l1);

                        for (int i = 0; i < av.Length; i++)
                        {
                            Console.Write($"{i + 1} координата: ");
                            av[i] = int.Parse(Console.ReadLine());
                        }
                        vectors[count] = av;
                        count++;
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Введите количество координат");
                        int l2 = int.Parse(Console.ReadLine());
                        while (l2 < 0)
                        {
                            Console.WriteLine("Длина должна быть больше 0.Повторите ввод");
                            l2 = int.Parse(Console.ReadLine());
                        }

                        LinkedListVector llv = new LinkedListVector(l2);

                        for (int i = 0; i < llv.Length; i++)
                        {
                            Console.Write($"{i + 1} координата: ");
                            llv[i] = int.Parse(Console.ReadLine());
                        }
                        vectors[count] = llv;
                        count++;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }

            while (true)
            {
                Console.WriteLine("\nВыберите действие:\n1-Найти минимальный по кол-ву координат\n2-Найти максимальный по кол-ву координат\n3-Отсортировать массив\n4-Клонировать\n5-Сравнить с помощью Equals\n6-Сравнить с помощью GetHashCode\n0-Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        IVectorable min = vectors[0];
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            if (min.CompareTo(vectors[i]) < 0)
                            {
                                min = vectors[i];
                            }
                        }

                        Console.WriteLine("Все вектора массива");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                        Console.WriteLine("Минимальные вектора");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            if (min.Length == vectors[i].Length)
                            {
                                Console.WriteLine(vectors[i].ToString());
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "2":
                        IVectorable max = vectors[0];
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            if (max.CompareTo(vectors[i]) > 0)
                            {
                                max = vectors[i];
                            }
                        }
                        Console.WriteLine("Все вектора массива");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                        Console.WriteLine("Максимальный вектор");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            if (max.Length == vectors[i].Length)
                            {
                                Console.WriteLine(vectors[i].ToString());
                            }
                        }
                        Console.ReadLine();
                        break;
                    case "3":
                        Console.WriteLine("Массив до сортировки");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString() + " Модуль: " + vectors[i].GetNorm());
                        }

                        Array.Sort(vectors, new Comparer());

                        Console.WriteLine("Массив после сортировки");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString() + " Модуль: " + vectors[i].GetNorm());
                        }
                        Console.ReadLine();
                        break;
                    case "4":
                        Console.WriteLine("Все вектора массива");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                        Console.Write("Введите номер вектора, который хотите клонировать: ");
                        int k = int.Parse(Console.ReadLine()) - 1;
                        while (k < 0 || k > vectors.Length - 1)
                        {
                            Console.WriteLine("Повторите ввод");
                            k = int.Parse(Console.ReadLine()) - 1;
                        }
                        IVectorable cl = (IVectorable)vectors[k].Clone();
                        Console.WriteLine("Клонируемый вектор");
                        Console.WriteLine(vectors[k].ToString());
                        Console.WriteLine("Клонированный вектор");
                        Console.WriteLine(cl.ToString());
                        Console.Write("Введите номер координаты для изменения: ");
                        int e = int.Parse(Console.ReadLine()) - 1;
                        while (e < 0 || e > cl.Length - 1)
                        {
                            Console.WriteLine("Повторите ввод");
                            e = int.Parse(Console.ReadLine()) - 1;
                        }
                        Console.Write("Введите новое значение: ");
                        cl[e] = int.Parse(Console.ReadLine());
                        Console.WriteLine("Клонируемый вектор");
                        Console.WriteLine(vectors[k].ToString());
                        Console.WriteLine("Клонированный вектор");
                        Console.WriteLine(cl.ToString());
                        Console.ReadLine();
                        break;
                    case "5":
                        Console.WriteLine("Все вектора массива");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                        Console.WriteLine("Введите номер первого вектора: ");
                        int n = int.Parse(Console.ReadLine()) - 1;
                        while (n < 0 || n > vectors.Length - 1)
                        {
                            Console.WriteLine("Повторите ввод");
                            n = int.Parse(Console.ReadLine()) - 1;
                        }
                        Console.WriteLine("Введите номер второго вектора: ");
                        int m = int.Parse(Console.ReadLine()) - 1;
                        while (m < 0 || m > vectors.Length - 1)
                        {
                            Console.WriteLine("Повторите ввод");
                            m = int.Parse(Console.ReadLine()) - 1;
                        }
                        Console.WriteLine("Первый вектор");
                        Console.WriteLine(vectors[n].ToString());
                        Console.WriteLine("Второй вектор");
                        Console.WriteLine(vectors[m].ToString());
                        if (vectors[n].Equals(vectors[m])) Console.WriteLine("Вектора равны");
                        else Console.WriteLine("Вектора не равны");
                        Console.ReadLine();
                        break;
                    case "6":
                        Console.WriteLine("Все вектора массива");
                        for (int i = 0; i < vectors.Length; i++)
                        {
                            Console.WriteLine(vectors[i].ToString());
                        }
                        Console.WriteLine("Введите номер первого вектора: ");
                        int n1 = int.Parse(Console.ReadLine()) - 1;
                        while (n1 < 0 || n1 > vectors.Length - 1)
                        {
                            Console.WriteLine("Повторите ввод");
                            n1 = int.Parse(Console.ReadLine()) - 1;
                        }
                        Console.WriteLine("Введите номер второго вектора: ");
                        int m1 = int.Parse(Console.ReadLine()) - 1;
                        while (m1 < 0 || m1 > vectors.Length - 1)
                        {
                            Console.WriteLine("Повторите ввод");
                            m1 = int.Parse(Console.ReadLine()) - 1;
                        }
                        Console.WriteLine("Первый вектор");
                        Console.WriteLine(vectors[n1].ToString());
                        Console.WriteLine("Второй вектор");
                        Console.WriteLine(vectors[m1].ToString());
                        if (vectors[n1].GetHashCode() == vectors[m1].GetHashCode()) Console.WriteLine("Вектора равны");
                        else Console.WriteLine("Вектора не равны");
                        Console.ReadLine();
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }

         static void Task6()
        {
            Console.Write("Введите длину массива: ");
            int l = int.Parse(Console.ReadLine());
            while (l < 0)
            {
                Console.WriteLine("Длина должна быть больше 0.Повторите ввод");
                l = int.Parse(Console.ReadLine());
            }
            IVectorable[] vectors = new IVectorable[l];
            Console.WriteLine("Заполните массив");
            int count = 0;
            while (count < l)
            {
                Console.WriteLine("1-Добавить ArrayVector\n2-Добавить LinkedListVector");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Введите количество координат");
                        int l1 = int.Parse(Console.ReadLine());
                        while (l1 < 0)
                        {
                            Console.WriteLine("Длина должна быть больше 0.Повторите ввод");
                            l1 = int.Parse(Console.ReadLine());
                        }

                        ArrayVector av = new ArrayVector(l1);

                        for (int i = 0; i < av.Length; i++)
                        {
                            Console.Write($"{i + 1} координата: ");
                            av[i] = int.Parse(Console.ReadLine());
                        }
                        vectors[count] = av;
                        count++;
                        Console.WriteLine();
                        break;
                    case "2":
                        Console.WriteLine("Введите количество координат");
                        int l2 = int.Parse(Console.ReadLine());
                        while (l2 < 0)
                        {
                            Console.WriteLine("Длина должна быть больше 0.Повторите ввод");
                            l2 = int.Parse(Console.ReadLine());
                        }

                        LinkedListVector llv = new LinkedListVector(l2);

                        for (int i = 0; i < llv.Length; i++)
                        {
                            Console.Write($"{i + 1} координата: ");
                            llv[i] = int.Parse(Console.ReadLine());
                        }
                        vectors[count] = llv;
                        count++;
                        Console.WriteLine();
                        break;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }

            while (true)
            {
                Console.WriteLine("1-Запись в байтовый поток\n2-Чтение из байтового потока\n3-Запись в символьный поток\n4-Чтение из символьного потока\n5-Сериализация векторов\n0-Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        try
                        {
                            
                            Console.WriteLine("Запись векторов в байтовый поток");
                            Console.WriteLine();
                            FileStream file1 = new FileStream("/Users/andrew-moskalev/Projects/PL-05/PL-05/test.dat", FileMode.Truncate, FileAccess.Write);
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                Vectors.OutputVector(vectors[i], file1);
                            }
                            file1.Close();
                            Console.WriteLine("Вектора успешно сохранены в файл test.dat");
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }
                        break;
                    case "2":
                        try
                        {
                            FileStream file2 = new FileStream("/Users/andrew-moskalev/Projects/PL-05/PL-05/test.dat", FileMode.Open, FileAccess.Read);
                            IVectorable[] vector = Vectors.InputVector(file2);
                            Console.WriteLine("Чтение векторов с файла test.dat через байтовый поток");
                            Console.WriteLine();
                            for (int i = 0; i < vector.Length; i++)
                            {
                                Console.WriteLine(vector[i].ToString());
                            }
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }
                        break;
                    case "3":
                        try
                        {
                            
                            Console.WriteLine("Запись векторов в символьный поток");
                            StreamWriter file3 = new StreamWriter("/Users/andrew-moskalev/Projects/PL-05/PL-05/test.txt", false);
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                Vectors.WriteVector(vectors[i], file3);
                            }         
                            file3.Close();
                            Console.WriteLine("Вектора успешно сохранены в файл test.txt");
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }
                        break;
                    case "4":
                        try
                        {
                            StreamReader file4 = new StreamReader("/Users/andrew-moskalev/Projects/PL-05/PL-05/test.txt");
                            IVectorable[] vector = Vectors.ReadVector(file4);
                            Console.WriteLine("Чтение векторов с файла test.txt через символьный поток");
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                Console.WriteLine(vector[i].ToString());
                            }
                            
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }
                        break;
                    case "5":
                        try
                        {
                            
                            BinaryFormatter binFormat = new BinaryFormatter();
                            FileStream stream = new FileStream("/Users/andrew-moskalev/Projects/PL-05/PL-05/test.bin", FileMode.Truncate, FileAccess.Write);
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                binFormat.Serialize(stream, vectors[i]);
                            }
                                      
                            Console.WriteLine("Вектора успешно сохранены в файл test.bin с помощью сериализации");
                            FileStream stream1 = new FileStream("/Users/andrew-moskalev/Projects/PL-05/PL-05/test.bin", FileMode.Open, FileAccess.Read);
                            IVectorable[] vectors2 = new IVectorable[vectors.Length];
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                vectors2[i] = (IVectorable)binFormat.Deserialize(stream1);
                            }
                            
                            Console.WriteLine("Исходные вектора:");
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                Console.WriteLine(vectors[i].ToString());
                            }
                            
                            Console.WriteLine("Прочитанные с потока вектора:");
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                Console.WriteLine(vectors2[i].ToString());
                            }
                            
                            int s = 0;
                            for (int i = 0; i < vectors.Length; i++)
                            {
                                if (vectors[i].Equals(vectors2[i])) s+=1;
                                else Console.WriteLine($"Вектора {i+1} не равны");
                            }
                            if (s==vectors.Length) Console.WriteLine("Все вектора равны");
                            Console.ReadLine();
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Ошибка: " + e.Message);
                        }
                        break;
                    case "0":
                        return;
                    default:
                        Console.WriteLine("Такого пункта меню нет. Повторите ввод");
                        break;
                }
            }
        }
    }
}