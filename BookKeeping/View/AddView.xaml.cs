using System;
using System.Collections.Generic;
using BookKeeping.Model;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookKeeping.View
{
    public partial class AddView : ContentPage
    {
        public AddView()
        {
            InitializeComponent();

            btn_save.Clicked += Btn_save_Clicked;
            btn_cancel.Clicked += Btn_cancel_Clicked;
            entry_year.Text = DateTime.Now.Year.ToString();
        }

        private async void Btn_save_Clicked(object sender, EventArgs e)
        {
            int _type = picker_type.SelectedIndex;
            int _money = Convert.ToInt32(entry_money.Text.ToString());
            int _year = Convert.ToInt32(entry_year.Text.ToString());
            int _month = picker_month.SelectedIndex + 1;

            ObjectClass objectClass = new ObjectClass();
            objectClass = App.Databse.GetItemAsync(_year, _month);
            switch (_type)
            {
                case 0:
                    objectClass.Spend0 += _money;
                    break;
                case 1:
                    objectClass.Spend1 += _money;
                    break;
                case 2:
                    objectClass.Spend2 += _money;
                    break;
                case 3:
                    objectClass.Spend3 += _money;
                    break;
                case 4:
                    objectClass.Spend4 += _money;
                    break;
            }
            objectClass.Spend5 = objectClass.Spend0 + objectClass.Spend1 + objectClass.Spend2 + objectClass.Spend3 + objectClass.Spend4;
            App.Databse.SaveItemAsync(objectClass);

            await Navigation.PopAsync();
        }

        private async void Btn_cancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}
