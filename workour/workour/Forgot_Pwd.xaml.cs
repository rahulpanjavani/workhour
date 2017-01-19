using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace workour
{
	public partial class Forgot_Pwd : ContentPage
	{
		bool isChecked = false;
		public Forgot_Pwd()
		{
			InitializeComponent();
			//TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();
			//tapGestureRecognizer.Tapped += OnBackTapped;
			//back.GestureRecognizers.Add(tapGestureRecognizer);

		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

		}

		void Send_Mail(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(entryEmail.Text))
			{

				stkQuestionindicate.IsVisible = true;
				isChecked = true;
			}
			else
			{
				ValidateEmailBehavior val = new ValidateEmailBehavior();
				if (!val.IsValidEmail(entryEmail.Text))
				{
					stkQuestionindicate.IsVisible = true;
					entryEmail.Focus();
					return;
				}

			}

			if (!string.IsNullOrEmpty(entryEmail.Text))
			{
				stkQuestionindicate.IsVisible = false;
				isChecked = true;

			}


			if (!isChecked)
				return;
			else if (!string.IsNullOrEmpty(entryEmail.Text))
			{
				
			}
		
		}
		public void Email_change(object sender, TextChangedEventArgs e)
		{
			stkQuestionindicate.IsVisible = false;
			isChecked = true;
		}

		void OnBackTapped(object sender, EventArgs e)
		{
			Navigation.PopModalAsync(false);
		}

	}
}
