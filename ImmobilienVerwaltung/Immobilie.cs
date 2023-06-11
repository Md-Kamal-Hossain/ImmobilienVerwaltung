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

    public  class Immobilie:ModelBase
    {

        private int _bauJahr;
        public int Baujahr
        { 
            get=>_bauJahr;
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
        public double GesamtWohnflaesche { get;}
        public Address Address { get; }


        public Immobilie()
        {

        }
        
        public override string ToString()
        {
            return $"Baujahr: {Baujahr} + Grundstücksgröße: {Gründstücksgrüße} + Wohnflasche: {Wohnfläsche} + Kellerflasche: {Kellerfläsche}+ Heizungtyp: {Heizungtyp}  +  { Address.ToString}";
           
        }

        public Immobilie( int baujahr, double gründstücksgrüße, double wohnfläsche, double kellerfläsche, HeizungSystemTyp heiz, Address address) 
        {
            this.Baujahr = baujahr;
            this.Gründstücksgrüße = gründstücksgrüße;
            this.Wohnfläsche = wohnfläsche;
            this.Kellerfläsche = kellerfläsche;
            this.GesamtWohnflaesche = GetGesamtWohnfläche(kellerfläsche, wohnfläsche);
            this.Heizungtyp = heiz;
            this.Address = address;
            
            NotifyPropertyChangeImp notifyPropertyChange = new NotifyPropertyChangeImp();
            notifyPropertyChange.PropertyChanged += Immobilie_PropertyChanged;

        }
       
        public double GetGesamtWohnfläche(double kellerfläsche, double wohnfläsche)
        {
            double gesamtWohnflaesche = kellerfläsche + wohnfläsche;
            return gesamtWohnflaesche;
        }
        public void Immobilie_PropertyChanged(object? sender, PropertyChangedEventArgs e)
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
    public class Address : ModelBase
    {

        private string _stadt;
        public string Stadt{
            get => _stadt;
            set
            {
                if (_stadt == value)
                    return;
                _stadt = value;
                OnPropertyChanged(nameof(Stadt));
            }
        }
        private string _straße;
        public string Straße
        {
            get => _straße;
            set
            {
                if (_straße == value)
                    return;
                _straße = value;
                OnPropertyChanged(nameof(Straße));
            }
        }
        private string _plz;
        public string PLZ
        {
            get => _plz;
            set
            {
                if (_plz == value)
                    return;
                _plz = value;
                OnPropertyChanged(nameof(PLZ));
            }
        }
        private string _hausNo;
        public string HausNo
        {
            get => _hausNo;
            set
            {
                if (_hausNo == value)
                    return;
                _hausNo = value;
                OnPropertyChanged(nameof(HausNo));
            }
        }
       
        public Address(string straße, string hausno, string plz, string stadt)
        {
            this.Straße = straße;
            this.HausNo = hausno;
            this.PLZ = plz;
            this.Stadt = stadt;

            NotifyPropertyChangeImp notifyPropertyChange = new NotifyPropertyChangeImp();
            notifyPropertyChange.PropertyChanged += Address_PropertyChanged;
        }
        public void Address_PropertyChanged(object? sender, PropertyChangedEventArgs e)
        {
            switch (e.PropertyName)
            {

                case nameof(Straße):
                    //call onpropeetyChanged whenever the property is updated
                    OnPropertyChanged(nameof(Address));
                    break;
                case nameof(HausNo):
                    //call onpropeetyChanged whenever the property is updated
                    OnPropertyChanged(nameof(Address));
                    break;
                case nameof(PLZ):
                    //call onpropeetyChanged whenever the property is updated
                    OnPropertyChanged(nameof(Address));
                    break;
                case nameof(Stadt):
                    //call onpropeetyChanged whenever the property is updated
                    OnPropertyChanged(nameof(Address));
                    break;

            }
        }
        public override string ToString()
        {            
            return $" Address:  Straße- {Straße} ; HouseNo-{HausNo} ; PLZ- {PLZ} ; Stadt- {Stadt}.";
        }

    }
}
