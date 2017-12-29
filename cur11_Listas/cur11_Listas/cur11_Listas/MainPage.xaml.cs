using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cur11_Listas
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            var nombres = new[]
                {
                    "Hector",
                    "Julio",
                    "peru",
                    "Jose",
                    "Jose2",
                    "Jose3",
                    "Ha1",
                    "Jose5",
                    "Jose6",
                    "Diego",
                    "Hffaaa8",
                    "Ana",
                };

            var miListView = new ListView();
           // miListView.ItemsSource = nombres;
            miListView.ItemsSource = from nombre in nombres
                                     where nombre.StartsWith("H")
                                     select nombre;
            Content = miListView;
        }
	}
}
