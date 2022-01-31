using Xamarin.Forms;

[assembly: ExportFont("Ubuntu-BoldItalic.ttf", Alias = "UbuntuBold")]
[assembly: ExportFont("Ubuntu-LightItalic.ttf", Alias = "UbuntuLight")]
[assembly: ExportFont("Cairo-Regular.ttf", Alias = "Cairo-Regular")]
namespace Trainer
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
