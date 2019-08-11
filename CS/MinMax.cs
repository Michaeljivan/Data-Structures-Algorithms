using System;

namespace Algorithms
{
    public static class MinMax
    {
        public static void Main(string [] args)
        {
            int [] array = new int[] {12,423,121,3};
            FindMinMax(array);
        }


        public static void FindMinMax(int [] array)
        {
            // Check length of array, if 0 end program
            if (array.Length == 0){
                Console.WriteLine("Array inputed with 0 elements.");
                return;
            }
        
           // Variables to help specify
           int max = 0;
           int min = 0;
          // int temp;
           
           for(int i = 1; i < array.Length; i++)
           {
               if(array[min] > array[i])
               {
                   // Assign index to min
                   min = i;
               }
               else if(array[max] < array[i])
               {
                   //Assign index to max if i is greater than max element
                    max = i;
               }
           }

          // temp = array[min];
           array[min] = array[min];
           array[max] = array[max];

           Console.WriteLine("MAX " + array[max]);
           Console.WriteLine("MIN " + array[min]);
        }
    }
}