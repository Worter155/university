bool key1 = true;
while (key1)
{
    Console.WriteLine("Выберете задание:");
    Console.WriteLine("1-Матрицы");
    Console.WriteLine("2-Двоичная система счисления");
    Console.WriteLine("3-Завершить программу");
    string menu1 = Console.ReadLine();

    switch (menu1)
    {
        case "1":
            int n = 11;
            while (n > 10 && n > 0)
            {
                Console.Write("Введите размерность для двух квадратных матриц(от 1 до 10) ");
                n = int.Parse(Console.ReadLine());
            }
            int[,] arr1 = new int[n, n];
            int[,] arr2 = new int[n, n];
            Console.WriteLine("Заполните первую матрицу");
            int k = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите {k} элемент матрицы ");
                    k++;
                    arr1[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Заполните вторую матрицу");
            k = 1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Введите {k} элемент матрицы ");
                    k++;
                    arr2[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("");

            bool key2 = true;
            while (key2)
            {
                Console.WriteLine("Выберете пункт меню:");
                Console.WriteLine("1-Сложение матриц");
                Console.WriteLine("2-Вычитание матриц");
                Console.WriteLine("3-Умножение матриц");
                Console.WriteLine("4-Умножение матриц на число");
                Console.WriteLine("5-Сравнение матриц на равенство");
                Console.WriteLine("6-Выбрать другое задание");
                string menu2 = Console.ReadLine();

                switch (menu2)
                {
                    case "1":
                        Addition(arr1, arr2, n);
                        break;

                    case "2":
                        Difference(arr1, arr2, n);
                        break;

                    case "3":
                        Multiply(arr1, arr2, n);
                        break;

                    case "4":
                        MulByNum(arr1, arr2, n);
                        break;

                    case "5":
                        Equality(arr1, arr2, n);
                        break;

                    case "6":
                        Console.WriteLine("");
                        key2 = false;
                        break;

                    default:
                        Console.WriteLine("Повторите ввод");
                        Console.WriteLine("");
                        break;
                }
            }
            break;

        case "2":
            Binary();
            break;

        case "3":
            key1 = false;
            break;

        default:
            Console.WriteLine("Повторите ввод");
            Console.WriteLine("");
            break;
    }
}






//--------------------Сложение----------------------
static void Addition(int[,] a1, int[,] a2, int n)
{
    int[,] a3 = new int[n,n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a3[i, j] = a1[i, j] + a2[i, j];
        }
    }

    Console.WriteLine("Первая матрица");
    for(int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a1[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a2[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Cумма матриц");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a3[i, j] + " ");
        }
        Console.WriteLine("\n");
    }
    Console.ReadLine();
}

//--------------------Вычитание----------------------
static void Difference(int[,] a1, int[,] a2, int n)
{
    int[,] a3 = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            a3[i, j] = a1[i, j] - a2[i, j];
        }
    }

    Console.WriteLine("Первая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a1[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a2[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Разность матриц");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a3[i, j] + " ");
        }
        Console.WriteLine("\n");
    }
    Console.ReadLine();
}


//--------------------Умножение----------------------
static void Multiply(int[,] a1, int[,] a2, int n)
{
    int[,] a3 = new int[n, n];
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int g = 0; g < n; g++)
            {
                a3[i, j] += a1[i, g] * a2[g, j];
            }
        }
    }

    Console.WriteLine("Первая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a1[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a2[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Произведение матриц");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a3[i, j] + " ");
        }
        Console.WriteLine("\n");
    }
    Console.ReadLine();
}

//--------------------Умножение на число----------------------
static void MulByNum(int[,] a1, int[,] a2, int n)
{
    Console.Write("Введите число, на которое нужно умножить матрицы ");
    int k = int.Parse(Console.ReadLine());

    Console.WriteLine("Первая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a1[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a2[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine($"Первая матрица, умноженная на {k}");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(k * a1[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine($"Вторая матрица, умноженная на {k}");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(k * a2[i, j] + " ");
        }
        Console.WriteLine("\n");
    }
    Console.ReadLine();
}


//--------------------Сравнение----------------------
static void Equality(int[,] a1, int[,] a2, int n)
{
    int k = 0;
    Console.WriteLine("Первая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a1[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    Console.WriteLine("Вторая матрица");
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            Console.Write(a2[i, j] + " ");
        }
        Console.WriteLine("\n");
    }

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (a1[i, j] == a2[i, j])
            {
                k += 1;
            }
            else
            {

            }
        }
    }
    if (k == n*n)
    {
        Console.WriteLine("Матрицы равны");
        Console.WriteLine("");
    }
    else
    {
        Console.WriteLine("Матрицы не равны");
        Console.WriteLine("");
    }
    Console.ReadLine();
}

//--------------------Система счисления----------------------
static void Binary()
{
    int n;
    int[] b = new int[12];
    int i = 0;
    int v;
    Console.WriteLine("Введите число для перевода в двоичную систему");
    n = int.Parse(Console.ReadLine());
    int m = n;
    while (m > 0)
    {
        b[i] = m % 2;
        i++;
        m /= 2;
    }
    Console.WriteLine("Начальное число");
    for (int j = b.Length-1; j >= 0; j--)
    {
        Console.Write(b[j]);
    }
    Console.WriteLine("");
    Console.WriteLine(n);

    for (int j = 0; j < 3; j++)
    {
        v = b[j];
        b[j] = b[j + 6];
        b[j + 6] = v;
    }
    double r = 0;
    double x;
    double y;
    Console.WriteLine("Конечное число");
    for (int j = b.Length - 1; j >= 0; j--)
    {
        x = j;
        y = b[j];
        r += y * Math.Pow(2, x);
        Console.Write(b[j]);
    }
    Console.WriteLine("");
    Console.WriteLine(r);
    Console.ReadLine();
}