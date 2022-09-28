using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using MyPrjTest.Configuration;

namespace MyPrjTest.Web.Host.Startup
{
    [DependsOn(
       typeof(MyPrjTestWebCoreModule))]
    public class MyPrjTestWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public MyPrjTestWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(MyPrjTestWebHostModule).GetAssembly());
        }
    }
}
