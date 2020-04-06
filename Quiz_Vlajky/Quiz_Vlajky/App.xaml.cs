using Quiz_Vlajky.Views;
using Xamarin.Forms;

namespace Quiz_Vlajky
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new PlayingPage());
        }
    }
}
