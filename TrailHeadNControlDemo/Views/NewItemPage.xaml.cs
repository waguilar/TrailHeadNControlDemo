using System;
using System.Collections.Generic;
using System.ComponentModel;
using TrailHeadNControlDemo.Models;
using TrailHeadNControlDemo.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TrailHeadNControlDemo.Views
{
    public partial class NewItemPage : ContentPage
    {
        public Item Item { get; set; }

        public NewItemPage()
        {
            InitializeComponent();
            BindingContext = new NewItemViewModel();
        }
    }
}