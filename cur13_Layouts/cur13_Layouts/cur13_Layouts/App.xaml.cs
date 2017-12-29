using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace cur13_Layouts
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			//MainPage = new cur13_Layouts.StackLayout();
            MainPage = new cur13_Layouts.AbsoluteLayout();
            //MainPage = new cur13_Layouts.GriddLayout();



        }

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
