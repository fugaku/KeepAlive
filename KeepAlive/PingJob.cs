using Quartz;
using System.Net;

namespace KeepAlive
{
    public class PingJob : IJob
    {
        public void Execute(IJobExecutionContext context)
        {
            using (var client = new WebClient())
            {
                client.Headers["Content-Type"] = "application/json";
                try
                {
                    var result = client.DownloadString("http://cashwebapi.apphb.com/api/test");
                }
                catch
                {
                }
            }
        }
    }
}
