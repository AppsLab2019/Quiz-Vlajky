using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Quiz_Vlajky
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        private List<string> euCountries = new List<string>()
        {
            "Albania", "Andorra", "Austria", "Belarus", "Belgium", "Bosnia and Herzegovina", "Croatia", "Czech Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary",
            "Iceland", "Ireland", "Italy", "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Malta", "Moldova", "Montenegro", "Netherlands", "North Macedonia", "Norway", "Poland", "Portugal",
            "Romania", "Russia", "San_Marino", "Serbia", "Slovakia", "Slovenia", "Spain", "Sweden", "Ukraine", "United Kingdom"
        };
        private readonly ImageButton[] Buttons;
        private int round = 0;

        public MainPage()
        {
            InitializeComponent();
            Buttons = new[] { btn1, btn2, btn3, btn4 };
            foreach(var btn in Buttons)
            {
                btn.Source = "";
            }
            GetRandomCountry();
        }
        private void GetRandomCountry()
        {
                var rnd = new Random();
                int countryIndex = rnd.Next(0, euCountries.Count - 1);
                Country.Text = euCountries[countryIndex];
                int flagBtn = rnd.Next(0, 3);


        }
        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            
        } 
        private void ImageButton_Clicked_2(object sender, EventArgs e)
        {

        }

        private void ImageButton_Clicked_3(object sender, EventArgs e)
        {

        }
        private void ImageButton_Clicked_4(object sender, EventArgs e)
        {
            
        }
    }
}
