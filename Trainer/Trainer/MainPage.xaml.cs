﻿using System;
using Xamarin.Forms;

namespace Trainer
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            //Из ресурсов достается картинка
            ImageBooks.Source = ImageSource.FromResource("Trainer.books.png");
        }

        private async void ButtonStart_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TrainerPage());
        }
    }
}
