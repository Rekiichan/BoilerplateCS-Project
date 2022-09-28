using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyPrjTest.Authorization;

namespace MyPrjTest
{
    [DependsOn(
        typeof(MyPrjTestCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MyPrjTestApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MyPrjTestAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MyPrjTestApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
