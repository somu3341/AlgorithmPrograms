using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmPrograms.MergeSort
{
    public class MergeSortOperation
    {
        public void MergeSorting(string filepath)
        {
            string readData = File.ReadAllText(filepath);
            string[] words = readData.Split(" ");
            int[] arr = new int[words.Length];
            int count = 0;
            foreach (var data in words)
            {
                arr[count] = Convert.ToInt32(data);
                count++;
                Console.WriteLine(data);
            }
            int first = 0;
            int last = words.Length;
            Merge(arr, first, last - 1);
            Console.WriteLine("After Sorting");
            Console.WriteLine("---------------");
            Display(arr, first, last);
        }
        public void Merge(int[] arr, int first, int last)
        {
            if (first < last)
            {
                int mid = first + (last - first) / 2;
                Merge(arr, first, mid);
                Merge(arr, mid + 1, last);
                Merge(arr, first, last, mid);
            }
        }
        public void Merge(int[] arr, int first, int last, int mid)
        {
            int i, j, k;
            int n1 = mid - first + 1;
            int n2 = last - mid;
            int[] a = new int[n1];
            int[] b = new int[n2];
            for (i = 0; i < n1; i++)
            {
                a[i] = arr[first + i];
            }
            for (j = 0; j < n2; j++)
            {
                b[j] = arr[mid + 1 + j];
            }
            i = 0;
            j = 0;
            k = first;

            while (i < n1 && j < n2)
            {
                if (a[i] <= b[j])
                {
                    arr[k] = a[i];
                    i++;
                }
                else
                {
                    arr[k] = b[j];
                    j++;
                }
                k++;
            }
            while (i < n1)
            {
                arr[k] = a[i];
                i++;
                k++;
            }
            while (j < n2)
            {
                arr[k] = b[j];
                j++;
                k++;
            }

        }
        public void Display(int[] arr, int first, int last)
        {
            for (int i = first; i < last; i++)
            {
                Console.WriteLine(arr[i]);
            }
        }
    }
}
