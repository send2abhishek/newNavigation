using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NavigationApp.ViewPage;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NavigationApp.Models;

namespace NavigationApp.ViewPage
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class DetailsPage : ContentPage
	{
		public DetailsPage (Contacts contact)
		{
			InitializeComponent ();
            BindingContext = contact;
		}
	}
}