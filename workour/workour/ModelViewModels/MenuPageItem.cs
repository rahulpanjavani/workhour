using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace workour
{
	public class MenuPageItem
	{
		public string pageIcon { get; set; }
		public string pageName { get; set; }
		public Type pageType { get; set; }
		public MenuPageItem()
		{
		}
	}

	public class MenuPageViewModel : BindableObject
	{
		List<MenuPageItem> menuPages;
		public List<MenuPageItem> MenuPagesList
		{
			get { return menuPages; }
			set
			{
				menuPages = value;
				OnPropertyChanged("MenuPagesList");
			}
		}

		public MenuPageViewModel()
		{
			MenuPagesList = new List<MenuPageItem> {
				new MenuPageItem { pageName="DASHBOARD", pageIcon="question.png", pageType=typeof(MyHoursDashboardPage)},
				new MenuPageItem { pageName="Start/Stop Time", pageIcon="question.png", pageType=typeof(Forgot_Pwd)},
				new MenuPageItem { pageName="Update Shift", pageIcon="camera.png", pageType=typeof(Forgot_Pwd)},
				new MenuPageItem { pageName="Change Program", pageIcon="flag.png", pageType=typeof(Forgot_Pwd)},
				new MenuPageItem { pageName="My Messages", pageIcon="projet.png",  pageType=typeof(Forgot_Pwd)},
				new MenuPageItem { pageName="My Notifications", pageIcon="profil.png",  pageType=typeof(Forgot_Pwd)},
				new MenuPageItem { pageName="Settings", pageIcon="conditions.png", pageType=typeof(Forgot_Pwd)},
				new MenuPageItem { pageName="Log Out", pageIcon="contact.png",  pageType=typeof(Forgot_Pwd)},
				//new MenuPageItem { pageName="TUTORIEL", pageIcon="tutoriel.png",  pageType=typeof(Forgot_Pwd)},
			};
		}

	}
}
