using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;


namespace ImmobilienVerwaltung
{
    public class Immobilie
    {
        public int Id { get; set; } 
        public int Baujahr{ get; set; }
        public double Gründstücksgrüße{ get; set; }
        public double Kellerfläsche { get; set; }
        public double Wohnfläsche { get; set; }
        //public Heizungsanlagetyp heizungsanlagetyp { get; set; }
        public string Straße { get; set; }
        public string HausNo { get; set; }
        public string PLZ { get; set; }
        public string Stadt { get; set; }
        public string gesamtWohnfläsche { get; set; }
        public string Address
        {
            get
            {
                return $"{Straße},   {HausNo}.  {PLZ}  {Stadt}.";
            }
        }
        public Immobilie(int baujahr, double gründstücksgrüße, double kellerfläsche, double wohnfläsche) 
        {
            this.Id =  Guid.NewGuid().GetHashCode();
            this.Baujahr = baujahr;
            this.Gründstücksgrüße = gründstücksgrüße;
            //Wohnfläsche = wohnfläsche;
            this.Kellerfläsche = kellerfläsche;
            this.Wohnfläsche = wohnfläsche;
            //this.heizungsanlagetyp = heizungsanlagetyp;
            this.gesamtWohnfläsche = GetGesamtWohnfläche(kellerfläsche, wohnfläsche);

        }

        public string GetGesamtWohnfläche(double kellerfläsche, double wohnfläsche)
        {
            double gesamtWohnfläsche = kellerfläsche + wohnfläsche;
            return Convert.ToString(gesamtWohnfläsche);
        }
       
       




    }
}
