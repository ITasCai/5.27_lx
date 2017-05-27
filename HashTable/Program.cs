using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace HashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable ht = new Hashtable();
            ht.Add("1","狗蛋");
            ht.Add("2", "张三");
            ht.Add("3", "李四");
            ht.Add("4", "王五");

            //清除说有元素
           // ht.Clear();

            //循环遍历输出DictionaryEntry类型，通过DictionaryEntry类型输出键值对
            foreach (DictionaryEntry item in ht)
            {
                Console.WriteLine(item.Key.ToString()+"----"+item.Value.ToString());
            }
            //Count获取元素的个数
            Console.WriteLine("人数:"+ht.Count);

            //取值,根据键来取值
            string str = ht["1"].ToString();
            Console.WriteLine(str);
            //包含
            Console.WriteLine(ht.Contains("4"));

            //排序

            ArrayList list = new ArrayList(ht.Keys);
            list.Sort(); //按字母排序
            foreach (string  key in list)
            {
                Console.WriteLine(key+":"+ht[key]);
            }

            Console.ReadKey();
        }
    }
}
