using System;

namespace Find_Max_In_Sort_But_Shifted_Array
{
    class Program
    {
        static  int result = 0;
        static void binary_search(int[] array, int start, int end)
        {
            if (end - start == 1) { result = array[start]; return; }
            int middle = start+(end - start) / 2;
            if (array[start] < array[middle]) binary_search(array, middle, end);
            else binary_search(array, start, middle);

        }
            
        static void Main(string[] args)
        {
            
            Console.WriteLine("There is no input because i dont want");
            int[] array = new int[5] { 5,1,2,3,4};
            if(array[0]<array[array.Length-1]) { Console.WriteLine(array[array.Length - 1]); return; }
            binary_search(array, 0, array.Length - 1);
            Console.WriteLine(result);

        }
    }
}
