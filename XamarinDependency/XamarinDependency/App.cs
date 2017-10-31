using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamarinDependency.Helper;
using XamarinDependency.Views;

namespace XamarinDependency
{
    public class App : Application
    {
        public App()
        {
            int number = DependencyService.Get<IDeviceHelper>().GetDeviceNumber();
            MainPage = new Sayfa(number);
            
        }
    }
}
