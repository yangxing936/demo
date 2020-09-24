using Quartz;
using Quartz.Impl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// 定时任务
    /// </summary>
    public class QuartzTimer
    {
        public async static Task Run()
        {

            // 1.创建scheduler的引用
            ISchedulerFactory schedFact = new StdSchedulerFactory();
            IScheduler sched = await schedFact.GetScheduler();

            //2.启动 scheduler
            await sched.Start();

            // 3.创建 job
            IJobDetail job = JobBuilder.Create<SimpleJob>()
                    .WithIdentity("job1", "group1")
                    .Build();

            // 4.创建 trigger
            ITrigger trigger = TriggerBuilder.Create()
                .WithIdentity("trigger1", "group1")
                //.WithSimpleSchedule(x => x.WithIntervalInSeconds(5).RepeatForever())
                .Build();

            // 5.使用trigger规划执行任务job
            await sched.ScheduleJob(job, trigger);

        }
        public static Task Fors()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"{i}");
            }
            return null;
        }


    }

    public class SimpleJob : IJob
    {
        public virtual Task Execute(IJobExecutionContext context)
        {
            QuartzTimer.Fors();//执行的任务
            return Console.Out.WriteLineAsync("");
            //return Console.Out.WriteLineAsync($"执行作业:{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss.fff")}");
        }

    }
}
