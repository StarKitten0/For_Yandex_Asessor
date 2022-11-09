using System;

namespace ASCII_Array_Sort
{
    class Program
    {
        static string My_Sort(char[]array, string[]alphabet)
        {
            string final = "";
            for(int i=0;i<array.Length;i++)
            {
                alphabet[(int)array[i] - 33] += array[i];
            }
            for(int i=0;i<alphabet.Length;i++)
            {
                final += alphabet[i];
            }
            return final;
        }

        static void Main(string[] args)
        {
            string[] alphabet = new string[96];
            
            Console.WriteLine("Input ASCII Array");
            string line = Console.ReadLine();
            char[] array = new char[line.Length];
            for (int i = 0; i < line.Length; i++)
            {
                array[i] = line[i];
                
            }

            Console.WriteLine(My_Sort(array, alphabet));

            
        }
    }
}
