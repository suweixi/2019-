using System;
using System.Collections;
using System.Data;
using System.IO;

namespace arithmetic
{
    public class Point
    {
        //生成试题
        public static void examtest(int num, int quantity, int scope)
        {
            Hashtable fourOperations = new Hashtable();
            Console.WriteLine("正在生成题目,请稍等！");
            switch (num)
            {
                case 1:
                    for (int i = 0; i < quantity; i++)
                    {
                        string topic = (random.topicfour(scope));
                        string answer = (consequence(topic));
                        if (fourOperations.Contains(topic))
                        {
                            i--;
                            break;
                        }
                        if (Convert.ToDouble(answer) > 0)
                        {
                            fourOperations.Add(topic, answer);
                        }
                        else
                        {
                            i--;
                        }
                    }
                    break;
            }

            #region 写入TXT
            //题目的TXT
            FileStream fs = new FileStream("D:\\2019.3.20四则运算\\四则运算题目.txt", FileMode.Create);
            //答案的TXT
            FileStream da = new FileStream("D:\\2019.3.20四则运算\\四则运算的答案.txt", FileMode.Create);
            int plus = 1;
            foreach (string a in fourOperations.Keys)
            {
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题." + a + " =" + "\r\n");
                //开始写入
                fs.Write(data, 0, data.Length);
                plus++;
            }
            fs.Flush();
            fs.Close();
            plus = 1;
            foreach (string b in fourOperations.Values)
            {
                //获得字节数组
                byte[] data = System.Text.Encoding.Default.GetBytes("第" + plus + "题:" + b + "\r\n");
                //开始写入
                da.Write(data, 0, data.Length);
                plus++;
            }
            da.Flush();
            da.Close();

            #endregion
        }


        public static string consequence(string equation)
        {
            //小数与整数运算           
            string formula = equation.Replace("÷", "/");
            formula = formula.Replace("×", "*");
            formula = formula.Replace("＋", "+");
            formula = formula.Replace("－", "-");
            DataTable dt = new DataTable();
            string really_data = dt.Compute(formula, "false").ToString();
            return really_data;
        }

    }
}
