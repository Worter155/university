using System;
namespace PL_02
{
    public static class Vectors
    {
        public static ArrayVector Sum(ArrayVector av1, ArrayVector av2)
        {
            if (av1.coordArray.Length < av2.coordArray.Length)
            {
                int[] temp = new int[av2.coordArray.Length];
                for (int i = 0; i < av1.coordArray.Length; i++)
                {
                    temp[i] = av1[i];
                }

                av1 = new ArrayVector(av2.coordArray.Length);

                for (int i = 0; i < av2.coordArray.Length; i++)
                {
                    av1[i] = temp[i];
                }
            }
            else if (av1.coordArray.Length > av2.coordArray.Length)
            {
                int[] temp = new int[av1.coordArray.Length];
                for (int i = 0; i < av2.coordArray.Length; i++)
                {
                    temp[i] = av2[i];
                }

                av2 = new ArrayVector(av1.coordArray.Length);

                for (int i = 0; i < av1.coordArray.Length; i++)
                {
                    av2[i] = temp[i];
                }
            }

            ArrayVector av3 = new ArrayVector(av1.coordArray.Length);

            for (int i = 0; i < av3.coordArray.Length; i++)
            {
                av3[i] = av1[i] + av2[i];
            }

            return av3;
        }

        public static int Scalar(ArrayVector av1, ArrayVector av2)
        {
            if (av1.coordArray.Length < av2.coordArray.Length)
            {
                int[] temp = new int[av2.coordArray.Length];
                for (int i = 0; i < av1.coordArray.Length; i++)
                {
                    temp[i] = av1[i];
                }

                av1 = new ArrayVector(av2.coordArray.Length);

                for (int i = 0; i < av2.coordArray.Length; i++)
                {
                    av1[i] = temp[i];
                }
            }
            else if (av1.coordArray.Length > av2.coordArray.Length)
            {
                int[] temp = new int[av1.coordArray.Length];
                for (int i = 0; i < av2.coordArray.Length; i++)
                {
                    temp[i] = av2[i];
                }

                av2 = new ArrayVector(av1.coordArray.Length);

                for (int i = 0; i < av1.coordArray.Length; i++)
                {
                    av2[i] = temp[i];
                }
            }

            int s = 0;

            for (int i = 0; i < av1.coordArray.Length; i++)
            {
                s += av1[i] * av2[i];
            }

            return s;
        }

        public static ArrayVector MultNumber(ArrayVector av, int k)
        {
            ArrayVector rav = new ArrayVector(av.coordArray.Length);

            for (int i = 0; i < av.coordArray.Length; i++)
            {
                rav[i] = k * av[i];
            }

            return rav;
        }

        public static double GetNormSt(ArrayVector av)
        {
            double s = 0;
            for (int i = 0; i < av.coordArray.Length; i++)
            {
                s += Math.Pow(av.coordArray[i], 2);
            }
            return Math.Sqrt(s);
        }
    }
}

