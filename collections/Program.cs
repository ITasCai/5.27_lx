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
            string[] str = new string[list.Count];
            str= (string[]) list.ToArray(typeof(string));
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}
