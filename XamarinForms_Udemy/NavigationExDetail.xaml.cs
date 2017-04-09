using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamarinForms_Udemy.Service;

namespace XamarinForms_Udemy
{
	public partial class NavigationExDetail : ContentPage
	{
		public NavigationExDetail()
		{
			InitializeComponent();
		}

		public NavigationExDetail(int userId)
		{
			InitializeComponent();

			var user = new UserService();

			BindingContext = user.GetUser(userId);
		}
	}
}
