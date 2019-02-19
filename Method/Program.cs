/*
 * Method : 객체 지향 프로그래밍 언어에서 사용하는 용어, 일련의 코드를 하나의 이름 아래 묶는 것
 */

using System;
using System.Diagnostics.CodeAnalysis;

namespace Method
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Plus Value : " + Calculator.Plus(3,4));
            Console.WriteLine("Minus Value : " + Calculator.Minus(4,2));
            Console.WriteLine("Fibo : " + Fibo(4));

            int a = 2;
            int b = 3;

            Swap.ValueSwap(a, b);
            Console.WriteLine("Swap value x:{0}, y:{1} ", a , b);
            
            
            // 참조의 의한 매개 변수 전달은 ref 키워드를 적어준다. 
            Swap.ReferenceSwap(ref a ,ref b);
            Console.WriteLine("Swap value x:{0}, y:{1} ", a , b);
            
            // Overloading 
            Console.WriteLine("Overloading int : " +  Overloading.plus(3,4));
            Console.WriteLine("Overloading double : " + Overloading.plus(3.2,4.1));
            Console.WriteLine("Overloading float : " + Overloading.plus(2.1f,4.5f));

            int sum = Overloading.Sum(1, 2, 3, 4, 5, 6, 7, 8, 9, 10);
            Console.WriteLine("Overloading Sum : " + sum);

        }

        static int Fibo(int n)
        {
            if (n < 2)
                return n;
            else
                return Fibo(n - 1) + Fibo(n - 2);
        }
    }
    
    // Plus / Minus , Method 
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }

        public static int Minus(int a, int b)
        {
            return a - b;
        }
    }
    
    /*
     * Call by Value : 값에 의한 호출, 값 자체를 전달 
     * Call by Reference : 참조에 의한 호출, 값이 아닌 주소를 전달 
     */

    class Swap
    {
        public static void ValueSwap(int a, int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }

        public static void ReferenceSwap(ref int a, ref int b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
    }
    
    /*
     * Overloading : 하나의 메소드 이름에 여러 개를 구현 , 즉 함수 이름은 동일하나 매개변수의 타입 및 갯수가 달라야 한다. 
     */

    class Overloading
    {
        public static int plus(int a, int b)
        {
            return a + b;
        }

        public static double plus(double a, double b)
        {
            return a + b;
        }

        public static float plus(float a, float b)
        {
            return a + b ;
        }
        
        // 가변길이 매개변수 
        public static int Sum(params int[] args)
        {
            int sum = 0;
            for (int i = 0; i < args.Length; i++)
            {
                sum += args[i];
            }
            return sum;
        }
        
    }

    
}