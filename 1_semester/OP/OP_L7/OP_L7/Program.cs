using System;
namespace OP_L7
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Лабораторная работа №7. Работа со строками");
            Console.WriteLine("Выполнил студент Москалев А.А., группы 6102-020302D");
            Console.WriteLine("Введите сторку");
            string str;
            str = Console.ReadLine();
            bool key = true;
            while (key)
            {
                Console.WriteLine("Выберите пункт меню:  ");
                Console.WriteLine("1 - Подсчитать количество букв в строке");
                Console.WriteLine("2 - Подсчитать среднюю длину слова");
                Console.WriteLine("3 - Замена заданного слова");
                Console.WriteLine("4 - Подсчет количества вхождений подстроки");
                Console.WriteLine("5 - Проверка на полиндром");
                Console.WriteLine("6 - Проверка на дату");
                Console.WriteLine("7 - Ввод новой строки");
                Console.WriteLine("0 - Выход");
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine("Исходная строка");
                        Console.WriteLine(str);
                        Console.Write("Букв в строке: ");
                        Console.WriteLine(StrProc.LettersCount(str));
                        Console.ReadLine();
                        break;

                    case "2":
                        Console.WriteLine("Исходная строка");
                        Console.WriteLine(str);
                        Console.Write("Средняя длина слова: ");
                        Console.WriteLine(StrProc.AverageWordLen(str));
                        Console.ReadLine();
                        break;

                    case "3":
                        Console.WriteLine("Введите слово, которое хотите заменить");
                        string word1 = Console.ReadLine();
                        Console.WriteLine("Введите слово, на которое хотите заменить");
                        string word2 = Console.ReadLine();
                        Console.WriteLine("Строка до замены");
                        Console.WriteLine(str);
                        Console.WriteLine("Строка после замены");
                        Console.WriteLine(StrProc.WordChange(str,word1,word2));
                        Console.ReadLine();
                        break;

                    case "4":
                        Console.WriteLine("Введите подстроку");
                        string sub = Console.ReadLine();
                        Console.WriteLine("Исходная строка");
                        Console.WriteLine(str);
                        Console.Write("Количество вхождений: ");
                        Console.WriteLine(StrProc.SubstrCount(str, sub));
                        Console.ReadLine();
                        break;

                    case "5":
                        Console.WriteLine("Исходная строка");
                        Console.WriteLine(str);
                        if (StrProc.IsPalindrome(str))
                        {
                            Console.WriteLine("Эта строка - палиндром");
                        }
                        else
                        {
                            Console.WriteLine("Эта строка - не палиндром");
                        }
                        Console.ReadLine();
                        break;

                    case "6":
                        Console.WriteLine("Исходная строка");
                        Console.WriteLine(str);
                        if (StrProc.CheckDate(str))
                        {
                            Console.WriteLine("Эта строка - дата");
                        }
                        else
                        {
                            Console.WriteLine("Эта строка - не дата");
                        }
                        Console.ReadLine();
                        break;

                    case "7":
                        Console.WriteLine("Введите новую строку");
                        str = Console.ReadLine();
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