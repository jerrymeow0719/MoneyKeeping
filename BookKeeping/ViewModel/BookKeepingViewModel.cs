using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using BookKeeping.Model;
using Xamarin.Forms;

namespace BookKeeping.ViewModel
{
    public class BookKeepingViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<ObjectClass> ObjectList = new ObservableCollection<ObjectClass>();
        BookKeepingModel BKModel;

        public BookKeepingViewModel()
        {
            BKModel = new BookKeepingModel();
            ObjectList = new ObservableCollection<ObjectClass>();
            ObjectList = BKModel._ObjectList;
        }

        public void UpdateList()
        {
            ObjectList.Clear();
            ObjectList = BKModel.UpdateList();
        }

        protected void RaisePropertyChanged([CallerMemberName] string caller = "")
        {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(caller));
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}

