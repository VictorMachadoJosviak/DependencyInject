using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inject
{
    public class MainPage : ContentPage
    {
        public MainPage()
        {
            Title = "Home";

            BindingContext = App.Resolve<MainViewModel>();

            var b = new Button
            {
                Text = "Teste"
            };
            b.SetBinding(Button.CommandProperty, Binding.Create<MainViewModel>(x => x.Teste));

            Content = new StackLayout
            {
                Padding = 16,
                Children =
                {
                    b
                }
            };

        }
    }
}
