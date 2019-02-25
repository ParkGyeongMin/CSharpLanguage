using System;

namespace ExceptionHandling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = {1, 2, 3};

            try // 실행하고자 하는 코드 
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(arr[i]);
                }
            }
            /*
             * System.Exception 클래스를 이용하면 하나의 catch로 처리할 수 있다.
             * But, 섬세한 예외 처리예외 처리가 필요한 코드에서 Exception을 무조건 사용하는것은 금지.
             */
            catch (IndexOutOfRangeException e) 
            {
                Console.WriteLine(e.Message);
            }
            
            //throw

            try
            {
                DoSome(1);
                DoSome(5);
                DoSome(9);
                DoSome(11);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }

        static void DoSome(int arg)
        {
            if (arg < 10)
            {
                Console.WriteLine("arg : {0}",arg);
            }
            else
            {
                throw new Exception("arg가 10보다 큽니다."); // throw를 통해 던져진 예외는 catch문을 통해 받는다. 
            }
        }
    }
}