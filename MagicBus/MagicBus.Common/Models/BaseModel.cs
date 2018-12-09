using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MagicBus.Common.Models
{
    public class BaseModel : INotifyPropertyChanged
    {
        public BaseModel()
        {
            Id = Guid.NewGuid().ToString("N");
        }

        private string _id;

        public string Id
        {
            get { return _id; }
            set
            {
                _id = value;
                OnPropertyChanged(nameof(Id));
            }

        }

        private void OnPropertyChanged(string idName)
        {
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
