internal class Ch1
{
    public static void Main()
    {
        Console.WriteLine("Введите х:");
        double x = Convert.ToDouble(Console.ReadLine());
        double y1;
        double y2;
        if (x != 0 && x != -2 && x != 2)
        {
            y1 = (Math.Pow((((1 + x + Math.Pow(x, 2)) / (2 * x + Math.Pow(x, 2))) + 2 - ((1 - x + Math.Pow(x, 2)) / (2 * x - Math.Pow(x, 2)))), -1)) * (5 - 2 * Math.Pow(x, 2));
            Console.WriteLine("Значение первого выражения: " + y1);
        }
        else
        {
            Console.WriteLine("На ноль делить нельзя!");
        }
        y2 = ((4 - Math.Pow(x, 2)) / 2);
        
        Console.WriteLine("Значение второго выражения: " + y2);
    }
}