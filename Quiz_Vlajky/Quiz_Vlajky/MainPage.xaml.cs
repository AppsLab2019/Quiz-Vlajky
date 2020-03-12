using System;
using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Quiz_Vlajky
{
    public partial class MainPage
    {
        private readonly List<string> euCountries = new List<string>
        {
            "Albania", "Andorra", "Austria", "Belarus", "Belgium", "Bosnia_and_Herzegovina", "Croatia", "Czech_Republic", "Denmark", "Estonia", "Finland", "France", "Germany", "Greece", "Hungary",
            "Iceland", "Ireland", "Italy", "Latvia", "Liechtenstein", "Lithuania", "Luxembourg", "Malta", "Moldova", "Montenegro", "Netherlands", "North_Macedonia", "Norway", "Poland", "Portugal",
            "Romania", "Russia", "San_Marino", "Serbia", "Slovakia", "Slovenia", "Spain", "Sweden", "Ukraine", "United_Kingdom"
        };
        private Random rnd = new Random();
        private readonly ImageButton[] Buttons;
        private int currentround = 1;
        private const int totalrounds = 10;
        private int right = 0;
        private int correctIndex;

        public MainPage()
        {
            InitializeComponent();
            Buttons = new[] { btn1, btn2, btn3, btn4 };
            RandomCountry();
        }

        private void RandomCountry()
        {
            var countryList = new List<string>();

            var chosenCountries = new List<string>();

            while (chosenCountries.Count < 4)
            {
                var country = euCountries[rnd.Next(0, euCountries.Count)];
                if (countryList.Contains(country))
                    continue;
                if (chosenCountries.Contains(country))
                    continue;

                chosenCountries.Add(country);
                countryList.Add(country);
            }

            for (int i = 0; i < 4; i++)
                Buttons[i].Source = $"{chosenCountries[i]}.png";

            correctIndex = rnd.Next(0, 3);

            Country.Text = chosenCountries[correctIndex].Replace('_', ' ');
            if (currentround >= totalrounds)
            {
                DisplayAlert($"You got {right} answers.", "", "Cancel");
                right = 0;
                currentround = 0;
                countryList.Clear();
            }

        }

        private void Timer(int time)
        {
            Device.StartTimer(TimeSpan.FromMilliseconds(time), () =>
            {
                currentround++;
                Question.Text = $"{currentround}/{totalrounds}";
                bc.BackgroundColor = Color.FromHex("#333333");
                return false;
            });
        }

        private void Check(object sender)
        {
            if (Buttons.IndexOf((ImageButton)sender) == correctIndex)
            {
                bc.BackgroundColor = Color.Green;
                right++;
            }
            else
            {
                bc.BackgroundColor = Color.DarkRed;
            }
        }
        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            Check(sender);
            Timer(350);
            RandomCountry();
        }

    }
}