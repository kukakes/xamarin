using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TabApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            this.btn.Clicked += gotNext;
        }

        private void gotNext(object sender, EventArgs e)
        {
            this.Navigation.PushAsync(new MyT1Page());
        }
    }
}
