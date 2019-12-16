using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace R01_BMI
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
        private void Button_Clicked(object sender, EventArgs e){
            
            String x=sintyou.Text;
            String y=taijuu.Text;
            int ww=int.Parse(x);
            int q=int.Parse(y);

            double a=ww/(q/100 * q/100);
            answer.Text="BMI:"+a;

        
        }
    }
}
