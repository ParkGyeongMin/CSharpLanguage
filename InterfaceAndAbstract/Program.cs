/*
 * 인터 페이스(Interface) : 인스턴스를 가질 수 없으며, 인터페이스를 상속받는 클래스의 인스턴스를 만드는 것은 가능하다.
 * 파생 클래스는 인터페이스에서 선언되어 있는 모든 메소드를 구현해줘야 하며, 이 메소드들은 public으로 해야한다. 
 * 추상 클래스(Abstract Class): 인터페이스와 달리 "구현"을 가질 수 있다. 하지만 클래스와는 달리 인스턴스를 가질 수 없다.
 * 한정자를 명시하지 않으면 모든 메소드가 private로 선언된다. 추상 메소드(abstract Method)를 가질수 있다.
 * 접근 한정자를 명시 하자!!!
 */

using System;

namespace InterfaceAndAbstract
{
    internal class Program
    {
        class MainApp
        {
            public static void Main(string[] args)
            {
                FlyingCar car = new FlyingCar();
                car.Run();
                car.Fly();
                IRunnable runnble = car as IRunnable;
                runnble.Run();
                IFlyable flyable = car as IFlyable;
                flyable.Fly();
                
                AbstractBase obj = new Derived();
                obj.AbstractMethodA();
                obj.PublicMethodA();
            }
        }
        //인터페이스 
        interface IRunnable
        {
            void Run();
        }

        interface IFlyable
        {
            void Fly();
        }

        class FlyingCar : IRunnable, IFlyable
        {
            public void Run()
            {
                Console.WriteLine("Run Run!");
            }

            public void Fly()
            {
                Console.WriteLine("Fly Fly!");
            }
        }

        //추상클래스
        abstract class AbstractBase
        {
            protected void PrivateMethodA()
            {
                Console.WriteLine("AbstractBase.PrivateMethodA()");
            }

            public void PublicMethodA()
            {
                Console.WriteLine("AbstractBase.PublicMethodA()");
            }

            public abstract void AbstractMethodA();
        }

        class Derived : AbstractBase
        {
            public override void AbstractMethodA()
            {
                Console.WriteLine("Derived.AbstractMethodA()");
                PrivateMethodA();
            }
        }
    }
}