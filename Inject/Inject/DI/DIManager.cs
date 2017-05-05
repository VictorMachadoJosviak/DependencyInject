using Autofac;
using Naylah.Kernel.Events;
using XLabs.Ioc;
using XLabs.Ioc.Autofac;

namespace Inject.DI
{
    public partial class DIManager
    {
        public static ContainerBuilder  Builder { get; set; }

        public static IContainer Container { get; set; }
        public static void InitializeContainer()
        {
            Builder = new ContainerBuilder();

            Builder.RegisterType<MainViewModel>().AsSelf().SingleInstance();            
        }

        public static void BuildContainer()
        {
            Container = Builder.Build();

            Resolver.SetResolver(new AutofacResolver(Container));

            DomainEvent.Container = new CoreEventsContainer();
        }
    }
}
