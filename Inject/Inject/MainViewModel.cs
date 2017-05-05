using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Inject
{
    public class MainViewModel
    {

        public Command Teste => new Command(() =>
        {
            App.Current.MainPage.DisplayAlert("ola", "funfou", "ok");
        });
    }
}
