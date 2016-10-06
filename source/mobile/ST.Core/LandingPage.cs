using Xamarin.Forms;

namespace SpaceLinx.Training.Core
{
	public class LandingPage : ContentPage
	{
	    readonly ContentView _videoPlayer;

		public LandingPage ()
		{
			_videoPlayer = new ContentView {
				WidthRequest = App.ScreenWidth/2,
				HeightRequest = App.ScreenHeight/2,
			};

			Content = new StackLayout {
				Children = {
					_videoPlayer
				}
			};
		}

		protected override void LayoutChildren (double x, double y, double width, double height)
		{
			//need to change the size of the ContentView for Landscape Orientation
			//This enables fullscreen capabilities in the Custom Renderer
			if (width > height) {
				//Landscape Orientation
				_videoPlayer.WidthRequest = App.ScreenWidth;
				_videoPlayer.HeightRequest = App.ScreenHeight;
			} else if (width < height) {
				//Portrait Orientation
				_videoPlayer.WidthRequest = App.ScreenWidth/2;
				_videoPlayer.HeightRequest = App.ScreenHeight/2;
			}
				
			base.LayoutChildren (x, y, width, height);
		}
	}
}