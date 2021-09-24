using System;

namespace Sorting
{
    //In every pass compairing all the elements
    //We can improve the bubble sort, if we can check that array is sorted in third itration only and no more swaps are required.
    //you can count the swap and in any itration if count is 0 means no swap done means array sorted 

    public class BubbleSort
    {
        public static void Sort(int[] a, int n)
        {
            int swaps;
            for(int i=0; i<n-2; i++)
            {
                swaps = 0;
                for(int j=i; j<n-1; j++)
                {
                    if(a[j] > a[j+1])
                    {
                        //Swapping without using third variable
                        a[j] = a[j] + a[j + 1];
                        a[j + 1] = a[j] - a[j + 1];
                        a[j] = a[j] - a[j + 1];
                        swaps++;
                    }
                }
                if(swaps == 0)
                {
                    break;
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
