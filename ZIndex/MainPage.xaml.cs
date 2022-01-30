using System;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;

namespace ZIndex
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        private async void GridLayoutButton_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new GridPage());
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
			await Navigation.PushAsync(new AbsoluteLayoutPage());

		}
	}
}
