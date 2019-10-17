using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            //StringBuilder build = StringBuildHelper.AppendArgs("#");
            StringBuilder build = StringBuildHelper.AppendArgs("#", "hello");
            //StringBuilder build = StringBuildHelper.AppendArgs("#", "hello", "world", "name");
            Console.WriteLine(build.ToString());
            Console.ReadKey();
        }
        public class StringBuildHelper
        {
            /// <summary>
            /// 函数传入可变个数字符串类型的参数，用指定的分隔符拼接
            /// </summary>
            /// <param name="key">分隔符</param>
            /// <param name="args">字符串类型的参数数组</param>
            /// <returns></returns>
            public static StringBuilder AppendArgs(string key,params string[] args)
            {
                StringBuilder build = new StringBuilder();
                if(args.Count() > 0)
                {
                    foreach (string item in args)
                    {
                        build.AppendFormat("{0}{1}", item, key);
                    }
                    // 移除最后一个分隔符号
                    build.Remove(build.Length - key.Length, key.Length);
                }
                return build;
            }
        }
    }
}
