using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace workour
{
	public partial class LoginPage : ContentPage
	{
		bool isChecked= false;
			
		public LoginPage()
		{
			InitializeComponent();

			TapGestureRecognizer imageTap = new TapGestureRecognizer();
			imageTap.Tapped += ImageTap_Tapped;

			checkBox.GestureRecognizers.Add(imageTap);


		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			NavigationPage.SetHasNavigationBar(this, false);
			if (App.ScreenHeight > 568)
			{
				StackLayout stk = new StackLayout();
				stk.Children.Add(imgLogo);
				stk.Padding = new Thickness(10,0,10,0);
				stk.SetValue(Grid.RowProperty,0);
				GridMainView.Children.Add(stk);
				imgLogo.HeightRequest = 150;
				imgLogo.BackgroundColor = Color.Aqua;
				imgLogo.Aspect = Aspect.AspectFill;
			}
		
		}

		void ImageTap_Tapped(object sender, EventArgs e)
		{
			checkBox.isChecked = !checkBox.isChecked;

			checkBox.Source = checkBox.isChecked ? ImageSource.FromFile("Tickcheckbox.png") : ImageSource.FromFile("checkbox.png");
		}
		public void Email_change(object sender, TextChangedEventArgs e)
		{
			lblEmail.IsVisible = false;
			isChecked = true;
		}
		public void Password_change(object sender, TextChangedEventArgs e)
		{
			lblPwd.IsVisible = false;
			isChecked = true;
		}

		 void btnLoginClicked(object sender, EventArgs e)
		{
				if (string.IsNullOrEmpty(entryPwd.Text))
				{
					lblPwd.IsVisible = true;
					entryPwd.Focus();
					isChecked = true;

				}
				if (string.IsNullOrEmpty(entryEmail.Text))
				{

					lblEmail.IsVisible = true;
					entryEmail.Focus();
					isChecked = true;
				}
				else
				{
					ValidateEmailBehavior val = new ValidateEmailBehavior();
					if (!val.IsValidEmail(entryEmail.Text))
					{
						lblEmail.IsVisible = true;
						entryEmail.Focus();
						return;
					}

				}

				if (!string.IsNullOrEmpty(entryEmail.Text))
				{
					lblEmail.IsVisible = false;
					isChecked = true;

				}

				if (!string.IsNullOrEmpty(entryPwd.Text))
				{
					lblPwd.IsVisible = false;
					isChecked = true;

				}
			if (!isChecked)
				return;
			else if((!string.IsNullOrEmpty(entryPwd.Text))&&(!string.IsNullOrEmpty(entryEmail.Text)))
			{
				FileImageSource img = (FileImageSource)checkBox.Source;
		        if (img.File.Equals("Tickcheckbox.png"))
				{
					Navigation.PushModalAsync(new sendConformationScreen(), false);
				}
				else {
					DisplayAlert("Message", "You must accept Terms of Service", "OK");
					return;
				}
			}
		}

		void OnHomeTapped(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new Forgot_Pwd(),false);
		}


	}
}
