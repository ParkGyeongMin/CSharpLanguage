/*
 * namespace : 성격이나 하는 일이 비슷한 클래스, 구조체, 인터페이스, 델리게이트, 열거 형식 등을 하나의 이름 아래 묶는 일
 * internal : 동일한 어셈블리의 코드에서는 형식이나 멤버에 액세스할 수 있지만 다른 어셈블리의 코드에서는 액세스할 수 없다. // 액세스한정자
 * Method : C프로그래밍 언어에서는 함수(Function), 객체지향 프로그래밍에서는 모든 것이 객체이고, 함수는 객체의 일부로서 존재 
 */

using System;
using System.CodeDom;

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
            
            // OverFlow
            uint over = uint.MaxValue;
            
            Console.WriteLine(over);
            over += 1;
            Console.WriteLine(over);
            
            /*
             * Boxing & UnBoxing
             * object형식은 참조 형식이기 때문에 힘에 데이터 할당, int, double은 값형식이기 때문에 스텍에 데이터 할당 .
             *
             * Boxing : object형식은 값 형식의 데이터를 힙에 할당하기 위한 기능 제공 
             * UnBoxing : 박싱되어 있는 값을 꺼내 값 형식 변수에 저장하는 과정 
             */

            int box = 123;
            object ob_box = (object) box; // box에 담긴 값을 박싱해서 힙에 저장 
            int box2 = (int) ob_box; // ob_box에 담긴 값을 언박싱 해서 저장 
            
            Console.WriteLine(box);
            Console.WriteLine(ob_box);
            Console.WriteLine(box2);
            
            /*
             * 상수(Constants) : 안에담긴 데이터를 절대 바꿀 수 없는 메모리 공간 
             */
            const int consts = 100;
            // consts = 200; // Error 
            
            
            /*
             * 사용자로부터 사각형의 너비와 높이를 입력받아 넓이를 계산. 
             */
            Console.WriteLine("사각형의 너비를 입력하세요");
            string width = Console.ReadLine();
                
            Console.WriteLine("사각형의 높이를 입력하세요");
            string height = Console.ReadLine();
            // 형변환
            Console.WriteLine("사각형의 넓이는 : " + int.Parse(width) * int.Parse(height));
            
            
            
        }

    }
        
}
