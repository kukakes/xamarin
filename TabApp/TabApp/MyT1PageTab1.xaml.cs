using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TabApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyT1PageTab1 : ContentPage
    {
        public MyT1PageTab1()
        {
            InitializeComponent();
            this.btn.Clicked += Btn_Clicked;
        }

        private void Btn_Clicked(object sender, EventArgs e)
        {
            ((NavigationPage)App.Current.MainPage).PushAsync(new MainPage());
        }
    }
}
