using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;

namespace arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要生成的题数");
            int quantity = int.Parse(Console.ReadLine());
            Console.WriteLine("请选择输入1，整数运算");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算范围");
            int scope = int.Parse(Console.ReadLine());
            Hashtable fourOperations = new Hashtable();
            Point.examtest(num, quantity, scope);
            Console.WriteLine("生成完毕");
            Console.ReadKey();
        }
    }
}