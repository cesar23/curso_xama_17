using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cur16_AgendaListaConta
{
    class GeneradorDeContactos
    {
        private static List<string> ListaNombres = new List<string>()
        {
            "Juan","Pedro","Julio","Oscar","Cesar","Deysi"
        };

        private static List<string> ListaApellidos = new List<string>()
        {
            "Perez","Gonzales","Ramirez","Pari","Rojas","Auuu"
        };


        public static ObservableCollection<Contacto> CrearContactos()
        {
            var random = new Random();
            var contactos = new ObservableCollection<Contacto>();
            for (int i = 0; i < 25; i++)
            {
                var nombre = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var apellidos = ListaApellidos[random.Next(ListaApellidos.Count - 1)];
                var calle = ListaNombres[random.Next(ListaNombres.Count - 1)];
                var contacto = new Contacto
                {
                    Nombre = nombre + " " + apellidos,
                    Telefono = GenerarTelefono(),
                    Direccion = "Avenida " + calle + " , Numero " + random.Next(1, 100)
                };
                contactos.Add(contacto);
            }


            return contactos;
        }

        private static string GenerarTelefono()
        {
            var random = new Random();
            StringBuilder telefono = new StringBuilder();
            telefono.Append("(");
            telefono.Append(random.Next(100, 999));
            telefono.Append(")");
            telefono.Append(random.Next(1000000, 9999999));
            return telefono.ToString();


        }



    }
}
