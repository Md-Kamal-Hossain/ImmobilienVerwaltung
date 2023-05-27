using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace ImmobilienVerwaltung
{  

    //subscriber class
    public class Immobilie:ModelBase
    {
       // public int Id { get; set; }

        private int _bauJahr;
        public int Baujahr
        { get=>_bauJahr;
            set
            {
                if (_bauJahr == value)
                    return;
                _bauJahr = value;
                OnPropertyChanged(nameof(Baujahr));
            }
         }
        public double _gruendstueksgruesse;
        public double Gründstücksgrüße
        {
            get => _gruendstueksgruesse;
            set
            {
                if (_gruendstueksgruesse == value)
                    return;
                _gruendstueksgruesse = value;
                OnPropertyChanged(nameof(Gründstücksgrüße));
            }
        }
        private double _kellerflaesche;
        public double Kellerfläsche
        {
            get => _kellerflaesche;
            set
            {
                if (_kellerflaesche == value)
                    return;
                _kellerflaesche = value;
                OnPropertyChanged(nameof(Kellerfläsche));
            }
        }
        private double _wohnflaesche;
        public double Wohnfläsche
        {
            get => _wohnflaesche;
            set
            {
                if (_wohnflaesche == value)
                    return;
                _wohnflaesche = value;
                OnPropertyChanged(nameof(Wohnfläsche));
            }
        }
        private HeizungSystemTyp _heizungtyp;
        public HeizungSystemTyp Heizungtyp
        {
            get => _heizungtyp;
            set
            {
                if (_heizungtyp == value)
                    return;
                _heizungtyp = value;
                OnPropertyChanged(nameof(HeizungSystemTyp));
            }
        }
        private double _gesamtWohnflaesche;
        public double GesamtWohnflaesche
        {
            get => _gesamtWohnflaesche;
            set
            {
                if (_gesamtWohnflaesche == value)
                    return;
                _gesamtWohnflaesche = value;
                OnPropertyChanged(nameof(GesamtWohnflaesche));
            }
        }
        private Address _address;
        public Address Address
        {
            get => _address;
            set
            {
                if (_address == value)
                    return;
                _address = value;
                OnPropertyChanged(nameof(Address));
            }
        }
        public Immobilie()
        {

        }
        
        public override string ToString()
        {
            return $"Baujahr: {Baujahr} + Grundstücksgröße: { Gründstücksgrüße } + { Address.ToString()}";//want to add Id
            //+"Heizungtyp"+ heizungsanlagetyp;
        }

        public Immobilie( int baujahr, double gründstücksgrüße, double kellerfläsche, double wohnfläsche,HeizungSystemTyp heiz, Address address ) 
        {
            //this.Id = ID();
            this.Baujahr = baujahr;
            this.Gründstücksgrüße = gründstücksgrüße;
            this.Kellerfläsche = kellerfläsche;
            this.Wohnfläsche = wohnfläsche;
            this.GesamtWohnflaesche = GetGesamtWohnfläche(kellerfläsche, wohnfläsche);
            this.Heizungtyp = heiz;
            this.Address = address;
            
            NotifyPropertyChangeImp notifyPropertyChange = new NotifyPropertyChangeImp();
            notifyPropertyChange.PropertyChanged += Immobilie_PropertyChanged;

        }
        //I will write a method to auto generate incrimental id which I will add to list.
        //public int GetID()
        //{
           
        //}
        public double GetGesamtWohnfläche(double kellerfläsche, double wohnfläsche)
        {
            double gesamtWohnflaesche = kellerfläsche + wohnfläsche;
            return gesamtWohnflaesche;
        }
        private void Immobilie_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {
                case nameof(Kellerfläsche):
                    //call onpropeetyChanged whenever the property is updated
                    OnPropertyChanged(nameof(GesamtWohnflaesche));
                    break;
                case nameof(Wohnfläsche):
                    //call onpropeetyChanged whenever the property is updatet
                    OnPropertyChanged(nameof(GesamtWohnflaesche));
                    
                    break;
            }
        }

    }
    public class Address
    {
        public string Straße { get; }
        public string HausNo { get; set; }
        public string PLZ { get; set; }
        public string Stadt { get; set; }
        public string totaladdress { get; set; }
        public Address()
        {
            
        }

        public Address(string straße, string hausNo, string pLZ, string stadt)
        {
            this.Straße = straße;
            this.HausNo = hausNo;
            this.PLZ = pLZ;
            this.Stadt = stadt;
            
        }
        public override string ToString()
        {
            return "Address:" + "," + Straße + "," + HausNo + "," + PLZ + "," + Stadt + "." ;
        }
        //public string GetTotalAddress(string straße, string hausNo, string pLZ, string stadt)
        //{
        //    totaladdress = $"{straße},   {hausNo}.  {pLZ}  {stadt}.";
        //    return totaladdress;

        //}
    }
}
