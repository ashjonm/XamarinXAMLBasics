using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BasicXaml
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SimpleMVVM : ContentPage
	{
		public SimpleMVVM ()
		{
			InitializeComponent ();
		}
	}
}