using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Plugin.FeatureDiscovery.Forms
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();

            // await Task.Delay(10000);

            //tapTarget.Show();
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            tapTargetSequence.Show();
        }
    }
}
