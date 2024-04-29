namespace PL_05
{
    [Serializable]
    public class ArrayVector : IVectorable
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

        public int Length
        {
            get { return coordArray.Length; }
        }

        public double GetNorm()
        {
            double s = 0;
            for (int i = 0; i < Length; i++)
            {
                s += Math.Pow(coordArray[i], 2);
            }
            return Math.Sqrt(s);
        }

        public override string ToString()
        {
            string s = $"{Length}: ";
            for (int i = 0; i < Length; i++)
            {
                s += $"{coordArray[i]} ";
            }

            return s;
        }

        public override bool Equals(object obj)
        {
            if (ToString() == obj.ToString()) return true;
            else return false;
        }

        public override int GetHashCode()
        {
            return ToString().GetHashCode();
        }

        public int CompareTo(object obj)
        {
            IVectorable v = obj as IVectorable;
            if (v != null)
            {
                if (v.Length < Length) return -1;
                else if (v.Length > Length) return 1;
                else return 0;
            }
            else throw new Exception();
        }

        public object Clone()
        {
            ArrayVector av = new ArrayVector(Length);
            for (int i = 0; i < Length; i++)
            {
                av[i] = this[i];
            }
            return av;
        }
    }
}