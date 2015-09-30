using System;

using Xamarin.Forms;

namespace RangelsRecycling.Mobile
{
	public class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			Title = "Settings";
			Icon = "Settings.png";
			Content = new StackLayout {
				Spacing = 20, Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Entry { Placeholder = "Setting's Page" },
					new Entry { Placeholder = "Password in Child", IsPassword = true },
					new Button {
						Text = "Login as Button",
						TextColor = Color.White,
						BackgroundColor = Color.FromHex ("77D065")
					}
				}
			};
		}
	}
}


