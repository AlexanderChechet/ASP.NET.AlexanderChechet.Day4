namespace Task1
{
    public class Sorter
    {
        #region Public static methods
        public static void Sort(int[][] array, ICustomComparer comparer, bool ascending = false)
        {
            if (comparer != null)
                BubbleSort(array, comparer, ascending);
            else
                BubbleSort(array, ascending);
        }
        #endregion

        #region Private static methods
        private static void BubbleSort(int[][] array, ICustomComparer comparer, bool ascending)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length - i - 1; j++)
                    if ((comparer.Compare(array[j], array[j+1]) < 0) == ascending)
                        Swap(ref array[j], ref array[j + 1]);
        }

        private static void BubbleSort(int[][] array, bool ascending = false)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
                BubbleSort(array[i], ascending);
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length - i - 1; j++)
                    if (array[j][0] < array[j + 1][0] == ascending)
                        Swap(ref array[j], ref array[j + 1]);
        }

        private static void BubbleSort(int[] array, bool ascending)
        {
            int length = array.Length;
            for (int i = 0; i < length; i++)
                for (int j = 0; j < length - i - 1; j++)
                    if (array[j] < array[j+1] == ascending)
                        Swap(ref array[j], ref array[j+1]);
        }

        private static void Swap(ref int a,ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        private static void Swap(ref int[] a, ref int[] b)
        {
            int[] temp = a;
            a = b;
            b = temp;
        }
        #endregion
    }
}
