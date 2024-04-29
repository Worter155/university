internal class Ch2
{
    public static void Main()
    {
        Console.WriteLine("Введите x:");
        double x = Convert.ToDouble(Console.ReadLine());
        double y;

        if (x>=-7 && x<=3)
        {
            if (x <= -6)
            {
                y = 2;
            }
            else if (x > -6 && x <= -2)
            {
                y = ((x+2) / 4);
            }
            else if (x>-2 && x<=0)
            {
                y = (-(Math.Sqrt(4 - Math.Pow((x + 2), 2))) + 2);
            }
            else if (x>0 && x<=2)
            {
                y = Math.Sqrt(4 - Math.Pow(x, 2));
            }
            else
            {
                y = 2 - x;
            }
            Console.WriteLine("y = "+y);
        }
        else
        {
            Console.WriteLine("Такого y не существует");
        }
    }
}