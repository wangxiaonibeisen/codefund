using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class MyLingLearn
    {
        public void LinqTest()
        {
            int[] array = new int[10];
            for (int i = 0; i < 10; i++)
            {
                array[i] = i;
            }
            int[] result = array.Where(p => p > 5).ToArray();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            int[] result2 = (from i in array
                             where i > 5
                             select i).ToArray();
            foreach (var item in result2)
            {
                Console.WriteLine(item);
            }
        }
    }
}
