using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cur14_Navegacion
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            btnToSeconPage.Clicked += (sender, e) =>
            {
                Navigation.PushAsync(new SecondPage());
            };
		}
	}
}
