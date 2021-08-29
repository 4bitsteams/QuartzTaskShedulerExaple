using Quartz;
using QuartzTaskShedulerExaple.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuartzTaskShedulerExaple.Service
{
    public class JobReminder :IJob
    {
        public JobReminder()
        {

        }

        public Task Execute(IJobExecutionContext context)
        {
            Common.Logs($"JobReminder at " + DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss"), "JobReminder at " + DateTime.Now.ToString("hhmmss"));
            return Task.CompletedTask;
        }
    }
}
