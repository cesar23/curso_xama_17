﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace cur16_AgendaListaConta
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new cur16_AgendaListaConta.MainPage();

            //MainPage = new cur15_Agenda.MainPage();
            MainPage = new NavigationPage(new HomePage());
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