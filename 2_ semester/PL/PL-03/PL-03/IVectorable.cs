namespace PL_03
{
    public interface IVectorable
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

