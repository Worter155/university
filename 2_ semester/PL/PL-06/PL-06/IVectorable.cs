namespace PL_06
{
    public interface IVectorable : IComparable, ICloneable
    {
        public int this[int index]
        {
            get;
            set;
        }
        int Length { get; }
        double GetNorm();
    }
}