using AppListView.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppListView.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
		private HomePageViewModel _homePageViewModel;

		public HomePage ()
		{
			InitializeComponent ();

			_homePageViewModel = new HomePageViewModel();

			BindingContext = _homePageViewModel;
		}
	}
}