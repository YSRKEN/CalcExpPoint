using Xamarin.Forms;

namespace CalcExpPoint
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			this.BindingContext = new MainViewModel();
		}
	}
}
