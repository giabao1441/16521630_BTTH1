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
    public partial class MH_Calculator : ContentPage
    {
        public MH_Calculator()
        {
            InitializeComponent();
        }
        public Boolean temp = true;
        public double oldResult = 0;
        public int math = -1;

        private void _X(object sender, EventArgs e)
        {
        }
        private void _Sub(object sender, EventArgs e)
        {
        }
        private void _Plus(object sender, EventArgs e)
        {
            if (math == 1)
            {
                oldResult += double.Parse(values.Text);
                values.Text = (oldResult).ToString();
                oldResult = 0;
            }
            else if (math == 2)
            {
                oldResult -= double.Parse(values.Text);
                values.Text = (oldResult).ToString();
                oldResult = 0;
            }
            else if (math == 3)
            {
                values.Text = nhan(oldResult, double.Parse(values.Text)).ToString();
                oldResult = 0;
            }
            else if (math == -1)
            {
                math = 1;
                temp = false;
            }
        }
        private void _Div(object sender, EventArgs e)
        {
        }
        private void _C(object sender, EventArgs e)
        {
            values.Text = "0";
        }
        private void _Percent(object sender, EventArgs e)
        {
        }
        private void _Dot(object sender, EventArgs e)
        {
        }
        private void _Result(object sender, EventArgs e)
        {
        }
        private void _Convert(object sender, EventArgs e)
        {

        }

        private double cong(double a, double b)
        {
            return a + b;
        }
        private double tru(double a, double b)
        {
            return a - b;
        }
        private double nhan(double a, double b)
        {
            double kq = 0;
            for (int i = 0; i < b; i++)
            {
                kq += cong(a, a);
            }
            return kq;
        }
        private void _0(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt0.Text)).ToString();
        }
        private void _1(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt1.Text)).ToString();
        }
        private void _2(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt2.Text)).ToString();
        }
        private void _3(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt3.Text)).ToString();
        }
        private void _4(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt4.Text)).ToString();
        }
        private void _5(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt5.Text)).ToString();
        }
        private void _6(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt6.Text)).ToString();
        }
        private void _7(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt7.Text)).ToString();
        }
        private void _8(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt8.Text)).ToString();
        }
        private void _9(object sender, EventArgs e)
        {
            if (values.Text.Length > 16)
            {
                values.Text = values.Text.Remove(0, 1);
            }
            values.Text = (double.Parse(values.Text + txt9.Text)).ToString();
        }
    }
}