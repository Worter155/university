using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.WebRequestMethods;

namespace PL_07
{
    public static class VectorController
    {
        public static IVectorable[] ReadVectors(int length, string vecArrStr)
        {
            IVectorable[] vecArr = new IVectorable[length];
            string[] vecStr = vecArrStr.Split('\n');
            if (vecStr.Length != length)
            {
                throw new ApplicationException($"Введите число векторов, равное {length}!");
            }
            for (int i = 0; i < length; i++)
            {
                string[] str = vecStr[i].Split(new char[] { ' ' });
                if (i % 2 == 0)
                {
                    vecArr[i] = new ArrayVector(str.Length);
                }
                else
                {
                    vecArr[i] = new LinkedListVector(str.Length);
                }
                for (int j = 0; j < vecArr[i].Length; j++)
                {
                    vecArr[i][j] = int.Parse(str[j]);
                }

            }
            return vecArr;
        }

        public static IVectorable[] MaxVectors(IVectorable[] vecArr)
        {
            IVectorable max = vecArr[0];
            int k = 0;
            for (int i = 0; i < vecArr.Length; i++)
            {
                if (max.CompareTo(vecArr[i]) > 0)
                {
                    max = vecArr[i];
                }
            }
            for (int i = 0; i < vecArr.Length; i++)
            {
                if (max.Length == vecArr[i].Length)
                {
                    k += 1;
                }
            }
            IVectorable[] maxVectors = new IVectorable[k];
            int a = 0;
            for (int i = 0; i < vecArr.Length; i++)
            {
                if (max.Length == vecArr[i].Length)
                {
                    maxVectors[a] = vecArr[i];
                    a++;
                }
            }
            return maxVectors;
        }

        public static IVectorable[] MinVectors(IVectorable[] vecArr)
        {
            IVectorable min = vecArr[0];
            int k = 0;
            for (int i = 0; i < vecArr.Length; i++)
            {
                if (min.CompareTo(vecArr[i]) < 0)
                {
                    min = vecArr[i];
                }
            }
            for (int i = 0; i < vecArr.Length; i++)
            {
                if (min.Length == vecArr[i].Length)
                {
                    k += 1;
                }
            }
            IVectorable[] minVectors = new IVectorable[k];
            int a = 0;
            for (int i = 0; i < vecArr.Length; i++)
            {
                if (min.Length == vecArr[i].Length)
                {
                    minVectors[a] = vecArr[i];
                    a++;
                }
            }
            return minVectors;
        }

        public static IVectorable[] Sort(IVectorable[] vecArr)
        {
            Array.Sort(vecArr, new Comparer());
            return vecArr;
        }

        public static void WriteByteStream(IVectorable[] vectors)
        {
            try
            {
                FileStream file1 = new FileStream("C:\\Users\\Worter\\source\\repos\\PL-07\\PL-07\\test.dat", FileMode.Truncate, FileAccess.Write);
                for (int i = 0; i < vectors.Length; i++)
                {
                    Vectors.OutputVector(vectors[i], file1);
                }
                file1.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static IVectorable[] ReadByteStream()
        {
            try
            {
                FileStream file2 = new FileStream("C:\\Users\\Worter\\source\\repos\\PL-07\\PL-07\\test.dat", FileMode.Open, FileAccess.Read);
                return Vectors.InputVector(file2);
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static void WriteCharStream(IVectorable[] vectors)
        {
            try
            {
                StreamWriter file3 = new StreamWriter("C:\\Users\\Worter\\source\\repos\\PL-07\\PL-07\\test.txt", false);
                for (int i = 0; i < vectors.Length; i++)
                {
                    Vectors.WriteVector(vectors[i], file3);
                }
                file3.Close();
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
        public static IVectorable[] ReadCharStream()
        {
            try
            {
                StreamReader file4 = new StreamReader("C:\\Users\\Worter\\source\\repos\\PL-07\\PL-07\\test.txt");
                return Vectors.ReadVector(file4);
                
            }
            catch (Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }

        public static IVectorable[] Serialize(IVectorable[] vectors)
        {
            try
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                FileStream stream = new FileStream("C:\\Users\\Worter\\source\\repos\\PL-07\\PL-07\\test.bin", FileMode.Truncate, FileAccess.Write);
                for (int i = 0; i < vectors.Length; i++)
                {
                    binFormat.Serialize(stream, vectors[i]);
                }
                stream.Close();
                IVectorable[] vectors2 = new IVectorable[vectors.Length];
                FileStream stream1 = new FileStream("C:\\Users\\Worter\\source\\repos\\PL-07\\PL-07\\test.bin", FileMode.Open, FileAccess.Read);
                for (int i = 0; i < vectors.Length; i++)
                {
                    vectors2[i] = (IVectorable)binFormat.Deserialize(stream1);
                }
                return vectors2;
            }
            catch(Exception ex)
            {
                throw new ApplicationException(ex.Message);
            }
        }
    }
}
