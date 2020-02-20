using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Quiz_Vlajky
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }
        private void ImageButton_Clicked_5(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        private void ImageButton_Clicked_6(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        private void ImageButton_Clicked_7(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
        private void ImageButton_Clicked_8(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2());
        }
    }
}