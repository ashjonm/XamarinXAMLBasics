using Xamarin.Forms;

namespace BasicXaml
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button button = new Button
            {
                Text = "Nagivate!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center,
            };

            button.Clicked += async (sender, args) =>
            {
                await Navigation.PushAsync(new XAMLPlusCode());
            };

            Content = button;
        }
    }
}
