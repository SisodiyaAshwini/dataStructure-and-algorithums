using System;

namespace Sorting
{
    public class InsertionSort
    {
        //This is my logic, you can check video 107 for logic given by author
        //In this itaration are based upon the data. 
        //it is a stable sort : stable means it does not change the sorting of dependent columns
        //In place, no extra memory is required
        //One disadvantage is number of movement will be very large when there are two many elements
        //It is good when list is almost sorted, This is the improvement give in shell sort
        public static void Sort(int[] a, int n)
        {
            for(int i=0; i<n-1; i++)
            {
                if(a[i] > a[i+1])
                {
                    a[i] = a[i] + a[i+1];
                    a[i + 1] = a[i] - a[i + 1];
                    a[i] = a[i] - a[i + 1];
                }
                for (int j=i; j>0; j--)
                {
                    if (a[j] < a[j - 1])
                    {
                        a[j] = a[j] + a[j - 1];
                        a[j - 1] = a[j] - a[j - 1];
                        a[j] = a[j] - a[j - 1];
                    }
                }
            }
        }

        public static void Practice()
        {
            int[] a = new int[10];
            Console.WriteLine("Enter the elements");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter the {0} element: ", i + 1);
                a[i] = Int16.Parse(Console.ReadLine());
            }

            Sort(a, 10);

            Console.WriteLine("Sorted Array is: ");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(a[i]);
            }

        }
    }
}
