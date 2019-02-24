using System;
using System.Collections;

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

            //2차원 배열 
            int[,] arr = new int[2, 3] {{1, 2, 3}, {4, 5, 6}};
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write("[{0},{1}] : {2} ",i,j,arr[i,j]);
                }
                Console.WriteLine();
            }
            // 다차원 배열 
            int[,,] array = new int[4, 3, 2] {
                { {1, 2}, {3, 4}, {5, 6} },
                { {2, 3}, {4, 5}, {6, 7} },
                { {3, 4}, {5, 6}, {7, 8} },
                { {5, 6}, {7, 8}, {9, 0} }
            };

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k < array.GetLength(2); k++)
                    {
                        Console.Write("{0}",array[i,j,k]);
                    }
                    Console.Write("}");
                }
                Console.WriteLine();
            }
            
            // ArrayList 
            ArrayList list = new ArrayList();
            for (int i = 0; i < 5; i++)
            {
                list.Add(i);
            }

            foreach (var li in list)
            {
                Console.Write(li);
            }
            Console.WriteLine();
            list.RemoveAt(2);
            foreach (var li in list)
            {
                Console.Write(li);
            }
            
            Console.WriteLine();
            list.Insert(2,2);
            foreach (var li in list)
            {
                Console.Write(li);
            }
            Console.WriteLine();
            list.Add("sss");
            list.Add("ddd");
            
            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i]);
            }
            /*
             * Queue : FIFO(First In First Out) 
             */
            
            Queue que = new Queue();
            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);
            que.Enqueue(5);
            
            Console.WriteLine();
            Console.WriteLine("Queue");
            while (que.Count > 0)
            {
                Console.WriteLine(que.Dequeue());
            }
            
            /*
             * Stack : LIFO(Last In First Out) 
             */
            Console.WriteLine("Stack");

            Stack stack = new Stack();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop());
            }
            
            /*
             * HashTable
             */
            
            Console.WriteLine("HashTable");
            Hashtable ht = new Hashtable();
            ht["0"] = "ONE";
            ht["1"] = "Two";
            ht["2"] = "Three";
            ht["3"] = "Four";
            ht["4"] = "Five";
            Console.WriteLine(ht["0"]);
            
            
        }
    }
}