using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using XamarinDependency.Helper;
using XamarinDependency.iOS.Helper;

[assembly:Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace XamarinDependency.iOS.Helper
{
    public class DeviceHelper : IDeviceHelper
    {

        public int GetDeviceNumber()
        {
            return 1;
        }
    }
}