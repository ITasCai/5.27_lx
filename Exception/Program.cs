using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewException
{
    class Program
    {
        static void Main(string[] args)
        {
            #region  throw抛出异常

            //string s = null;
            //if (s==null)
            //{
            //    throw new ArgumentNullException();
            //}

            #endregion

            #region  try catch

            //try
            //{
            //    string s = null;
            //    Test(s);
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}

            //Console.ReadKey();

            #endregion

            #region finally语句

            //int i = 3;
            //try
            //{

            //    string s = "abc";
            //    object obj = s;
            //    i = (int)obj;
            //}
            //catch (InvalidCastException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    Console.WriteLine(i);
            //}


            #endregion


            #region 
            //string[] arrayName = new string[] { "张三", "李四", "王五" };

            //try
            //{

            //    for (int i = 0; i < 6; i++)
            //    {
            //        Console.WriteLine(arrayName[i]);
            //    }
            //}
            //catch (IndexOutOfRangeException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    Console.WriteLine(arrayName[0]);
            //}



            //int a = 0;
            //try
            //{
            //    a = int.Parse("2");
            //    a = a / 0;
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}


            #endregion


            #region checked和nuchecked
            //checked
            //short num1 = 999;
            //byte num2=0;

            //try
            //{
            //    // num2 = checked((byte)num1); //溢出
            //    num2 = unchecked((byte)num1);  //忽略溢出
            //   // string str = num2.ToString();
            //    int num3 = num2 / 0;

            //}
            //catch (OverflowException ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}
            //catch (Exception ex) {
            //    Console.WriteLine(ex.Message);
            //}
            //finally {
            //    Console.WriteLine(num2);
            //}

            #endregion


            #region 

            byte a, b, result;
            a = 255;b = 3;

            try
            {
                unchecked {
                    result = (byte)(a + b);
                    Console.WriteLine("unchecked result:"+result);
                }

                checked {
                    result = (byte)(a + b);
                    Console.WriteLine("unchecked result:" + result);
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }


            #endregion

            Random rdm = new Random(unchecked((int)DateTime.Now.Ticks));

            Console.ReadKey();
        }

        private static void Test(string s)
        {
            if (s == null)
            {
                throw new ArgumentNullException();
            }
        }
    }
}
