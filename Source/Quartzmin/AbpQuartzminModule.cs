using Abp.Configuration.Startup;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quartzmin
{
    [DependsOn(typeof(Abp.AspNetCore.AbpAspNetCoreModule))]
    [DependsOn(typeof(Abp.Quartz.AbpQuartzModule))]
    public class AbpQuartzminModule : AbpModule
    {
        public override void PreInitialize()
        {
            base.PreInitialize();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(AbpQuartzminModule).GetAssembly());
        }
    }

}

namespace Quartzmin.Controllers
{
    [IgnoreAntiforgeryToken]
    public abstract partial class PageControllerBase : Abp.Dependency.ITransientDependency
    {

    }

}

