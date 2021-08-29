using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuartzTaskShedulerExaple.Models
{
    public class MyJob
    {
        public MyJob(Type type,string Expression)
        {
            Common.Logs($"MyJob at "+DateTime.Now.ToString("dd-MMM-yyy hh:mm:ss"), "MyJob at " + DateTime.Now.ToString("hhmmss"));
            this.Type = type;
            this.Expression = Expression;
        }

        public Type Type { get; set; }

        public string Expression { get; set; }
    }
}
