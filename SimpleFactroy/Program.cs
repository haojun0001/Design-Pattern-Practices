using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            while (1 == 1)
            {
                try
                {
                    Console.Write("输入数字A：");
                    string strNumberA = Console.ReadLine();
                    Console.Write("输入运算符（+、-、*、/）：");
                    string strOperate = Console.ReadLine();
                    Console.Write("输入数字B：");
                    string strNumberB = Console.ReadLine();
                    Operation operation = OperationFactroy.CreateOperate(strOperate);
                    operation.NumberA = Convert.ToDouble(strNumberA);
                    operation.NumberB = Convert.ToDouble(strNumberB);
                    Console.WriteLine("结果是:" + Convert.ToString(operation.GetResult()));
                }
                catch (Exception ex)
                {
                    Console.WriteLine("输入有误：" + ex.Message);
                }
                Console.ReadLine();
            }
        }
    }
}
