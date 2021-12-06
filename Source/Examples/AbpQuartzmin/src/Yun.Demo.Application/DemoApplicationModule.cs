using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Yun.Demo.Authorization;

namespace Yun.Demo
{
    [DependsOn(
        typeof(DemoCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class DemoApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<DemoAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(DemoApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
