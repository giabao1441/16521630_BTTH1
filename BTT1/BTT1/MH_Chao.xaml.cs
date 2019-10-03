using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BTT1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MH_Chao : ContentPage
    {
        public MH_Chao()
        {
            InitializeComponent();
        }
        private void cmdChao_Clicked(Object sender, EventArgs e)
        {
            string name = txtHoten.Text;
            DisplayAlert("Chào", "Chào bạn " + name, "Thoát");
        }
    }
}