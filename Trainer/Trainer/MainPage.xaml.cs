using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Trainer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            ImageBooks.Source = ImageSource.FromResource("Trainer.books.png");
        }

        private void ButtonStart_Clicked(object sender, EventArgs e)
        {

        }
    }
}
