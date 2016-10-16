using Xamarin.Forms;

namespace MdpRight
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();

			var mdp = new MasterDetailPage
			{
				Master = new ContentPage
				{
					BackgroundColor = Color.Lime,
					Title = "Master",
					Content = new Label
					{
						Text = "MasterPage",
						HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
					},
				},
				Detail = new ContentPage
				{
					BackgroundColor = Color.Gray,
					Title = "DetailPage",
					Content = new Label
					{
						Text = "DetailPage",
						HorizontalTextAlignment = TextAlignment.Center,
						VerticalTextAlignment = TextAlignment.Center,
					},
				},
			};

			MainPage = mdp;
			//MainPage = new MdpRightPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
