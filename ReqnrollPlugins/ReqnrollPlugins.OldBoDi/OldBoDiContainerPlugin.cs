using Reqnroll.BoDi;
using Reqnroll.Infrastructure;
using Reqnroll.Plugins;
using Reqnroll.UnitTestProvider;
using ReqnrollPlugins.OldBoDi;
using ReqnrollPlugins.OldBoDi.Support;

[assembly: RuntimePlugin(typeof(OldBoDiContainerPlugin))]

namespace ReqnrollPlugins.OldBoDi;

public class OldBoDiContainerPlugin : IRuntimePlugin
{
    public void Initialize(RuntimePluginEvents runtimePluginEvents, RuntimePluginParameters runtimePluginParameters, UnitTestProviderConfiguration unitTestProviderConfiguration)
    {
        runtimePluginEvents.CustomizeGlobalDependencies += (sender, args) =>
        {
            args.ObjectContainer.RegisterTypeAs<OldBoDiTestObjectResolver, ITestObjectResolver>();
        };

        runtimePluginEvents.CustomizeScenarioDependencies += (sender, args) =>
        {
            args.ObjectContainer.RegisterFactoryAs(() =>
            {
                // TODO: build your own container using the old BoDi here
                BoDi.IObjectContainer container = SetupTestDependencies.CreateServices();

                // register the new BoDi container to the old one, just in case...
                container.RegisterInstanceAs<IObjectContainer>(args.ObjectContainer);

                return container;
            });
        };
    }

    public class OldBoDiTestObjectResolver : ITestObjectResolver
    {
        public object ResolveBindingInstance(Type bindingType, IObjectContainer container)
        {
            var registered = IsRegistered(container, bindingType);

            return registered
                ? container.Resolve(bindingType)
                : container.Resolve<BoDi.IObjectContainer>().Resolve(bindingType);
        }

        private bool IsRegistered(IObjectContainer container, Type type)
        {
            if (container.IsRegistered(type))
            {
                return true;
            }

            // IObjectContainer.IsRegistered is not recursive, it will only check the current container
            if (container is ObjectContainer c && c.BaseContainer != null)
            {
                return IsRegistered(c.BaseContainer, type);
            }

            return false;
        }
    }
}
