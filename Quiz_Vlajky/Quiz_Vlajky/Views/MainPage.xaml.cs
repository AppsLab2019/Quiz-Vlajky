using System;

namespace Quiz_Vlajky.Views
{
    public partial class MainPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new PlayingPage());
        }

    }
}