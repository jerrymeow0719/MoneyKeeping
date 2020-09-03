using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace BookKeeping.Model
{
    public class BookKeepingModel : ContentView
    {
        public ObservableCollection<ObjectClass> _ObjectList;

        public BookKeepingModel()
        {
            _ObjectList = new ObservableCollection<ObjectClass>();
            for (int index=0;index<12;index++)
            {
                ObjectClass objectClass = new ObjectClass();
                objectClass = App.Databse.GetItemAsync(DateTime.Now.Year, index + 1);
                _ObjectList.Add(objectClass);
            }          
        }

        public ObservableCollection<ObjectClass> UpdateList()
        {
            _ObjectList = new ObservableCollection<ObjectClass>();
            for (int index = 0; index < 12; index++)
            {
                ObjectClass objectClass = new ObjectClass();
                objectClass = App.Databse.GetItemAsync(DateTime.Now.Year, index + 1);
                _ObjectList.Add(objectClass);
            }

            return _ObjectList;
        }
    }
}

