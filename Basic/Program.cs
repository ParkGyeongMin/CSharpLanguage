/*
 * namespace : 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 델리게이트, 열거 형식 등을 하나의 이름 아래 묶는 일
 * internal : 동일한 어셈블리의 코드에서는 형식이나 멤버에 액세스할 수 있지만 다른 어셈블리의 코드에서는 액세스할 수 없다. // 액세스한정자
 * Method : C프로그래밍 언어에서는 함수(Function), 객체지향 프로그래밍에서는 모든 것이 객체이고, 함수는 객체의 일부로서 존재 
 */

using System;

namespace Basic
{
    internal class Program
    {   
        // 열거 형식 선언할 때 첫번째 요소는 직접입력, 두 번째 요소부터 자동값 할당 
        public enum Dialog{ yes = 10 , no , cancel , confirm = 50 , ok }
        
        // 한정자 , 반환형식 , 메소드이름, 매개변수        
        public static void Main(string[] args)
        {
            //변수 (Variable)
            int x ; // 데이터 형식, 변수명
            
            //초기화 ( Initialization) : 변수에 최초의 데이터를 할당 하는 것 
            x = 100; 
            
            // CLR(Garbage Collector) : 프로그램 뒤에숨어 동작하면서 힙에 더 이상 사용하지 않는 객체가 있으면 그 객체를 쓰레기로 간주하고 수거하는 기능
            
            Console.WriteLine((int)Dialog.yes);
            Console.WriteLine((int)Dialog.cancel);
            Console.WriteLine((int)Dialog.ok);
            
            //var : 약한 형식 검사 , 반드시 선언과 동시에 초기화 해줘야 한다. 지역변수로만 사용 가능 
            var a = 100;
            var b = "string";
            
            Console.WriteLine(a);
            Console.WriteLine(b);




        }
    }
        
}
