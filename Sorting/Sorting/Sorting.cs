using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sorting
{
    /*Sorting Algoritms*/
    //-Merge Sort-Heap Sort-Quick Sort-Bubble Sort-Selection Sort-Insertion Sort.
    class Sorting
    {
        
        // this class Contains Sorting types for Arrays 
        //Bubble Sort-Merge Sort-Heap Sort-Quick Sort....
        int[] Array;
        int[] TempArray;
        //MergeSort Method,the Complexty time is O(n.log(n)).
        public void MergeSort(int[] Array)
        {
            this.Array = Array;
            this.TempArray = new int[Array.Length];
            doMergeSort(0, Array.Length - 1);

        }

        void doMergeSort(int LowIndex, int HighIndex)
        {
            if (LowIndex==HighIndex) return;
            int MiddleIndex = (LowIndex + HighIndex) / 2;
            doMergeSort(LowIndex, MiddleIndex);
            doMergeSort(MiddleIndex + 1, HighIndex);
            TheSorted(LowIndex, MiddleIndex, HighIndex);
        }
        void TheSorted(int LowIndex, int MiddleIndex, int HighIndex)
        {
            for (int i = LowIndex; i <= HighIndex; i++)
                TempArray[i] = Array[i];
            int i1 = LowIndex;
            int j = LowIndex;
            int k = MiddleIndex + 1;
            while (j <= MiddleIndex && k <= HighIndex)
            {
                if (TempArray[j] < TempArray[k])
                {
                    Array[i1] =TempArray[j];
                    j++;
                }
                else
                {
                    Array[i1] = TempArray[k];
                    k++;
                }
                i1++;
            }
            while (j <= MiddleIndex)
            {
                Array[i1] = TempArray[j];
                i1++;
                j++;
            }

          
        }
       //---------------------------------------------------------end
       //heap sort the complexty time is O(n.log(n)).
        int total;
        void Heapify(int[] Array, int p)
        {

            int l = 2 * p + 1;
            int r = 2 * p + 2;
            int n = p;
            if (l <= total && r <= total)
            {
                if (Array[r] < Array[l]) n = l;
                else n = r;
                if (Array[n] > Array[p]) { Swap(Array, n, p); Heapify(Array, n); }

            }
            else if (l <= total)
            {
                if (Array[l] > Array[p]) { Swap(Array, l, p); }
            }
            else if (r <= total)
            {
                if (Array[r] > Array[p]) { Swap(Array, r, p); }
            }
            else return;

        }
        void Swap(int[] Array, int a, int b)
        {
            int temp;
            temp = Array[a];
            Array[a] = Array[b];
            Array[b] = temp;

        }
        //the complexty time is O(n.Log(n)).
        public void HeapSort(int[] Array)
        {
            total = Array.Length - 1;
            for (int i = total / 2; i >= 0; i--)
                Heapify(Array, i);

            for (int i = total; i > 0; i--)
            {

                Swap(Array, 0, i);
                total--;
                Heapify(Array, 0);
            }

        }
        //------------------------------------end.
       // quick sort,the complexty time is O(n^2).
        public void QuickSort(int[] Array)
        {
            sort(Array, 0, Array.Length - 1);
        }

         void sort(int[] Array, int low, int upper)
        {
            if (low >= upper) return;

            int pivot = Array[low];
            int start = low;
            int stop = upper;
            while (low < upper)
            {
                while (Array[low] <= pivot && low < upper)
                {
                    low++;
                }
                while (Array[upper] > pivot && low <= upper)
                {
                    upper--;
                }
                if (low < upper)
                {
                    Swap(Array, upper, low);
                }

            }
            Swap(Array, upper, start);
            sort(Array, start, upper - 1);
            sort(Array, upper + 1, stop);

        }

       //--------------------------------end.
        //Bubble ort,the complexty time is O(n^2).
        public  void BubbleSort(int[] v, int n)
        {
            int swap;
            for (int i = 1; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    if (v[j] > v[j + 1])
                    {
                        swap = v[j];
                        v[j] = v[j + 1];
                        v[j + 1] = swap;
                    }
                }
            }

        }
        //Selection Sort , the complexty time is O(n^2).
        public void SelectionSort(int[] v)
        {

            int l = v.Length, j, p, max;
            for (int i = 1; i <l; i++)
            {
                max = v[0];
                p = 0;
                for (j = 0; j < l - i + 1; j++)
                {
                    if (max < v[j])
                    {
                        max = v[j];
                        p = j;
                    }
                }
                Swap(v, p, j - 1);
            }

            
        }
        //Insertion Sort
        public void InsertionSort(int[] array)
        {      
            for (int i = 1; i < array.Length; i++)
            {

                int j = i;
                while (j > 0 && array[j] < array[j - 1])
                {
                    Swap(array, j, j - 1);
                    j--;
                }
            }

        }
        //----------------------------end.
        //this Method for  Print an  Array.
        public static void Print(int[] v, int n = -1)
        {
            int i = 0;
            if (n == -1) n = v.Length;
            while (i < n)
            {
                Console.Write(v[i] + "  ");
                i++;
            }
        }
       








    }
}
