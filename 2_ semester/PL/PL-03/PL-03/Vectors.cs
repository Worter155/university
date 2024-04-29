namespace PL_03
{
    public static class Vectors
    {
        public static IVectorable Sum(IVectorable av1, IVectorable av2)
        {
            if (av1.Length < av2.Length)
            {
                int[] temp = new int[av2.Length];
                for (int i = 0; i < av1.Length; i++)
                {
                    temp[i] = av1[i];
                }

                av1 = new ArrayVector(av2.Length);

                for (int i = 0; i < av2.Length; i++)
                {
                    av1[i] = temp[i];
                }
            }
            else if (av1.Length > av2.Length)
            {
                int[] temp = new int[av1.Length];
                for (int i = 0; i < av2.Length; i++)
                {
                    temp[i] = av2[i];
                }

                av2 = new ArrayVector(av1.Length);

                for (int i = 0; i < av1.Length; i++)
                {
                    av2[i] = temp[i];
                }
            }

            IVectorable av3 = new ArrayVector(av1.Length);

            for (int i = 0; i < av3.Length; i++)
            {
                av3[i] = av1[i] + av2[i];
            }

            return av3;
        }

        public static int Scalar(IVectorable av1, IVectorable av2)
        {
            if (av1.Length < av2.Length)
            {
                int[] temp = new int[av2.Length];
                for (int i = 0; i < av1.Length; i++)
                {
                    temp[i] = av1[i];
                }

                av1 = new ArrayVector(av2.Length);

                for (int i = 0; i < av2.Length; i++)
                {
                    av1[i] = temp[i];
                }
            }
            else if (av1.Length > av2.Length)
            {
                int[] temp = new int[av1.Length];
                for (int i = 0; i < av2.Length; i++)
                {
                    temp[i] = av2[i];
                }

                av2 = new ArrayVector(av1.Length);

                for (int i = 0; i < av1.Length; i++)
                {
                    av2[i] = temp[i];
                }
            }

            int s = 0;

            for (int i = 0; i < av1.Length; i++)
            {
                s += av1[i] * av2[i];
            }

            return s;
        }

        public static IVectorable MultNumber(IVectorable av, int k)
        {
            IVectorable rav = new ArrayVector(av.Length);

            for (int i = 0; i < av.Length; i++)
            {
                rav[i] = k * av[i];
            }

            return rav;
        }

        public static double GetNormSt(IVectorable av)
        {
            double s = 0;
            for (int i = 0; i < av.Length; i++)
            {
                s += Math.Pow(av[i], 2);
            }
            return Math.Sqrt(s);
        }
    }
}

