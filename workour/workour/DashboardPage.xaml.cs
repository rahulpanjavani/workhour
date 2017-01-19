using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace workour
{
	public partial class DashboardPage : MasterDetailPage
	{
		MenuPage menuPage;
		private MyHoursDashboardPage home;
		public DashboardPage()
		{
			InitializeComponent();
		menuPage = new MenuPage();
			home = new MyHoursDashboardPage();
			Master = menuPage;
			Detail = home;
			menuPage.MenuListView.ItemTapped += MenuListView_ItemTapped;

		}
	
	void MenuListView_ItemTapped(object sender, ItemTappedEventArgs e)
		{
			MenuPageItem menuItem = e.Item as MenuPageItem; ;
			IsPresented = false;
			menuPage.MenuListView.SelectedItem = null;


			if (menuItem.pageName == "dashboard")
			{
				
				home = ((Page)Activator.CreateInstance(menuItem.pageType)) as MyHoursDashboardPage;
				Detail = home;

			}

			else {
				Navigation.PushModalAsync((Page)Activator.CreateInstance(menuItem.pageType), true);
			}
		}
	
	}
}
