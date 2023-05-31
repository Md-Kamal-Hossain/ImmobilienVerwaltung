using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.ComponentModel;


namespace ImmobilienVerwaltung
{
    public class ImmobiliVerhaltung
    {
        public List<Immobilie> immobilienList { get; set; }
        public ImmobiliVerhaltung()
        {
            immobilienList = new List<Immobilie>();
            
        }
        public void AddImmobilie(Immobilie immobilie)
        {
            immobilienList.Add(immobilie);
            
        }
  
    }
}
   



