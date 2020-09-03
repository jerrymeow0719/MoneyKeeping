using System;
using System.Collections.Generic;
using BookKeeping.Model;
using Xamarin.Forms;

namespace BookKeeping.View
{
    public partial class DetailInfoView : ContentPage
    {
        public DetailInfoView(ObjectClass _objectClass)
        {
            InitializeComponent();
            this.BindingContext = _objectClass;
        }
    }
}
