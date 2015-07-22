using System.Linq;

namespace Task1.Test
{
    public sealed class SumArraySort : IComparer
    {
        public int Compare(int[] first, int[] second)
        {
            return second.Sum() - first.Sum();
        }
    }
}
