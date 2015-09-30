using System;

using Xamarin.Forms;

namespace RangelsRecycling.Mobile
{
	public class ProfilePage : ContentPage
	{
		public ProfilePage ()
		{
			Title = "Profile";
			Icon = "Profile.png";
			Content = new StackLayout {
				Spacing = 20, Padding = 50,
				VerticalOptions = LayoutOptions.Center,
				Children = {
					new Entry { Placeholder = "Username" },
					new Entry { Placeholder = "Password", IsPassword = true },
					new Button {
						Text = "Login",
						TextColor = Color.White,
						BackgroundColor = Color.FromHex ("77D065")
					}
				}
			};

		}
	}
}


