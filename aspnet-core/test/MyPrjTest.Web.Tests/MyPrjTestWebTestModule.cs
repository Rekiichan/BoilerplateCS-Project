using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyPrjTest.EntityFrameworkCore;
using MyPrjTest.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace MyPrjTest.Web.Tests
{
    [DependsOn(
        typeof(MyPrjTestWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class MyPrjTestWebTestModule : AbpModule
    {
        public MyPrjTestWebTestModule(MyPrjTestEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyPrjTestWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(MyPrjTestWebMvcModule).Assembly);
        }
    }
}