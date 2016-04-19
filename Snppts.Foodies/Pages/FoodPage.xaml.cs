using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Snppts.Foodies
{
    public partial class FoodPage : ContentPage
    {
        public FoodPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            Title = "The World Of Smoothies";
        }
    }
}

