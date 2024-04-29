using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_07
{
    public class Comparer : IComparer<IVectorable>
    {
        public int Compare(IVectorable v1, IVectorable v2)
        {
            if (v1.GetNorm() < v2.GetNorm()) return -1;
            else if (v1.GetNorm() > v2.GetNorm()) return 1;
            else return 0;
        }
    }
}
