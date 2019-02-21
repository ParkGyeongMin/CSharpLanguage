/*
 * object Oriented Programming ( OOP ) : 객체 지향 프로그래밍
 * 접근 한정자
 * public : 클래스의 내부/외부 모든 곳에서 접근할 수 있다.
 * protected 클래스의 외부에서는 접근할 수 없지만, 파생 클래스에서는 접근이 가능하다.
 * private : 클래스의 내부에서만 접근할 수 있고, 파생 클래스에서는 접근이 불가능하다.
 * internal : 같은 어셈블리에 있는 코드에 대해서만 public으로 접근할 수 있다. 다른 어셈블리에 있는 코드에서는 private와 같은 접근성을가진다.
 * protected internal : 같은 어셈블리에 있는 코드에 대해서만 protected로 접근할 수있다. 다른 어셈블리에 있는 코드에서는 private와 같은 접근성을가진다.
 */

using System;
using System.Globalization;

namespace OOPAndClass
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Name = "키티";
            kitty.Color = "하얀색";
            kitty.Meow();
            Console.WriteLine("{0} : {1}",kitty.Name,kitty.Color);

            Cat nero = new Cat();
            nero.Name = "네로";
            nero.Color = "검은색";
            nero.Meow();
            Console.WriteLine("{0} : {1}",nero.Name,nero.Color);
            
            
            Employee ho = new Employee();
            ho.SetName("Ho");
            ho.SetPosition("Waiter");
            Console.WriteLine("{0} {1}",ho.GetName(),ho.GetPosition());
            
            Console.WriteLine("Createing .....");
            ArmorSuite ironman = new IronMan();
            ironman.Initialize();
            

        }

        class Cat
        {
            public string Name;
            public string Color;

            public void Meow()
            {
                Console.WriteLine("{0} : 야옹", Name);
            }
        }
        
        //this : 나자신을 가르킨다. this.xxx 필드 , = xxx는 매개변수 
        class Employee
        {
            private string Name;
            private string Position;

            public void SetName(string Name)
            {
                this.Name = Name;  
            }

            public string GetName()
            {
                return Name;
            }

            public void SetPosition(string Position)
            {
                this.Position = Position;
            }

            public string GetPosition()
            {
                return Position;
            }
        }

        class ArmorSuite
        {
            public virtual void Initialize()
            {
                Console.WriteLine("Armored");
            }
            
        }

        class IronMan : ArmorSuite //상속
        {
            public override void Initialize()
            {
                base.Initialize(); // 상속받은 Class의 메소드를 실행 시킨다.
                Console.WriteLine("Repulsor Rays Armed");
            }
        }

        class WarMachine : ArmorSuite
        {
            public override void Initialize()
            {
                base.Initialize();
                Console.WriteLine("Double-Barrel Cannons Armed");
                Console.WriteLine("Micro-Rocket Launcher Armed");
            }
        }
    }
}