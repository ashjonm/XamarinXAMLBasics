using System;
using Xamarin.Forms;

namespace BasicXaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async void GoToNewPage(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new NewPage());
        }

        async void GoToStackedDemo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new XAMLPlusCode());
        }

        async void GoToAbsoluteDemo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new AbsoluteLayoutxaml());
        }

        async void GoToRelativeDemo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new RelativeLayoutDemo());
        }

        async void GoToGridDemo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new Grid());
        }

        async void GoToViewBindingDemo(object sender, EventArgs args)
        {
            await Navigation.PushAsync(new ViewViewBindingDemo());
        }
    }
}
