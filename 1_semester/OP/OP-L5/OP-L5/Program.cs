namespace OP_L5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Лабораторная работа №5. Классы.");
            Console.WriteLine("Выполнил студент группы 6102 Москалев А. А.");
            bool key = true;
            while (key)
            {
                Console.WriteLine("1 - работа с классом Fraction");
                Console.WriteLine("2 - работа с классом FractionSt");
                Console.WriteLine("0 - Завершить программу");
                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Fraction fr1 = new Fraction();
                        Fraction fr2 = new Fraction();
                        Fraction res;

                        Console.WriteLine("Введите первую дробь");
                        Console.Write("Числитель: ");
                        fr1.Numerator = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        fr1.Denominator = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите вторую дробь");
                        Console.Write("Числитель: ");
                        fr2.Numerator = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        fr2.Denominator = int.Parse(Console.ReadLine());

                        /*fr1.Reduction();
                        fr2.Reduction();*/
                        bool key1 = true;
                        while (key1)
                        {
                            Console.WriteLine("1 - К первой дроби прибавить вторую");
                            Console.WriteLine("2 - Из первой дроби вычесть вторую");
                            Console.WriteLine("3 - Первую дробь умножтьб на вторую");
                            Console.WriteLine("4 - Первую дробь поделить на вторую");
                            Console.WriteLine("5 - Статическое сложение");
                            Console.WriteLine("6 - Статическое вычитание");
                            Console.WriteLine("7 - Статическое произведение");
                            Console.WriteLine("8 - Статическое деление");
                            Console.WriteLine("0 - Предыдущий пункт меню");
                            string menu1 = Console.ReadLine();
                            switch (menu1)
                            {
                                case "1":
                                    Console.Write($"При сложении дроби {fr1.Info()} и дробь {fr2.Info()} получается дробь ");
                                    fr1.Add(fr2);
                                    fr1.Reduction();
                                    Console.WriteLine(fr1.Info());
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    Console.Write($"При вычитании из дроби {fr1.Info()} дроби {fr2.Info()} получается дробь ");
                                    fr1.Sub(fr2);
                                    fr1.Reduction();
                                    Console.WriteLine(fr1.Info());
                                    Console.ReadLine();
                                    break;

                                case "3":
                                    Console.Write($"При умножении дроби {fr1.Info()} на дробь {fr2.Info()} получается дробь ");
                                    fr1.Mul(fr2);
                                    fr1.Reduction();
                                    Console.WriteLine(fr1.Info());
                                    Console.ReadLine();
                                    break;

                                case "4":
                                    Console.Write($"При делении дроби {fr1.Info()} на дробь {fr2.Info()} получается дробь ");
                                    fr1.Div(fr2);
                                    fr1.Reduction();
                                    Console.WriteLine(fr1.Info());
                                    Console.ReadLine();
                                    break;

                                case "5":
                                    res = fr1 + fr2;
                                    res.Reduction();
                                    Console.WriteLine($"При сложении дроби {fr1.Info()} и дроби {fr2.Info()} получается дробь {res.Info()}");
                                    Console.ReadLine();
                                    break;

                                case "6":
                                    res = fr1 - fr2;
                                    res.Reduction();
                                    Console.WriteLine($"При вычитании из дроби {fr1.Info()} дроби {fr2.Info()} получается дробь {res.Info()}");
                                    Console.ReadLine();
                                    break;

                                case "7":
                                    res = fr1 * fr2;
                                    res.Reduction();
                                    Console.WriteLine($"При умножении дроби {fr1.Info()} на дробь {fr2.Info()} получается дробь {res.Info()}");
                                    Console.ReadLine();
                                    break;

                                case "8":
                                    res = fr1 / fr2;
                                    res.Reduction();
                                    Console.WriteLine($"При делении дроби {fr1.Info()} на дробь {fr2.Info()} получается дробь {res.Info()}");
                                    Console.ReadLine();
                                    break;


                                case "0":
                                    key1 = false;
                                    break;

                                default:
                                    Console.WriteLine("Повторите ввод");
                                    break;
                            }
                        }
                        break;
                    case "2":
                        Fraction sfr1 = new Fraction();
                        Fraction sfr2 = new Fraction();
                        Fraction sres;

                        Console.WriteLine("Введите первую дробь");
                        Console.Write("Числитель: ");
                        sfr1.Numerator = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        sfr1.Denominator = int.Parse(Console.ReadLine());

                        Console.WriteLine("Введите вторую дробь");
                        Console.Write("Числитель: ");
                        sfr2.Numerator = int.Parse(Console.ReadLine());
                        Console.Write("Знаменатель: ");
                        sfr2.Denominator = int.Parse(Console.ReadLine());

                        /*sfr1.Reduction();
                        sfr2.Reduction();*/

                        bool key2 = true;
                        while (key2)
                        {
                            Console.WriteLine("1 - Статическое сложение");
                            Console.WriteLine("2 - Статическое вычитание");
                            Console.WriteLine("3 - Статическое произведение");
                            Console.WriteLine("4 - Статическое деление");
                            Console.WriteLine("0 - Предыдущий пункт меню");
                            string menu1 = Console.ReadLine();
                            switch (menu1)
                            {
                                
                                case "1":
                                    sres = FractionSt.AddSt(sfr1,sfr2);
                                    sres.Reduction();
                                    Console.WriteLine($"При сложении дроби {sfr1.Info()} и дроби {sfr2.Info()} получается дробь {sres.Info()}");
                                    Console.ReadLine();
                                    break;

                                case "2":
                                    sres = FractionSt.SubSt(sfr1, sfr2);
                                    sres.Reduction();
                                    Console.WriteLine($"При вычитании из дроби {sfr1.Info()} дроби {sfr2.Info()} получается дробь {sres.Info()}");
                                    Console.ReadLine();
                                    break;

                                case "3":
                                    sres = FractionSt.MulSt(sfr1, sfr2);
                                    sres.Reduction();
                                    Console.WriteLine($"При умножении дроби {sfr1.Info()} на дробь {sfr2.Info()} получается дробь {sres.Info()}");
                                    Console.ReadLine();
                                    break;

                                case "4":
                                    sres = FractionSt.DivSt(sfr1, sfr2);
                                    sres.Reduction();
                                    Console.WriteLine($"При делении дроби {sfr1.Info()} на дробь {sfr2.Info()} получается дробь {sres.Info()}");
                                    Console.ReadLine();
                                    break;


                                case "0":
                                    key2 = false;
                                    break;

                                default:
                                    Console.WriteLine("Повторите ввод");
                                    break;
                            }
                        }
                        break;

                    case "0":
                        key = false;
                        break;

                    default:
                        Console.WriteLine("Повторите ввод");
                        break;
                }
            }
        }
    }
}