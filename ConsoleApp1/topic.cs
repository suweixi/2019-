using System;


namespace arithmetic
{
    public class topic
    {
        public static string integer(int scope)
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());  //随机整数
            return random.Next(1, scope).ToString();   //随机数从1开始
        }


        public static string topicfour(int scope)
        {
            string ret;
            //ret = integer(scope) + " " + operators() + " " + integer(scope);  //生成2项式题目
            ret = integer(scope) + " " + operators() + " " + integer(scope) + " " + operators() + " " + integer(scope);  //生成3项式题目
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
