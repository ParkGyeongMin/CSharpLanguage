/*
 * 분기문 : 프로그램의 흐름을 조건에 따라 여러 갈래로 나누는 흐름제어구문. 
 */

using System;

namespace BranchingStatement
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            
            // 분기를 사용할때는 if else 같이 사용! 
            if ((a % 2) == 0)
            {
                Console.WriteLine("짝수 ");
            }
            else
            {
                Console.WriteLine("홀수");
            }
            
            //중첩 
            if (a > 0)
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine("0보다 큰 짝수 ");
                }
                else
                {
                    Console.WriteLine("0보다 큰 홀수 ");
                }
            }
            else
            {
                Console.WriteLine("0보다 작거나 같은 수 ");
            }
            
            
            
            //switch : 조건식의 결과가 가질 수 있는 다양한 경우를 한번에 평가하고 프로그램의 흐름을 가를 때 사용 

            switch (a)
            {
                case 1:
                    Console.WriteLine("하나");
                    break;
                case 2:
                    Console.WriteLine("둘");
                    break;

                    default:
                        Console.WriteLine("아는 숫자는 1, 2 밖에 없습니다. ");
                        break;
                    
                    
                
            }
        }
    }
}