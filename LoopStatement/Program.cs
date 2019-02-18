/*
 * 반복문 : 특정 조건을 만족하는 동안 코드 또는 코드 블록을 계속 반복해서 실행하도록 하는 문장.
 * 종류 : while , do while , for , foreach 
 */

using System;

namespace LoopStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            /*
             * while (조건식){ 반복실행할 코드 }
             */
            int a = 10;

            while (a > 0)
            {
                Console.WriteLine("while number"+a--);
            }
            Console.WriteLine("while end " + a );
            
            /*
             * do { 반복실행할 코드 } while( 조건식 );
             */
            do
            {
                Console.WriteLine("do while number " + a++);
            } while (a < 10);
            
            Console.WriteLine("do while end " + a );
            
            /*
             * for ( 초기화식; 조건식; 반복식){ 반복실행할 코드 }
             * 초기화식 : 반복을 실행하기 전에 가장 먼저, 한 번만 실행되는 코드, 반복문에서 사용하는 변수 등을 이곳에서 초기화
             * 조건식 : 반복을 계속 수행할지를 결정하는 식, 결과가 false가 되면 반복을 중단
             * 반복식 : 반복이 끝날때마다 실행, 조건식에서 사용하는 변수의 값을 조정 
             */

            for (int x = 0; x < 5; x++)
            {
                Console.WriteLine("for number" + x);
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            
            
           /*
            * foreach :     배열또는 컬렉션을 순회하며 각 데이터 요소에 차례대로 접근하도록 한다.
            * foreach(데이터형식 변수명 in 배열&컬렉션) { 코드 } 
            */
            int[] arr = new int[] {0, 1, 2, 3, 4};
            foreach (int each in arr)
            {
                Console.WriteLine("foreach number" + each);
            }
        }
    }
}