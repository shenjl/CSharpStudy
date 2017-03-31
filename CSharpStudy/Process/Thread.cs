﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyCsharpGo
{
    /// <summary>
    /// 线程测试类
    /// </summary>
    public class MyThread
    {
        public static void Test()
        {
            //主线程
            Thread th = Thread.CurrentThread;
            Console.ReadKey();          
        }

        public static void Test1()
        {
            Thread thread = new Thread(new ThreadStart(PrintHaHa));
            thread.Start();
            if (thread.IsAlive)
            {
                Console.WriteLine("还活着，但马上要死了！");
                
                //thread.Abort(); //销毁线程

                //thread.Sleep(1000);
                Thread.Sleep(1000);     //不能设置为实例调用

                //thread.Priority = ThreadPriority.Normal; //设置优先级
                //thread.Suspend();     //挂起线程，已过时
                //thread.Resume();      //恢复线程，已过时
            }
            else
            {
                Console.WriteLine("已经挂了！");
            }
        }

        public static void Test3()
        {
            ThreadStart childref = new ThreadStart(CallToChildThread);
            // 停止主线程一段时间
            Thread.Sleep(2000);
            // 现在中止子线程
            Console.WriteLine("In Main: Aborting the Child thread");
        }

        public static void PrintHaHa()
        {
            Console.WriteLine("HaHa");
        }

        public static void CallToChildThread()
            try
                Console.WriteLine("Child thread starts");
                //计数到 10
                for (int counter = 0; counter <= 10; counter++)
            }
    }
}