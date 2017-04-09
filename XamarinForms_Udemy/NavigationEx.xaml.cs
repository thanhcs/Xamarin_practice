using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms_Udemy.Models;
using XamarinForms_Udemy.Service;

namespace XamarinForms_Udemy
{
	public partial class NavigationEx : TabbedPage
	{
		public NavigationEx()
		{
			InitializeComponent();
			var activityService = new ActivityService();

			listview.ItemsSource = activityService.GetActivities();
		}

		void Handle_ItemSelected(object sender, Xamarin.Forms.SelectedItemChangedEventArgs e)
		{
			if (e.SelectedItem == null)
				return;
			var activity = e.SelectedItem as Activity;

			Navigation.PushAsync(new NavigationExDetail(activity.UserId));
			listview.SelectedItem = null;
		}
	}
}
