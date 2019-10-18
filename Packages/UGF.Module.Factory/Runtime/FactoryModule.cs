using System;
using UGF.Application.Runtime;
using UGF.Factory.Runtime;

namespace UGF.Module.Factory.Runtime
{
    public class FactoryModule : ApplicationModuleBase, IFactoryModule
    {
        public IFactoryProvider Provider { get; }

        public FactoryModule(IFactoryProvider provider)
        {
            Provider = provider ?? throw new ArgumentNullException(nameof(provider));
        }
    }
}
