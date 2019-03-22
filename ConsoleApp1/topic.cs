using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arithmetic
{
   public class random
    {
       //随机整数
        public static string integer(int scope)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());  //随机整数
            return random.Next(0, scope).ToString();
        }

        //生成题目
        public static string topicfour(int scope)
        {
            string ret;
            ret = integer(scope) + " " + operators() + " " + integer(scope) + " " + operators() + " " + integer(scope);
            return ret;
        }

        //随机生成运算符
        public static string operators()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode()); //随机生成运算符
            switch (random.Next(1, 5))
            {
                case 1:
                    return "＋";
                case 2:
                    return "－";
                case 3:
                    return "×";
                case 4:
                    return "÷";
            }
            return "";
        }

    }
}
