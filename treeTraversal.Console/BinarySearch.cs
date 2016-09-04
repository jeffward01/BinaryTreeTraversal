using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace treeTraversal.Console
{
    public class BinarySearch
    {
        public static object BinarySearchIterative(int[] inputArray, int key, int min, int max)
        {
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return max = mid - 1;
                }
                else if (key > inputArray[mid])
                {
                    return max = mid + 1;
                }

            }
            return 'Nil';
        }



        public static object BinarySearchRecursive(int[] inputArray, int key, int min, int max)
        {
            if (min > max)
            {
                return "Nil";
            }
            else
            {
                int mid = (min + max) / 2;
                if (key == inputArray[mid])
                {
                    return ++mid;
                }
                else if (key < inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, min, max - 1);
                }
                else if (key > inputArray[mid])
                {
                    return BinarySearchRecursive(inputArray, key, mid + 1, max);
                }

            }
            return "Nil";
        }


        public static int simpleBinarySearch(int[] array, int value)
        {
            int low = 0;
            int high = array.Length - 1;
            int midpoint = 0;

            while (low<=high)
            {
                midpoint = low + (high - low)/2;
                if (value == array[midpoint])
                {
                    return midpoint;
                }
                else if(value < array[midpoint])
                {
                    high = midpoint - 1;
                }
                else
                {
                    low = midpoint + 1;
                }
            }
            return -1;
        }
    }
}

//http://www.c-sharpcorner.com/blogs/binary-search-implementation-using-c-sharp1
