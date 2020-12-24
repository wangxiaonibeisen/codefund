using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace MyThreadTesting
{
    #region
    class MyThread
    {
        /*static void Main(string[] args)
        {
            *//*Thread t1 = new Thread(new ThreadStart(TestMethod));*/
            /*Thread t2 = new Thread(new ParameterizedThreadStart(TestMethod));*//*
            Thread t3 = new Thread(TestMethod);
            *//*t1.IsBackground = true;*/
            /*t2.IsBackground = true;*/
            /*t1.Start();*//*
            t3.Start();
            
            *//*t2.Start("hello");*//*
            Console.ReadKey();
        }*/

        /*public static void TestMethod()
        {
            Console.WriteLine("不带参数的线程函数");
        }*/

        public static void TestMethod(object data)
        {
            string datastr = data as string;
            Console.WriteLine("带参数的线程函数，参数为：{0}", datastr);
        }
    }
    #endregion
}
