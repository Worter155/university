using System;
namespace PL_02
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
            get
            {
                try
                {
                    return coordArray[index];
                }
                catch
                {
                    throw new Exception("Такого элемента не существует");
                }
            }
            set
            {
                try
                {
                    coordArray[index] = value;
                }
                catch
                {
                    throw new Exception("Такого элемента не существует");
                }
                
            }
        }

        public int Len
        {
            get {return coordArray.Length;}
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
    }
}

