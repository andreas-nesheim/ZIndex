using Foundation;
using Microsoft.Maui;
using Microsoft.Maui.Hosting;

namespace ZIndex
{
	[Register("AppDelegate")]
	public class AppDelegate : MauiUIApplicationDelegate
	{
		protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();
	}
}