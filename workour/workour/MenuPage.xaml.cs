using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace workour
{
	public partial class MenuPage : ContentPage
	{
		public ListView MenuListView { get { return menuListView; } }
		public MenuPage()
		{
			InitializeComponent();
			Title = "dd";
			Icon = "question.png";
			BindingContext = new MenuPageViewModel();
		}
	}
}
