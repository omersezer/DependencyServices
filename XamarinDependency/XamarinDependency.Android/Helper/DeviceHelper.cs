using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using XamarinDependency.Helper;
using XamarinDependency.Droid.Helper;

[assembly:Xamarin.Forms.Dependency(typeof(DeviceHelper))]
namespace XamarinDependency.Droid.Helper
{
    public class DeviceHelper : IDeviceHelper
    {
        public int GetDeviceName()
        {
            return 0;

        }
    }
}