using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Azure.Mobile;
using Microsoft.Azure.Mobile.Analytics;
using Microsoft.Azure.Mobile.Crashes;

using Xamarin.Forms;

namespace CodeSharingApp
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

			MainPage = new CodeSharingApp.MainPage();
		}

		protected override void OnStart ()
		{
            // Handle when your app starts

            MobileCenter.Start("android=ec285354-7d3d-4a74-9d8e-e305de3ccd20;" +
                   "ios={Your iOS App secret here}",
                   typeof(Analytics), typeof(Crashes));
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
