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
    public partial class MH_Tinhtong : ContentPage
    {
        public MH_Tinhtong()
        {
            InitializeComponent();
        }
        private double cleanChar(string str)
        {
            string number = "0";
            var chars = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            str = new string((from c in str
                              where char.IsWhiteSpace(c) || char.IsLetterOrDigit(c)
                               select c
                ).ToArray());
        
            foreach (var c in str)
            {
                if (chars.Contains(c) == true)
                {
                    number = number + c;
                }
            }
            return double.Parse(number);
          
        }
        private void cmdTinhTong_clicked(Object sender, EventArgs e)
        {
            double n1 = cleanChar(txtSoA.Text), n2 = cleanChar(txtSoB.Text), tong = n1 + n2;
            txtTong.Text = tong.ToString();
        }
        async private void cmdGoHome_clicked(Object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MainPage());
        }
    }
}