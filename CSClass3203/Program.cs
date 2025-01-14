﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csclass_3203
{
    internal class Program
    {
        public static int number = 0;

        private static object box;

        static void Main(string[] args)
        {
            // 클래스 개요, 사용 예제 
            Car car = new Car();
            // 객체를 먼저 선언한 후, 오류나는 곳에 Alt+Enter -> 새 형식으로 class 만들기 클릭

            car.SetInTime();
            car.SetOutTime();
            // 메서드를 선언한 후, 오류나는 곳에 Alt+Enter -> 메서드 만들기 클릭 -> 함수 구현

            
            // 랜덤 클래스
            Random random = new Random();
            Console.WriteLine(random.Next(10, 100));
            Console.WriteLine(random.NextDouble());
            Console.WriteLine(random.NextDouble() * 10+"\n");


            // 리스트 클래스
            /*
            List<int> list = new List<int>();
            
            list.Add(3);
            list.Add(2);
            list.Add(0);
            list.Add(3);
            */

            List<int> list = new List<int>() { 3,2,0,3 }; // 한번에 추가 가능
            list.Remove(0); // 0이라는 값을 지운다

            foreach (var item in list) // foreach문을 사용하도록 하자
            {
                Console.WriteLine("Count:"+list.Count + "\titem:"+item);
            }
            Console.WriteLine();


            // Math 클래스
            Console.WriteLine(Math.Abs(-52273));     // 절대값
            Console.WriteLine(Math.Ceiling(52.273)); // 올림
            Console.WriteLine(Math.Floor(52.273));   // 내림
            Console.WriteLine(Math.Max(52, 273)); 
            Console.WriteLine(Math.Min(52, 273));
            Console.WriteLine(Math.Round(52.273));   // 반올림
            Console.WriteLine(Math.PI+"\n");


            // 클래스 생성 예제
            Hamburger nyam = new Hamburger(); // 파일 이름이 food.cs이지만 오류나지 않음

            // 클래스 변수 예제
            Product productA = new Product();
            productA.name = "포켓몬빵";
            productA.price = 1500;

            /* 인스턴스 변수를 생성과 동시에 초기화 (C#의 고유 문법) */
            Product productB = new Product() { name = "소금빵", price = 2000 };
            Product productC = new Product() { price = 3000, name = "바게트"}; // { }에서 작성하는 것은 순서 바뀌어도 상관 X
            Product productD = new Product() { name = "구름빵" };


            /*
            List<Student> students = new List<Student>();
            students.Add(new Student() { name = "김민정", grade = 3 });
            students.Add(new Student() { name = "이미림", grade = 2 });
            students.Add(new Student() { name = "나미림", grade = 1 });
            students.Add(new Student() { name = "유민진", grade = 3 });
            students.Add(new Student() { name = "김태은", grade = 2 });
            students.Add(new Student() { name = "이광수", grade = 1 });
            */

            List<Student> students = new List<Student>()
            {
            new Student() { name = "김민정", grade = 3 },
            new Student() { name = "이미림", grade = 2 },
            new Student() { name = "나미림", grade = 1 },
            new Student() { name = "유민진", grade = 3 },
            new Student() { name = "김태은", grade = 2 },
            new Student() { grade = 1, name = "이광수" }
            };

            for(int i = students.Count -1; i >= 0; i--)
            {
                if (students[i].grade > 2)
                {
                    students.RemoveAt(i);
                }
            }

            foreach (var item in students)
            {
                Console.WriteLine(item.name+" : "+item.grade);
            }


            Method method = new Method();
            Console.WriteLine("\n" + method.Multi(52.1, 273));
            Console.WriteLine(method.Sum(1, 100));
            Console.WriteLine(method.Multiply(1, 10));
            Console.WriteLine(Method.Abs(100)+"\n");
            // Console.WriteLine(method.Abs(100)); - 불가능 (Java는 가능)


            // Method Overloding
            // int
            Console.WriteLine(MyMath.Abs(52));
            Console.WriteLine(MyMath.Abs(-52));

            // double
            Console.WriteLine(MyMath.Abs(52.273));
            Console.WriteLine(MyMath.Abs(-52.273));

            // long
            Console.WriteLine(MyMath.Abs(2223456789L));
            Console.WriteLine(MyMath.Abs(-2223456789));
            Console.WriteLine();


            // 생성자
            Product p1 = new Product("감자", 3000);
            Product p2 = new Product("고구마", 5000);
            Console.WriteLine(Product.counter + "개 생성되었습니다\n");

            // 정적 생성자
            /*
            Console.WriteLine("첫번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("두번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("세번째 위치\n");
            */
           
            Console.WriteLine("첫번째 위치");
            Sample sample = new Sample();
            Console.WriteLine("두번째 위치");
            Console.WriteLine(Sample.value);
            Console.WriteLine("세번째 위치\n");


            // 속성
            Box1 box1 = new Box1(10, 10); // public 변수 형식
            box1.width = -10;
            Console.WriteLine("box1의 면적은 " + box1.Area());

            Box2 box2 = new Box2(10, 10); // Java 형식
            box2.setWidth(10);
            Console.WriteLine("box2의 면적은 " + box2.Area());

            Box box = new Box(10, 10);
            box.Width = -10;
            Console.WriteLine("box의 면적은" + box.Area+"\n"); // 메서드에 () 작성하지 않음


            // 재귀 메서드(피보나치) 
            Console.WriteLine(Fibonacci.Get(1));
            Console.WriteLine(Fibonacci.Get(10));
            Console.WriteLine(Fibonacci.Get(100));

            // 상속과 다형성 소개
            /*
             List<Dog> Dogs = new List<Dog>() { new Dog(), new Dog(), new Dog() };
             List<Cat> Cats = new List<Cat>() { new Cat(), new Cat(), new Cat() };

              foreach(var item in Dogs)
              {
                  item.Eat();
                  item.Sleep();
                  item.Bark();
              }
              foreach (var item in Cats)
              {
                  item.Eat();
                  item.Sleep();
                  item.Meow();
              }
              */
            List<Animal> animals = new List<Animal>() {
                new Dog(), new Dog(), new Dog(),
                new Cat(), new Cat(), new Cat()
            };

            foreach(var item in animals)
            {
                item.Eat();
                item.Sleep();

                if(item is Dog)
                {
                    // item.Bark(); 이런거 안됨! (시험내기 좋다..)
                    ((Dog)item).Bark();
                }
                else
                {
                    ((Cat)item).Meow();
                }
            }

            foreach (var item in animals)
            {
                item.Eat();
                item.Sleep();
                
                var dog = item as Dog;
                if(dog != null) { dog.Bark(); }

                var cat = item as Cat;
                if (cat != null) { cat.Meow(); }
            }


            Parent parent = new Parent();
            Child child = new Child();
            parent.CountParent();

            child.CountChild();
            Console.WriteLine("p counter : " + Parent.counter + " / c counter : " + Child.counter);

            parent.CountParent();
            Console.WriteLine("p counter : " + Parent.counter + " / c counter : " + Child.counter);

            child.CountParent();
            Console.WriteLine("p counter : " + Parent.counter + " / c counter : " + Child.counter+"\n");

            // 섀도잉
            int number = 20;
            Console.WriteLine(number);

            // 하이딩
            Child c = new Child();
            Console.WriteLine(c.variable);
            Console.WriteLine(((Parent)child).variable);
            
            c.Method();
            ((Parent)c).Method();
            c.Method2();
            ((Parent)c).Method2();

            foreach(var item in animals)
            {
                item.Eat();
            }

        }
    }  
}