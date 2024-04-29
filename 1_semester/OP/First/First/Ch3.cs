internal class Ch3
{
    public static void Main()
    {
        Console.WriteLine("x:");
        double x = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("y:");
        double y = Convert.ToDouble(Console.ReadLine());

        if ((((y >= Math.Pow((x - 2), 2) - 3) && (x >= Math.Abs(y)) && (y >= 0)) || ((y >= Math.Pow((x - 2), 2) - 3) && (x <= Math.Abs(y)) && (y <= 0))))
        {
            Console.WriteLine("Вы попали в мешень!");
        }
        else
        {
            Console.WriteLine("Вы не попали в мешень!");
        }
    }
}