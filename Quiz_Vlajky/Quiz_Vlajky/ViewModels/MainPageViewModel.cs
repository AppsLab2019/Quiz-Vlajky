using Quiz_Vlajky.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Quiz_Vlajky.ViewModels
{
    public class MainPageViewModel
    {
        public ICommand Click_Command { get; }
        public MainPageViewModel()
        {
            Click_Command = new Command<string>(HandleClick);
        }
        private void HandleClick(string button)
        {
            PlayingPageViewModel.selectedContinent = button;
            Application.Current.MainPage.Navigation.PushAsync(new PlayingPage());
        }
    }
}
