using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImmobilienVerwaltung
{  
    //Publisher class
    public  class NotifyPropertyChangeImp : INotifyPropertyChanged
    {       
            
            //delare the event 
            public event PropertyChangedEventHandler PropertyChanged;
            //create OnPropertyChange method to raise the event
            protected internal void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
        
    }
}
