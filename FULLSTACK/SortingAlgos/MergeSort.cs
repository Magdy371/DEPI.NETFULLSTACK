using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgos
{
    internal class MergeSort
    {
        public static void Sort<T>(T[] array) where T : IComparable<T>
        {
            if (array.Length <= 1)
                return;
            int mid = array.Length / 2;
            T[] left = new T[mid];
            T[] right = new T[array.Length - mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);
            Sort(left);
            Sort(right);
            Merge(array, left, right); // Fix: Call Merge to combine sorted arrays
        }

        public static void Merge<T>(T[] array, T[] left, T[] right) where T : IComparable<T>
        {
            int i = 0, j = 0, k = 0;
            while (i < left.Length && j < right.Length)
            {
                if (left[i].CompareTo(right[j]) <= 0) // Fix: Add missing semicolon and closing brace
                {
                    array[k++] = left[i++];
                }
                else
                {
                    array[k++] = right[j++];
                }
            }
            while (i < left.Length)
            {
                array[k++] = left[i++];
            }
            while (j < right.Length)
            {
                array[k++] = right[j++];
            }
        }
    }

}
