using Abp.Dependency;
using Abp.Quartz;
using Quartz;
using System.Threading.Tasks;

namespace Yun.Demo.Web.Host.Controllers
{
    public class MyLogJob : JobBase, ITransientDependency
    {
        public override Task Execute(IJobExecutionContext context)
        {
            Logger.Info("Executed MyLogJob..!");
            return Task.CompletedTask;
        }
    }
}
