using System;

namespace Sorting
{
    public class SelectionSort
    {
        //Get min index and sort the vale and move to next element
        public static void Sort(int[] a, int n)
        {
            int minIndex, temp;

            for(int i=0; i<n-1; i++)
            {
                minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (a[j] < a[minIndex])
                    {
                        minIndex = j;
                    }                    
                }
                if (i != minIndex) //not already at right position
                {
                    temp = a[i];
                    a[i] = a[minIndex];
                    a[minIndex] = temp;
                }
            }
        }

        public static void Practice()
        {
            int[] a = new int[5];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter the {0} element: ", i + 1);
                a[i] = Int16.Parse(Console.ReadLine());
            }

            Sort(a, 5);

            Console.WriteLine("Sorted Array is: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
