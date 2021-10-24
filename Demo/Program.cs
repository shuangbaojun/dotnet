using System.Threading;
using System;

namespace Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);  // 开辟了一个新的线程 Thread
            t.Name = "Y Thread ...";
            t.Start();  //运行 WriteY();

            // 同时在主线程也在做一些工作
            for (var i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }

        static void WriteY()
        {
            for (var i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
    }

}