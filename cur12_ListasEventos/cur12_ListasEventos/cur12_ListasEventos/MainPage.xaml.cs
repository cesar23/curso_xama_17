using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cur12_ListasEventos
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

            //el evento disparado
            miListView.ItemSelected += (sender, e) =>
             {
                 if (e.SelectedItem != null)
                 {
                    // Log.Info("dddd", e.SelectedItem);
                     Console.WriteLine("selected: " + e.SelectedItem);
                    miListView.SelectedItem = null;
                }
             };


            Content = miListView;
        }
	}
}
