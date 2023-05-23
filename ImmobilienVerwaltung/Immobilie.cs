using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using ImmobilienVerwaltung;


namespace ImmobilienVerwaltung
{  

    //subscriber class
    public class Immobilie:ModelBase
    {
       

        public int Id { get; set; } 
        public int Baujahr{ get; set; }
        public double Gründstücksgrüße{ get; set; }
        public double Kellerfläsche { get; set; }
        public double Wohnfläsche { get; set; }
        //public Heizungsanlagetyp heizungsanlagetyp { get; set; }
        public double gesamtWohnflaesche { get; set; }
        //Address address = new Address(ngfhguh,);
        public Address Address { get; set; }    
        public override string ToString()
        {
            return "Baujahr:" + "," + Baujahr + "Grundstücksgröße:" + Gründstücksgrüße + ";" + "Adresse" + Address.ToString() + ";"; //+"Heizungtyp"+ heizungsanlagetyp;
        }

        public Immobilie(int baujahr, double gründstücksgrüße, double kellerfläsche, double wohnfläsche, Address address ) 
        {
            this.Id =  Guid.NewGuid().GetHashCode();
            this.Baujahr = baujahr;
            this.Gründstücksgrüße = gründstücksgrüße;
            this.Kellerfläsche = kellerfläsche;
            this.Wohnfläsche = wohnfläsche;
            this.gesamtWohnflaesche = GetGesamtWohnfläche(kellerfläsche, wohnfläsche);
            this.Address = address;
            
            NotifyPropertyChangeImp notifyPropertyChange = new NotifyPropertyChangeImp();
            notifyPropertyChange.PropertyChanged += Immobilie_PropertyChanged;

        }
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
                    OnPropertyChanged(nameof(gesamtWohnflaesche));
                    break;
                case nameof(Wohnfläsche):
                    //call onpropeetyChanged whenever the property is updatet
                    OnPropertyChanged(nameof(gesamtWohnflaesche));
                    
                    break;
            }
        }

    }
    public class Address
    {
        public string Straße { get; set; }
        public string HausNo { get; set; }
        public string PLZ { get; set; }
        public string Stadt { get; set; }
        public string? totaladdress { get; set; }
        public Address()
        {
            
        }

        public Address(string straße, string hausNo, string pLZ, string stadt)
        {
            this.Straße = straße;
            this.HausNo = hausNo;
            this.PLZ = pLZ;
            this.Stadt = stadt;
            //this.totaladdress = GetTotalAddress(straße,hausNo,pLZ,stadt);
            
        
        }
        public override string ToString()
        {
            return "Address:" + "," + Straße + "," + HausNo + "," + PLZ + "," + Stadt + "." ;
        }
        //public string GetTotalAddress(string straße, string hausNo, string pLZ, string stadt)
        //{
        //    totaladdress =  $"{straße},   {hausNo}.  {pLZ}  {stadt}.";
        //    return totaladdress;

        //}
    }
}
