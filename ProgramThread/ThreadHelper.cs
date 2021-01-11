using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ProgramThread
{
    public class ThreadHelper
    {
        /// <summary>
        /// 并发线程数默认5个
        /// </summary>
        public int _maxThread = 5;
        /// <summary>
        /// 当前线程数
        /// </summary>
        public int _currTNum = 0;
        /// <summary>
        /// 释放资源的线程编号
        /// </summary>
        public int _sortIdx = 0;
        public WaitHandle[] whs;

        public ThreadHelper() { }

        /// <summary>
        /// 函数默认
        /// </summary>
        /// <param name="dataCount"></param>
        /// <param name="maxThread"></param>
        public ThreadHelper(int dataCount)
        {
            Init(dataCount);
        }

        /// <summary>
        /// 初始化线程数
        /// </summary>
        public void Init(int count)
        {
            //计算线程数，按数据总量计算开启线程数
            if (count > 200)
            {
                _maxThread = 15;
            }
            else if (count > 100)
            {
                _maxThread = count / 15;
            }
            else if (count > 50)
            {
                _maxThread = count / 10;
            }
            else if (count > 20)
            {
                _maxThread = count / 7;
            }
            else if (count > 10)
            {
                _maxThread = count / 3;
            }
            else if (count > 4)
            {
                _maxThread = count / 2;
            }
            else
            {
                _maxThread = 2;
            }


            //WaitHanle类MSDN上的定义: 封装了一些对象，这些对象等待着独占访问共享资源,这里相当于占用10个资源的意思
            whs = new WaitHandle[_maxThread];
            for (int i = 0; i < whs.Length; i++)
            {
                //AutoResetEvent是一个开关,设置为true时,whs占用资源对象就会自动启动. 设置为false时,只有进行 AutoResetEvent.set()之后才能启动
                whs[i] = new AutoResetEvent(false);
            }

        }
    }
}
