using System;
using System.Collections.Generic;
using System.Text;
using System.MyPersonInferface;

namespace MyPersonInfo
{
    struct ChildPerson:IPersonAction
    {
        string name;
        int age;

        public string Name { get ; set; }
        public int Age { get ; set; }
        public string Sex { get; set; }

        public void Eat()
        {
            Console.WriteLine("child eat");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"child name is {Name},age is {Age},sex is {Sex}");
        }

        public void Sleep()
        {
            Console.WriteLine("child sleep");
        }
    }

    public class Person:IPersonAction
    {
        public Person()
        {
            Console.WriteLine("调用父类Person");
        }

        public virtual void Sport()
        {
            Console.WriteLine("person run");
        }

        public string Name { get; set; } = "wang";
        public int Age { get; set; } = 24;
        public string Sex { get; set; } = "female";

        public void Eat()
        {
            Console.WriteLine("person eat");
        }

        public void Sleep()
        {
            Console.WriteLine("person sleep");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"person name is {Name},age is {Age},sex is {Sex}");
        }
    }
    public class FemalePerson:Person
    {
       public FemalePerson()
        {
            Console.WriteLine("调用子类female person");
        }
        public override void Sport()
        {
            Console.WriteLine("female person sleep");
        }
        public new void Eat()
        {
            Console.WriteLine("Female person eat little food");
        }
    }
    public class MalePerson : Person
    {
        public MalePerson()
        {
            Console.WriteLine("调用子类Maleperson");
        }
        public override void Sport()
        {
            Console.WriteLine("male person sleep");
        }
    }
    class MyClassTest
    {
        public void TestFunction()
        {
            Person p = new Person();
            Console.WriteLine();
            FemalePerson fPer = new FemalePerson() { Name="zhang"};
            Console.WriteLine();
            MalePerson mPer = new MalePerson() { Age = 25, Sex = "male" };
            Console.WriteLine();
            ChildPerson cPer = new ChildPerson() { Age = 5, Name = "pu", Sex = "female kid" };
            Console.WriteLine();
            p.PrintInfo();
            fPer.PrintInfo();
            mPer.PrintInfo();
            cPer.PrintInfo();
            Console.WriteLine();
            p.Sport();
            mPer.Sport();
            Console.WriteLine();
            p.Eat();
            fPer.Eat();
            mPer.Eat();
            Console.WriteLine();
            Person p2 = fPer;
            FemalePerson fP3 = new FemalePerson();
            if (fP3 is Person)
            {
                Person p3 = fP3;
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            Person p4 = fP3 as Person;
            if (p4 != null)
            {
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine("转换失败");
            }
            bool isZhuanHuanSuccess = p4 is FemalePerson;
            Console.WriteLine(isZhuanHuanSuccess.ToString());
            FemalePerson fP5 = p2 as FemalePerson;
            if (fP5 != null)
            {
                Console.WriteLine("转换成功");
            }
            else
            {
                Console.WriteLine("转换失败");
            }
        }
    }
}
