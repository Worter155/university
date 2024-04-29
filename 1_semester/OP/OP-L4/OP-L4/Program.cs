using System;
namespace OP_L4
{
    public class Program
    {
        static void Main()
        {
            Counter couter = new Counter();
            Polynomial pol = new Polynomial();

            bool key = true;
            while (key)
            {
                Console.WriteLine("Выберите пункт меню:");
                Console.WriteLine("1-Десятичный счетчик");
                Console.WriteLine("2-Многочен");
                Console.WriteLine("3-Выход");
                string menu1 = Console.ReadLine();

                switch (menu1)
                {
                    case "1":
                        bool key1 = true;
                        while (key1)
                        {
                            Console.WriteLine("Выберите операцию");
                            Console.WriteLine("1-Прибавить 1");
                            Console.WriteLine("2-Отнять 1");
                            Console.WriteLine("3-Показать текущее значение");
                            Console.WriteLine("4-Предыдущее меню");
                            string menu2 = Console.ReadLine();

                            switch (menu2)
                            {
                                case "1":
                                    couter.Plus();
                                    break;

                                case "2":
                                    couter.Minus();
                                    break;

                                case "3":
                                    couter.GetCurrent();
                                    Console.ReadLine();
                                    break;

                                case "4":
                                    key1 = false;
                                    break;

                                default:
                                    Console.Write("Повторите ввод");
                                    break;
                            }
                        }
                        break;

                    case "2":
                        Console.WriteLine("Введите коэффиценты уравнения");
                        Console.Write("a = ");
                        pol.a = double.Parse(Console.ReadLine());
                        Console.Write("b = ");
                        pol.b = double.Parse(Console.ReadLine());
                        Console.Write("c = ");
                        pol.c = double.Parse(Console.ReadLine());
                        pol.Solution();
                        Console.ReadLine();
                        break;

                    case "3":
                        key = false;
                        break;

                    default:
                        Console.Write("Повторите ввод");
                        break;
                }
            }

            
        }

    }
}