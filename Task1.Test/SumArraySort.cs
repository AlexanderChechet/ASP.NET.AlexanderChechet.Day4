using System.Linq;

namespace Task1.Test
{
    public sealed class SumArraySort : ICustomComparer
    {
        public int Compare(int[] first, int[] second)
        {
            return first.Sum() - second.Sum();
        }
    }
}
