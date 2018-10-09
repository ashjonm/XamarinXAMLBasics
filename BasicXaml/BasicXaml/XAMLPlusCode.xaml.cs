using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class XAMLPlusCode : ContentPage
	{
        public XAMLPlusCode()
        {
            InitializeComponent();
        }

        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            valueLabel.Text = ((Slider)sender).Value.ToString("F3");
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            Button button = (Button)sender;
            await DisplayAlert("Clicked!",
                "The button labeled '" + button.Text + "' has been clicked",
                "OK");
        }
    }
}