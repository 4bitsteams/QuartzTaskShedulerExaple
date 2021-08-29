using Microsoft.Extensions.DependencyInjection;
using Quartz;
using Quartz.Spi;
using QuartzTaskShedulerExaple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuartzTaskShedulerExaple.Service
{
    public class SingletonJobFactory : IJobFactory
    {
        private readonly IServiceProvider serviceProvider;

        public SingletonJobFactory(IServiceProvider serviceProvider)
        {
            this.serviceProvider = serviceProvider;
        }

        public IJob NewJob(TriggerFiredBundle bundle,IScheduler scheduler)
        {
            Common.Logs($"NewJob at " + DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss"), "NewJob at " + DateTime.Now.ToString("hhmmss"));
            return this.serviceProvider.GetRequiredService(bundle.JobDetail.JobType) as IJob;
        }

        public void ReturnJob(IJob job)
        {

        }
    }
}
