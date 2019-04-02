using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Rotam.Authorization;

namespace Rotam
{
    [DependsOn(
        typeof(RotamCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class RotamApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<RotamAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(RotamApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
