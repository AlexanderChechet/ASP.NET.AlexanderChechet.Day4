using System;
using System.Linq;

namespace Task1.Test
{
    public sealed class MaxValueSort : IComparer
    {
        public int Compare(int[] first, int[] second)
        {
            return second.Max(x => Math.Abs(x)) - first.Max(x => Math.Abs(x));
        }
    }
}
