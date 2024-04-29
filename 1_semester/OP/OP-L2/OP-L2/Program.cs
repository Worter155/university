Console.WriteLine("Лабораторная работа 2, выполнил студент Москалев Андрей");
bool key = true;
while (key)
{
    Console.WriteLine("Введите число:\n1-Таблица значений функции\n2-Серия выстрелов по мишени\n3-Сумма ряда\n4-Завершение программы");
    string menu1 = Console.ReadLine();
    Console.Clear();
    switch (menu1)
    {
        case "1":
            Console.WriteLine("Таблица значений функции");
            double xmin, xmax, dx;
            Console.WriteLine("Введите xmin, xmax и шаг");
            xmin = double.Parse(Console.ReadLine());
            xmax = double.Parse(Console.ReadLine());
            dx = double.Parse(Console.ReadLine());
            Console.WriteLine("\tx\t\ty\n");
            for (double x1 = xmin; x1 <= xmax; x1 += dx)
            {
                double y;

                if (x1 >= -7 && x1 <= 3)
                {
                    if (x1 <= -6)
                    {
                        y = 2;
                    }
                    else if (x1 > -6 && x1 <= -2)
                    {
                        y = ((x1 + 2) / 4);
                    }
                    else if (x1 > -2 && x1 <= 0)
                    {
                        y = (-(Math.Sqrt(4 - Math.Pow((x1 + 2), 2))) + 2);
                    }
                    else if (x1 > 0 && x1 <= 2)
                    {
                        y = Math.Sqrt(4 - Math.Pow(x1, 2));
                    }
                    else
                    {
                        y = 2 - x1;
                    }
                    Console.WriteLine("{0,10:0.0} {1,16:0.00}", x1, y);
                }
                else
                {
                    Console.WriteLine("{0,10:0.0}\tТакого y не существует",x1);
                } 
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            break;
        case "2":
            Console.WriteLine("Серия выстрелов по мишени");
            for (int i = 0; i < 11; i++)
            {
                Console.Write("Введите x:");

                double x2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите y:");
                double y = Convert.ToDouble(Console.ReadLine());

                if ((((y >= Math.Pow((x2 - 2), 2) - 3) && (x2 >= Math.Abs(y)) && (y >= 0)) || ((y >= Math.Pow((x2 - 2), 2) - 3) && (x2 <= Math.Abs(y)) && (y <= 0))))
                {
                    Console.WriteLine("Вы попали в мишень!");
                }
                else
                {
                    Console.WriteLine("Вы не попали в мишень!");
                }
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            break;
        case "3":
            Console.WriteLine("Сумма ряда");
            double accuracy, a, x3, s = Math.PI / 2;
            Console.Write("Введите заданную точность погрешности: ");
            accuracy = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите x>1: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            int n = 0;
            if (x3 > 1)
            {
                do
                {
                    a = Math.Pow((-1), n + 1) / ((2 * n + 1) * Math.Pow(x3, (2 * n + 1)));
                    s += a;
                    n++;
                } while (Math.Abs(a) > Math.Abs(accuracy));
                Console.WriteLine("Сумма ряда = " + s);
                Console.WriteLine("Количество членов в ряду = " + n);
            }
            else
            {
                Console.WriteLine("Неверное значение x");
            }
            Console.WriteLine("Для продолжения нажмите Enter");
            Console.ReadLine();
            Console.Clear();
            break;
        case "4":
            Console.WriteLine("Завершение программы");
            key = false;
            break;
        default:
            Console.WriteLine("Повторите ввод");
            break;
    }
}


