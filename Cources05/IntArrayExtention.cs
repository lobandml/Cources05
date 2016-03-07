using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Cources05
{
    static class IntArrayExtention
    {
        public static void Sort(this int[] array, bool reverse)
        {
            
            int firstposition = 0;
            int secondposition = array.Length - 1;
            quickSort(ref array, firstposition, secondposition,reverse);
            
        }

        private static void quickSort(ref int[] array,int firstposition,int secondposition, bool reverse)
        {
            int temp;
            int x = array[firstposition + (secondposition - firstposition) / 2];

            int i = firstposition;
            int j = secondposition;

            while (i <= j)
            {
                if (!reverse)
                {
                    while (array[i] < x) i++;
                    while (array[j] > x) j--;
                }
                else
                {
                    while (array[i] > x) i++;
                    while (array[j] < x) j--;
                }

                if ( i <= j )
                {
                    
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                        i++;
                        j--;
                    
                    
                }
            }
            if (i < secondposition)
                quickSort(ref array, i, secondposition,reverse);

            if (firstposition < j)
                quickSort(ref array, firstposition, j,reverse);
        }

        public static void Print(this int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("{0}", array[i]);
            }
        }
        
    }
}
