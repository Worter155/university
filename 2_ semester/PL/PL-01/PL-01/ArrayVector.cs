using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PL_01
{
	public class ArrayVector
	{

		public int[] coordArray;

		public ArrayVector(int n)
		{
			coordArray = new int[n];
		}
        public ArrayVector()
        {
            coordArray = new int[5];
        }

        public int this[int index]
        {
            get => coordArray[index];
            set => coordArray[index] = value;
        }

        public double GetNorm()
        {
            double s = 0;
            for (int i = 0; i < coordArray.Length; i++)
            {
                s += Math.Pow(coordArray[i], 2);
            }
            return Math.Sqrt(s);
        }

        public int SumPositivesFromChetIndex(out int k)
        {
            int s = 0;
            k = 0;
            for (int i = 1; i < coordArray.Length; i+=2)
            {
                if (coordArray[i] > 0)
                {
                    s += coordArray[i];
                    k += 1;
                }
            }
            return s;
        }

        public int SumLessFromNechetIndex()
        {
            double mid = 0;
            int s = 0;

            for (int i = 0; i < coordArray.Length; i++)
            {
                mid += Math.Abs(coordArray[i]);
            }

            mid /= coordArray.Length;

            for (int i = 0; i < coordArray.Length; i+=2)
            {
                if (coordArray[i] < mid)
                {
                    s += coordArray[i];
                }

            }

            return s;
        }

        public int MultChet(out int k)
        {
            int m=1;
            k = 0;
            for (int i = 0; i < coordArray.Length; i++)
            {
                if (coordArray[i]>0 && coordArray[i] % 2 == 0)
                {
                    m *= coordArray[i];
                    k += 1;
                }
            }

            return m;
        }

        public int MultNechet()
        {
            int m = 1;

            for (int i = 0; i < coordArray.Length; i++)
            {
                if (coordArray[i] % 2 != 0 && coordArray[i] % 3 != 0)
                {
                    m *= coordArray[i];
                }
            }
            return m;
        }

        public void SortUp()
        {
            for (int i = 1; i < coordArray.Length; i++)
            {
                for (int j = 0; j < coordArray.Length - i; j++)
                {
                    if (coordArray[j] > coordArray[j + 1])
                    {
                        (coordArray[j+1], coordArray[j]) = (coordArray[j], coordArray[j+1]);
                    }
                }
            }
        }

        public void SortDown()
        {
            for (int i = 1; i < coordArray.Length; i++)
            {
                for (int j = 0; j < coordArray.Length - i; j++)
                {
                    if (coordArray[j] < coordArray[j + 1])
                    {
                        (coordArray[j + 1], coordArray[j]) = (coordArray[j], coordArray[j + 1]);
                    }
                }
            }
        }
    }
}

