using System;
namespace OP_L4
{
	public class Counter
	{
		public int max = 10;
		public int min = 1;
		public int cur = 0;


		public int Plus()
		{
            if (cur < max)
			{
				cur++;
			}
			else
			{
				cur = min;
			}
			return cur;
		}

        public int Minus()
        {
            if (cur > min)
            {
                cur--;
            }
            else
            {
                cur = max;
            }
            return cur;
        }

		public void GetCurrent()
		{
			Console.Write("Текущее значение: ");
			Console.WriteLine(cur);
		}
    }
}

