using UGF.Application.Runtime;
using UGF.Factory.Runtime;
using UGF.Module.Runtime;
using UnityEngine;

namespace UGF.Module.Factory.Runtime
{
    [CreateAssetMenu(menuName = "UGF/Module.Factory/FactoryModuleBuilder", order = 2000)]
    public class FactoryModuleBuilderAsset : ModuleBuilderAsset<IFactoryModule>
    {
        protected override IApplicationModule OnBuild(IApplication application, IModuleBuildArguments<object> arguments)
        {
            var provider = new FactoryProvider();

            return new FactoryModule(provider);
        }
    }
}
