using Quartz;
using Quartz.Impl;

namespace KeepAlive
{
    class Program
    {
        static void Main(string[] args)
        {
            // construct a scheduler
            var schedulerFactory = new StdSchedulerFactory();
            var scheduler = schedulerFactory.GetScheduler();
            scheduler.Start();

            var job = JobBuilder.Create<PingJob>().Build();

            var trigger = TriggerBuilder.Create()
                            .WithSimpleSchedule(x => x.WithIntervalInMinutes(19).RepeatForever())
                            .StartNow()
                            .Build();

            scheduler.ScheduleJob(job, trigger);
        }
    }
}
