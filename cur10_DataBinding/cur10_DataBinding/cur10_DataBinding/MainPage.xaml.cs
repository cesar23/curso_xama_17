using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cur10_DataBinding
{
	public partial class MainPage : ContentPage
	{
        public Empleado  NuevoEmpleado { get; set; }
		public MainPage()
		{
            NuevoEmpleado = new Empleado();
            NuevoEmpleado.NombreCompleto = "Cesar Auris";
            NuevoEmpleado.Email = "correo@gmail.com";
            BindingContext = NuevoEmpleado;

            InitializeComponent();
		}
	}
}
