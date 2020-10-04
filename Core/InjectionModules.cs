using AfvCompanion.Config;
using Appccelerate.EventBroker;
using Ninject.Modules;

namespace AfvCompanion.Core
{
    public class InjectionModules : NinjectModule
    {
        public override void Load()
        {
            Bind<IAppConfig>().To(typeof(AppConfig)).InSingletonScope();
            Bind<IPtmManager>().To(typeof(PtmManager)).InSingletonScope();
            Bind<IEventBroker>().To(typeof(EventBroker)).InSingletonScope();
        }
    }
}
