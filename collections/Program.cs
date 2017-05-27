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

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("狗蛋");
            list.Add(false);
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }

            //将 ArrayList转换为数组
            //string[] str = new string[list.Count];
            //str= (string[]) list.ToArray(typeof(string));
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //将 ArrayList转换为数组
            //Array array = list.ToArray();
            //foreach (var item in list)
            //{
            //    Console.WriteLine(item);
            //}

            //将数组添加到 ArrayList中
            ArrayList list1 = new ArrayList(new int[] { 1,2,3});
            string[] arr = { "A", "B", "C" };


            ArrayList list2 = new ArrayList();
            list2.AddRange(arr);
            //插入
            list2.Insert(3,"D");
            //清空
            // list2.Clear();
            //排序
            //  list2.Sort();
            //删除（指定内容）
            list2.Remove("C");
            //删除（指定索引）
            list2.RemoveAt(0);
            //反转
            list2.Reverse();
            //是否包含某个元素
            list2.Contains("B");
            //复制
            string[] s = new string[list2.Count];
            list2.CopyTo(s);

            foreach (var item in s)
            {
                Console.WriteLine(s);
            }

            foreach (string item in list2)
            {
                Console.WriteLine(item);
            }


            Console.ReadKey();
        }
    }
}
