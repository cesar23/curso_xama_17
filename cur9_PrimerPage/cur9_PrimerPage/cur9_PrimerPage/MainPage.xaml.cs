using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cur9_PrimerPage
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
            var label = new Label
            {
                Text = "Escribe un nombre"
            };

            var txtNombre = new Entry
            {
                Placeholder = "Escribe un nombre"
            };

            var btnPRimerBotton = new Button
            {
                Text = "Click Me"
            };

            btnPRimerBotton.Clicked += (sender, e) =>
            {
                DisplayAlert("Titulo Mensaje", "Hola: " + txtNombre.Text, "Ok");
            };

            Content = new StackLayout
            {
                Padding = 30,
                Spacing = 10,
                Children = { label, txtNombre, btnPRimerBotton }

            };

           
		}
	}
}
