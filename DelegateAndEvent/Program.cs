/*
 * 한정자 delegate 반환형식 델리게이트이름(매개변수) 
 */

using System;

namespace DelegateAndEvent
{
    internal class Program
    {
        delegate int Delegate(int a, int b); // 델리게이트 선언 
        
        //델리게이트는 인스턴스메소드도 참조할 수 있고, 정적 메소드도 참조할 수 있다. 
        class Cal
        {
            public int Plus(int a, int b)
            {
                return a + b;
            }

            public int Minus(int a, int b)
            {
                return a - b;
            }
            
        }
        
        public static void Main(string[] args)
        {
            Cal Cal = new Cal();
            Delegate CallBack;

            CallBack = new Delegate(Cal.Plus);
            Console.WriteLine(CallBack(3, 4));
            
            CallBack = new Delegate(Cal.Minus);
            Console.WriteLine(CallBack(4, 2));
            

        }
    }
}