/*
 * object Oriented Programming ( OOP ) : 객체 지향 프로그래밍 
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
    }
}