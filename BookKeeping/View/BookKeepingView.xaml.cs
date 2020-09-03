using System;
using System.Collections.Generic;
using BookKeeping.Model;
using BookKeeping.ViewModel;
using Xamarin.Forms;

namespace BookKeeping.View
{
    public partial class BookKeepingView : ContentPage
    {
        readonly BookKeepingViewModel vm = new BookKeepingViewModel();

        public BookKeepingView()
        {
            InitializeComponent();
            this.BindingContext = vm;
            collectionview.ItemsSource = vm.ObjectList;
            collectionview.Footer = DateTime.Now.Year;

            collectionview.SelectionChanged += Collectionview_SelectionChanged;
            
            btn_Add.Clicked += Btn_Add_Clicked;
        }

        private async void Btn_Add_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddView());
        }

        private async void Collectionview_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            await Navigation.PushAsync(new DetailInfoView((ObjectClass)e.CurrentSelection[0]));
        }

        protected override void OnAppearing()
        {
            vm.UpdateList();
            collectionview.ItemsSource = vm.ObjectList;
            base.OnAppearing();
        }
    }
}
