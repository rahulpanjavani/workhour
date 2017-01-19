using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace workour
{
	public partial class ConfirmationCodePage : ContentPage
	{
		bool isChecked = false;
		public ConfirmationCodePage()
		{
			InitializeComponent();
		}

		void OnBackTapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync(false);
		}

		void CompleteLoginClicked(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(entryConfirmcode.Text))
			{

				lblConfirmcode.IsVisible = true;
				isChecked = true;
			}

			if (!string.IsNullOrEmpty(entryConfirmcode.Text))
			{
				entryConfirmcode.IsVisible = true;
				isChecked = true;

			}


			if (!isChecked)

				return;
			else if (!string.IsNullOrEmpty(entryConfirmcode.Text))
			{
				Navigation.PushModalAsync(new WelcomePage(), false);
			}

		}

		public void Code_change(object sender, TextChangedEventArgs e)
		{
			lblConfirmcode.IsVisible = false;
			isChecked = true;
		}


	}
}
