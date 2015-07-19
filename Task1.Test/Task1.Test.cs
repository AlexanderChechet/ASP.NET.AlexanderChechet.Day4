﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Task1.Test
{
    [TestClass]
    public class Task1Test
    {
        #region MaxValue_TestMethods
        [TestMethod]
        public void MaxValue_PositiveNumbers_Descending()
        {
            int[] first = new[] {1, 2, 3, 10, 5};
            int[] second = new[] {5, 4, 13, 2, 1};
            int[] third = new[] {1, 12, 3, 4};
            int[][] array = new[] {first, second, third};

            MaxValueSort comparer = new MaxValueSort();

            Sorter.Sort(array, comparer, true);

            int[][] result = new[] {second, third, first};

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void MaxValue_NegativeNumbers_Descending()
        {
            int[] first = new[] { -8, -2, -3, -10, -5 };
            int[] second = new[] { -5, -4, -13, -7, -9 };
            int[] third = new[] { -14, -12, -3, -24 };
            int[][] array = new[] { first, second, third };

            MaxValueSort comparer = new MaxValueSort();

            Sorter.Sort(array, comparer, true);

            int[][] result = new[] { third, second, first };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void MaxValue_MixedNumbers_Descending()
        {
            int[] first = new[] { -1, 2, -3, 10, -5 };
            int[] second = new[] { 5, -4, -13, 2, 1 };
            int[] third = new[] { -1, 12, -3, 34 };
            int[][] array = new[] { third, second, first };

            MaxValueSort comparer = new MaxValueSort();

            Sorter.Sort(array, comparer, true);

            int[][] result = new[] { third, second, first };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void MaxValue_PositiveNumbers_Ascending()
        {
            int[] first = new[] { 1, 2, 3, 10, 5 };
            int[] second = new[] { 5, 4, 13, 2, 1 };
            int[] third = new[] { 1, 12, 3, 4 };
            int[][] array = new[] { first, second, third };

            MaxValueSort comparer = new MaxValueSort();

            Sorter.Sort(array, comparer, false);

            int[][] result = new[] { first, third, second };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void MaxValue_NegativeNumbers_Ascending()
        {
            int[] first = new[] { -8, -2, -3, -10, -5 };
            int[] second = new[] { -5, -4, -13, -7, -9 };
            int[] third = new[] { -14, -12, -3, -24 };
            int[][] array = new[] { first, second, third };

            MaxValueSort comparer = new MaxValueSort();

            Sorter.Sort(array, comparer, false);

            int[][] result = new[] { first, second, third };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void MaxValue_MixedNumbers_Ascending()
        {
            int[] first = new[] { -1, 2, -3, 10, -5 };
            int[] second = new[] { 5, -4, -13, 2, 1 };
            int[] third = new[] { -1, 12, -3, 34 };
            int[][] array = new[] { third, second, first };

            MaxValueSort comparer = new MaxValueSort();

            Sorter.Sort(array, comparer, false);

            int[][] result = new[] { first, second, third };

            Assert.IsTrue(CompareArrays(result, array));
        }
        #endregion

        #region SumArray_TestMethods
        [TestMethod]
        public void SumArray_PositiveNumbers_Descending()
        {
            int[] first = new[] { 1, 2, 3, 10, 5 }; //21
            int[] second = new[] { 5, 4, 13, 2, 1 }; //25
            int[] third = new[] { 1, 12, 3, 4 }; // 20
            int[][] array = new[] { first, second, third };

            SumArraySort comparer = new SumArraySort();

            Sorter.Sort(array, comparer, true);

            int[][] result = new[] { second, first, third };
            
            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void SumArray_NegativeNumbers_Descending()
        {
            int[] first = new[] { -1, -2, -3, -10, -5 }; //-21
            int[] second = new[] { -5, -4, -13, -2, -1 }; //-25
            int[] third = new[] { -1, -12, -3, -4 }; //-20
            int[][] array = new[] { first, second, third };

            SumArraySort comparer = new SumArraySort();

            Sorter.Sort(array, comparer, true);

            int[][] result = new[] { third, first, second };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void SumArray_MixedNumbers_Descending()
        {
            int[] first = new[] { -1, 2, 3, -10, 5 }; //-1
            int[] second = new[] { -5, 4, 13, 2, -1 }; //13
            int[] third = new[] { -1, 12, 3, -4 }; //10
            int[][] array = new[] { first, second, third };

            SumArraySort comparer = new SumArraySort();

            Sorter.Sort(array, comparer, true);

            int[][] result = new[] { second, third, first };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void SumArray_PositiveNumbers_Ascending()
        {
            int[] first = new[] { 1, 2, 3, 10, 5 }; //21
            int[] second = new[] { 5, 4, 13, 2, 1 }; //25
            int[] third = new[] { 1, 12, 3, 4 }; // 20
            int[][] array = new[] { first, second, third };

            SumArraySort comparer = new SumArraySort();

            Sorter.Sort(array, comparer, false);

            int[][] result = new[] { third, first, second };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void SumArray_NegativeNumbers_Ascending()
        {
            int[] first = new[] { -1, -2, -3, -10, -5 }; //-21
            int[] second = new[] { -5, -4, -13, -2, -1 }; //-25
            int[] third = new[] { -1, -12, -3, -4 }; //-20
            int[][] array = new[] { first, second, third };

            SumArraySort comparer = new SumArraySort();

            Sorter.Sort(array, comparer, false);

            int[][] result = new[] { second, first, third };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void SumArray_MixedNumbers_Ascending()
        {
            int[] first = new[] { -1, 2, 3, -10, 5 }; //-1
            int[] second = new[] { -5, 4, 13, 2, -1 }; //13
            int[] third = new[] { -1, 12, 3, -4 }; //10
            int[][] array = new[] { first, second, third };

            SumArraySort comparer = new SumArraySort();

            Sorter.Sort(array, comparer, false);

            int[][] result = new[] { first, third, second };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void NoComparer_Descending()
        {
            int[] first = new[] { -1, 2, 3, -10, 5 }; //5
            int[] second = new[] { -5, 4, 13, 2, -1 }; //13
            int[] third = new[] { -1, 12, 3, -4 }; //12
            int[][] array = new[] { first, second, third };

            Sorter.Sort(array, null, true);

            int[][] result = new[] { second, third, first };

            Assert.IsTrue(CompareArrays(result, array));
        }

        [TestMethod]
        public void NoComparer_Ascending()
        {
            int[] first = new[] { -1, 2, 3, -10, 5 }; //-10
            int[] second = new[] { -5, 4, 13, 2, -1 }; //-5
            int[] third = new[] { -1, 12, 3, -4 }; //-4
            int[][] array = new[] { first, second, third };

            Sorter.Sort(array, null, false);

            int[][] result = new[] { first, second, third };

            Assert.IsTrue(CompareArrays(result, array));
        }
        #endregion

        #region Private methods
        private bool CompareArrays(int[][] first, int[][] second)
        {
            int length = first.Length;
            if (length == second.Length)
            {
                int i = 0;
                for (; i < length && CompareArray(first[i], second[i]); i++)
                    ;
                if (i == length)
                    return true;
            }
            return false;
        }

        private bool CompareArray(int[] first, int[] second)
        {
            int length = first.Length;
            if (length == second.Length)
            {
                int i = 0;
                for (; i < length && first[i] == second[i]; i++)
                    ;
                if (i == length)
                    return true;
            }
            return false;
        }
        #endregion
    }
}