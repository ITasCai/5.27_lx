using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace collections
{
    class Program
    {
        static void Main(string[] args)

        {

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("狗蛋");
            //list.Add(false);
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            ////将 ArrayList转换为数组
            ////string[] str = new string[list.Count];
            ////str= (string[]) list.ToArray(typeof(string));
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////将 ArrayList转换为数组
            ////Array array = list.ToArray();
            ////foreach (var item in list)
            ////{
            ////    Console.WriteLine(item);
            ////}

            ////将数组添加到 ArrayList中
            //ArrayList list1 = new ArrayList(new int[] { 1,2,3});
            //string[] arr = { "A", "B", "C" };


            //ArrayList list2 = new ArrayList();
            //list2.AddRange(arr);
            ////插入
            //list2.Insert(3,"D");
            //清空
            // list2.Clear();
            //排序
            //  list2.Sort();
            //删除（指定内容）
            //list2.Remove("C");
            ////删除（指定索引）
            //list2.RemoveAt(0);
            ////反转
            //list2.Reverse();
            ////是否包含某个元素
            //list2.Contains("B");
            ////复制
            //string[] s = new string[list2.Count];
            //list2.CopyTo(s);

            //foreach (var item in s)
            //{
            //    Console.WriteLine(s);
            //}

            //foreach (string item in list2)
            //{
            //    Console.WriteLine(item);
            //}

            //先进先出
            //Queue queue = new Queue();
            //queue.Enqueue("张丹");
            //queue.Enqueue("狗蛋");
            //queue.Enqueue("王五");
            //queue.Enqueue("赵六");

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("-----------------");
            //queue.Dequeue();//删除顶部的元素

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(queue.Peek());//返回顶部（第一个）的元素

            //Console.ReadKey();

            //后进先出
            //Stack stack = new Stack();
            //stack.Push("one");
            //stack.Push("two");
            //stack.Push("three");

            //foreach (var item in stack)
            //{
            //    Console.Write(item+"\t");
            //}
            ////删除顶部元素
            //stack.Pop();
            //Console.WriteLine();
            //foreach (var item in stack)
            //{
            //    Console.Write(item + "\t");
            //}
            //Console.WriteLine();
            //Console.WriteLine(stack.Peek())； //peek只是查看顶部的元素并没有移除元素
            //Console.WriteLine("----------------");
            // Console.WriteLine(stack.Pop());  //移除了顶部元素


            Stack sk = new Stack();
            object obj = sk.Clone();
            foreach (var item in sk)
            {
                Console.WriteLine(sk);
            }

            Console.ReadKey();
        }
    }
}
