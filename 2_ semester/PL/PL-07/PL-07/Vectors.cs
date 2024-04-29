using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_07
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

        public static void OutputVector(IVectorable v, Stream st)
        {
            byte[] arr1 = BitConverter.GetBytes(v.Length);
            st.Write(arr1, 0, arr1.Length);
            for (int i = 0; i < v.Length; i++)
            {
                byte[] arr2 = BitConverter.GetBytes(v[i]);
                st.Write(arr2, 0, arr2.Length);
            }
        }

        public static IVectorable[] InputVector(Stream st)
        {
            if (st.Length == 0)
            {
                throw new Exception("Файл не содержит вектор");
            }
            else
            {
                st.Seek(0, SeekOrigin.Begin);
                List<IVectorable> list = new List<IVectorable>();
                while (st.Position != st.Length)
                {
                    byte[] leng = new byte[4];
                    st.Read(leng, 0, 4);
                    IVectorable vector = new ArrayVector(BitConverter.ToInt32(leng, 0));
                    for (int i = 0; i < vector.Length; i++)
                    {
                        leng = new byte[4];
                        st.Read(leng, 0, 4);
                        vector[i] = BitConverter.ToInt32(leng, 0);
                    }
                    list.Add(vector);
                }
                IVectorable[] vec = list.ToArray();
                return vec;
            }
        }

        public static void WriteVector(IVectorable v, TextWriter st)
        {
            st.Write(v.ToString() + "\n");
        }

        public static IVectorable[] ReadVector(TextReader st)
        {
            string s;
            List<IVectorable> list = new List<IVectorable>();
            while ((s = st.ReadLine()) != null)
            {
                string[] res = s.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                IVectorable vector = new ArrayVector(res.Length - 1);
                for (int i = 1; i < res.Length; i++)
                {
                    vector[i - 1] = int.Parse(res[i]);
                }
                list.Add(vector);
            }
            var arr = list.ToArray();
            return arr;
        }
    }
}
