using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace workour
{
	public partial class sendConformationScreen : ContentPage
	{
		public sendConformationScreen()
		{
			InitializeComponent();
		}

		void ConfirmationcodeClicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ConfirmationCodePage(), false);
		}

		void SendcodetextmsgClicked(object sender, EventArgs e)
		{
		}

		void SendcodeemailClicked(object sender, EventArgs e)
		{
			
		}
	}
}
