using System;
using System.Linq;

namespace Task1.Test
{
    public sealed class MaxValueSort : ICustomComparer
    {
        public int Compare(int[] first, int[] second)
        {
            return first.Max(x => Math.Abs(x)) - second.Max(x => Math.Abs(x));
        }
    }
}
