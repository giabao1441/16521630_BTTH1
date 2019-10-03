using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace BTT1
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void Button_Clicked_3(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_Calculator());
        }
        async private void Button_Clicked_2(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_Chao());
        }
        async private void Button_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MH_Tinhtong());
        }
        private void Button_Clicked_1(object sender, EventArgs e)
        {

        }
        private void cmdAbsoluteLayout_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdGridLayout_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdLogin_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdFlexLayout_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdScrollView_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdEntry_Clicked(object sender, EventArgs e)
        {

        }
        private void cmdListview1_Clicked(object sender, EventArgs e)
        {

        }
    }
}
