using Naylah.Kernel.Events;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inject
{
    public class App : Application
    {
        public App()
        {
            MainPage = new MainPage();
        }

        public static T Resolve<T>()
        {
            try
            {
                return DomainEvent.Container.GetService<T>();
            }
            catch (Exception ex)
            {                
                return default(T);
            }
        }
    }
}
