using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Xn.Authorization;

namespace Xn
{
    [DependsOn(
        typeof(XnCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class XnApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<XnAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(XnApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
