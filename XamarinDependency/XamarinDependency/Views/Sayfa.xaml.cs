using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamarinDependency.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Sayfa : ContentPage
    {
        public Sayfa(int number)
        {
            InitializeComponent();
            labelCihazAdi.Text = number.ToString();
        }
    }
}