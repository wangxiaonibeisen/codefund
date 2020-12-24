using System;
using System.Threading;

namespace SimpleTest
{
    using static System.Math;
    enum WeekDay{Sun,Mon,Tue,Wed,Thu,Fir,Sat};
    class IndexTest
    {
        private IndexTest[] itList;
        private int size;
        public string Neme { set; get; }
        public IndexTest()
        {

        }
        public IndexTest(int size){
            this.size = size;
            itList = new IndexTest[size];
            for (int i = 0; i < size; i++)
            {
                IndexTest tmp = new IndexTest() { Neme = "wang1" };
                itList[i] = tmp;
            }
        }
        public IndexTest this[int index]
        {
            get
            {
                IndexTest a;
                if (index >= 0 && index <= size - 1)
                {
                    a = itList[index];
                }
                else
                {
                    a = null;
                }
                return (a);
            }
            set
            {
                if (index >= 0 && index <= size - 1)
                {
                    itList[index] = value;
                }
            }
        }
        public override string ToString()
        {
            return "Name=" + Neme;
        }
        //static unsafe void Main()
        //{
        //    A aarray = new A(4);
        //    A a1 = new A() { Neme = "wang1" };
        //    A a2 = new A() { Neme = "wang2" };
        //    A a3 = new A() { Neme = "wang3" };
        //    A a4 = new A() { Neme = "wang4" };
        //    aarray[0] = a1;
        //    aarray[1] = a2;
        //    aarray[2] = a3;
        //    aarray[4] = a4;
        //    for (int i = 0; i < aarray.size; i++)
        //    {
        //        Console.WriteLine(aarray[i].ToString());
        //    }
        //    int* a, b;
        //    int *c;
        //}
    }
    //public class MainClass
    //{ 
    //    static void Main()
    //    {
    //        var t = PI;
    //        double str = 4.5;
    //        Console.WriteLine(str);
    //        int a = Convert.ToInt32(str);
    //        Console.WriteLine("{0}", a);

    //    }
    //}
}