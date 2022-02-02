using System;
using System.IO;
using System.Reflection;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Trainer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TrainerPage : ContentPage
    {
        readonly string fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "words.txt");
        public TrainerPage()
        {
            InitializeComponent();

            if (File.Exists(fileName))
            {
                
            }
        }
    }
}