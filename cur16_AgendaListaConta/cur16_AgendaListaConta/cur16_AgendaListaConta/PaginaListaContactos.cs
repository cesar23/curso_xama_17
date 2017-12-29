using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using Xamarin.Forms;

namespace cur16_AgendaListaConta
{
    public class PaginaListaContactos :  MasterDetailPage
    {
        public PaginaListaContactos()
        {
            //creamos la  lista
            var lista = new ListView();

            //llenamos la  lista
            lista.ItemsSource =
                GeneradorDeContactos.
                CrearContactos().
                OrderBy(x => x.Nombre);

            //Recorremos  para detectar el evento seleccionado
            lista.ItemSelected += (sender, e) =>
            {
                if (e.SelectedItem != null)
                {
                    Detail = new PaginaContacto(e.SelectedItem as Contacto);
                    IsPresented = false;
                }

            };


            Master = new ContentPage
            {
                Title = "Contactos",
                Content = lista
            };

            Detail = new PaginaContacto(GeneradorDeContactos.
                                    CrearContactos().
                                    First());
            
        }
    }
}
