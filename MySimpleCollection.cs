using System;
using System.Collections.Generic;
using System.Collections;
using System.Collections.Concurrent;
using System.Text;
using System.Linq;

namespace ConsoleApp1
{
    class Node<T>
    {
        public T Data { get; set; }
        public Node<T> Next { get; set; }
        public Node<T> Pre { get; set; }
    }
    struct PersonNode
    {
        string name;
        int age;
        public PersonNode(string name,int age)
        {
            this.name = name;
            this.age = age;
        }
        public new string ToString()
        {
            return $"name is {name} and age is {age}";
        }
    }
    class MySimpleCollection
    {
        public void TestArrayList()
        {
            ArrayList tmpArrayList = new ArrayList();
            /*Console.WriteLine("默认容量是{0}",tmpArrayList.Capacity);//默认容量为0*/
            tmpArrayList.Capacity = 8;
            /*Console.WriteLine("更改后容量是{0}", tmpArrayList.Capacity);*/
            PersonNode pOne = new PersonNode("wang", 24);
            int[] addRangeData = new int[3] { 2, 3, 4 };
            tmpArrayList.Add(1);
            tmpArrayList.Add(1.2);
            tmpArrayList.Add(1);
            tmpArrayList.Add(1);
            tmpArrayList.Add("7");
            tmpArrayList.Add("7");
            tmpArrayList.Add(false);
            tmpArrayList.Add(1);
            /*tmpArrayList.Add(pOne);*/
            tmpArrayList.InsertRange(4, addRangeData);
            tmpArrayList.AddRange(addRangeData);
            Console.WriteLine("扩容后容量是{0}", tmpArrayList.Capacity);
            tmpArrayList.TrimToSize();
            Console.WriteLine("扩容后容量是{0}", tmpArrayList.Capacity);
            /*Console.WriteLine("扩容后容量是{0}", tmpArrayList.Capacity);//超过默认长度或是设定值时，两倍扩增*/
            /*Console.WriteLine("BinarySearch find 7 result is {0}",tmpArrayList.BinarySearch("7"));//？？？？？？？返回元素第一次出现在数组中的下标*/
            /*foreach (var item in tmpArrayList)
            {
                *//*Console.WriteLine(item.GetType());*//*
                Console.WriteLine(item);
            }*/
            IEnumerator item= tmpArrayList.GetEnumerator();
            while (item.MoveNext())
            {
                var iData = item.Current;
                Console.WriteLine(iData);
            }
        }
        public void TestLinkedList()
        {
            LinkedList<int> tmpLinkedList = new LinkedList<int>();
            for (int i = 0; i < 10; i++)
            {
                tmpLinkedList.AddLast(i);
            }
            tmpLinkedList.AddFirst(11);
            LinkedListNode<int> node=new LinkedListNode<int>(4);
            if (tmpLinkedList.Contains(5))
            {
                node = tmpLinkedList.Find(5);
            }
            
            tmpLinkedList.AddAfter(node, 12);
            /*tmpLinkedList.AddBefore(new LinkedListNode<int>(12), 13);*/
            Console.WriteLine("foreach-------------");
            foreach (var itemLing in tmpLinkedList)
            {
                Console.WriteLine(itemLing.ToString());
            }
            Console.WriteLine("Enumerator------------");
            LinkedList<int>.Enumerator item = tmpLinkedList.GetEnumerator();
            while (item.MoveNext())
            {
                int iData = item.Current;
                Console.WriteLine(iData);
            }
        }
        public void TestList()
        {
            List<int> tmpList = new List<int>();
            Predicate<int> match= i =>i>3;
            Console.WriteLine("初始化容量为：{0}", tmpList.Capacity);
            for (int i = 0; i < 10; i++)
            {
                tmpList.Add(i);
            }
            Console.WriteLine("扩容后容量为：{0}", tmpList.Capacity);

            Console.WriteLine("Ling查询结果----------");
            Console.WriteLine("foreach遍历结果----------");
            var tmplist2= tmpList.Where(l => l > 3).ToList();
            foreach (var item in tmplist2)
            {
                Console.WriteLine(item.ToString());
            }
            if (tmpList.Exists(match))
            {
                List<int> findResult=tmpList.FindAll(match);
                Console.WriteLine("foreach遍历结果----------");
                foreach (var item1 in findResult)
                {
                    Console.WriteLine(item1.ToString());
                }
                Console.WriteLine("Enumerator遍历结果----------");
                List<int>.Enumerator item = findResult.GetEnumerator();
                while (item.MoveNext())
                {
                    int number = item.Current;
                    Console.WriteLine(number);
                }
            }
        }
        public void TestSortList()
        {
            SortedList<string, string> tmpSList = new SortedList<string, string>();
            tmpSList.Add("zhao", "one");
            tmpSList.Add("qian", "one");
            tmpSList.Add("sun", "two");
            tmpSList.Add("li", "three");
            
            foreach (var item in tmpSList)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }

        public void TestDictionnary()
        {
            Dictionary<string, string> tmpDic = new Dictionary<string, string>();
            tmpDic.Add("zhao", "one");
            tmpDic.Add("qian", "one");
            tmpDic.Add("sun", "two");
            tmpDic.Add("li", "three");
            /*Console.WriteLine(tmpDic.ContainsKey("zhao"));
            Console.WriteLine(tmpDic.TryAdd("zhou","four"));
            string liClass;
            Console.WriteLine(tmpDic.TryGetValue("li",out liClass));
            Console.WriteLine(liClass);*/

            Console.WriteLine("foreach---------");
            foreach (var item1 in tmpDic)
            {
                Console.WriteLine(item1.ToString());
            }
            tmpDic.Remove("sun");
            /*var resDis=tmpDic.Distinct();*/
            Console.WriteLine("foreach---------");
            foreach (var item1 in tmpDic)
            {
                Console.WriteLine(item1.ToString());
            }
            tmpDic.Add("wang", "one");
            foreach (var item1 in tmpDic)
            {
                Console.WriteLine(item1.ToString());
            }
            /*Dictionary<string, string>.Enumerator item = tmpDic.GetEnumerator();
           
            while (item.MoveNext())
            {
                KeyValuePair<string,string> iEntry = item.Current;
                Console.WriteLine(iEntry.Key + "  " + iEntry.Value);
            }*/
        }
        public void TestSortedDic()
        {
            SortedDictionary<string, string> tmpSortDic = new SortedDictionary<string, string>();
            tmpSortDic.Add("zhao", "one");
            
            tmpSortDic.Add("qian", "one");
            tmpSortDic.Add("sun", "two");
            tmpSortDic.Add("li", "three");
            
            foreach (var item in tmpSortDic)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }

            tmpSortDic.Remove("zhao");

            foreach (var item in tmpSortDic)
            {
                Console.WriteLine(item.Key + "  " + item.Value);
            }
        }
        public void TestHashSet()
        {
            HashSet<int> tmpHashSet = new HashSet<int>();
            
            for (int i = 0; i < 10; i++)
            {
                tmpHashSet.Add(i);
            }
            for (int i = 0; i < 10; i++)
            {
                tmpHashSet.Add(i);
            }
            foreach (var item in tmpHashSet)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void TestHashTable()
        {
            Hashtable tmpHTable = new Hashtable();
            tmpHTable.Add("name", "wang");
            tmpHTable.Add("Age", 24);
            tmpHTable.Add("IsFemale", true);
            /*PersonNode p = new PersonNode("wang", 24);
            tmpHTable.Add(p, 1);*/
            foreach (DictionaryEntry item in tmpHTable)
            {
                Console.WriteLine(item.Key+"  "+item.Value);
            }
            IDictionaryEnumerator item2 = tmpHTable.GetEnumerator();
            while (item2.MoveNext())
            {
                Console.WriteLine(item2.Key + "  " + item2.Value);
            }
        }

        public void TestStack()
        {
            Stack<int> tmpStack = new Stack<int>();
           
            for (int i = 0; i < 10; i++)
            {
                tmpStack.Push(i);
            }
            foreach (var item in tmpStack)
            {
                Console.WriteLine(item.ToString());
            }
        }

        public void TestQueue()
        {
            Queue<int> tmpQueue = new Queue<int>();
            tmpQueue.GetEnumerator();
            for (int i = 0; i < 10; i++)
            {
                tmpQueue.Enqueue(i);
            }
            foreach (var item in tmpQueue)
            {
                Console.WriteLine(item.ToString());
            }
        }
        /*static void Main()
        {
            MySimpleCollection mySC = new MySimpleCollection();
            mySC.TestHashTable();
            *//*mySC.TestDictionnary();
            Console.WriteLine("dictionary---------");
            mySC.TestSortedDic();
            Console.WriteLine("sortedlist---------");
            mySC.TestSortList();*//*
            
        }*/
    }
}
