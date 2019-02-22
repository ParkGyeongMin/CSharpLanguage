using System;

namespace Array
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            //배열 초기화 하는 방법 
            string[] array1 = new string[3] {"안녕", "Hello", "Hi"};
            string[] array2 = new string[] {"hello", "안녕", "Hi"};
            string[] array3 = {"hi", "hi", "hello"};

            Console.WriteLine("Array1 ....");
            foreach (var st in array1)
            {
                Console.WriteLine("{0}",st);
            }
            Console.WriteLine("Array2 ....");
            foreach (var st in array2)
            {
                Console.WriteLine("{0}",st);
            }
            Console.WriteLine("Array3 ....");
            foreach (var st in array3)
            {
                Console.WriteLine("{0}",st);
            }
            
        }
    }
}