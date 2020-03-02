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
            "Albania", "Andorra", "Austria", "Belarus", "Belgium", "Bosnia_and_Herzegovina", "Croatia", "Czech_Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary",
            "Iceland", "Ireland", "Italy", "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Malta", "Moldova", "Montenegro", "Netherlands", "North_Macedonia", "Norway", "Poland", "Portugal",
            "Romania", "Russia", "San_Marino", "Serbia", "Slovakia", "Slovenia", "Spain", "Sweden", "Ukraine", "United_Kingdom"
        };
        private Random rnd = new Random();
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
           
            int selectedCountryIndex = rnd.Next(0, euCountries.Count);
            Country.Text = euCountries[selectedCountryIndex].Replace('_', ' ');
            int flagBtn = rnd.Next(0, 3);
            Buttons[flagBtn].Source = $"{euCountries[selectedCountryIndex]}.png";            
            foreach (var btn in Buttons)
            {
                int wrongCountryIndex = rnd.Next(0, euCountries.Count);
                if (btn.Source.ToString() != $"File: {euCountries[selectedCountryIndex]}.png")
                {
                    btn.Source = $"{euCountries[wrongCountryIndex]}.png";
                }
            }

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
