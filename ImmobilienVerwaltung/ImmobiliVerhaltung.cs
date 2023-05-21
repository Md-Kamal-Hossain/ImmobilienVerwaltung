using DocumentFormat.OpenXml.Spreadsheet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImmobilienVerwaltung
{
    public class ImmobiliVerhaltung
    {
        public List<Immobilie> immobilienList { get; set; }
         
        public ImmobiliVerhaltung()
        {
          immobilienList = new List<Immobilie>();
          
        }     
        public  void AddImmobilie(Immobilie immobilie)
        {
            
           immobilienList.Add(immobilie);

        }
        public List<Immobilie> DeleteImmobilie(int? immobilieId) //item.Kellerfläsche.ToString()
        {

            var item = immobilienList.SingleOrDefault(x => x.Id == immobilieId);
            if (item != null)
                immobilienList.Remove(item);
            return immobilienList;
        }
        public List<Immobilie> EditImmobilie(Immobilie _immobilie)
        {
            int index = immobilienList.FindIndex(s => s.Id == _immobilie.Id);

            if (index != -1)
            {
                return immobilienList;
            }
            else
            {  
             
                immobilienList[index] = _immobilie;
                return immobilienList;
            }
                        
        }
}
}
   



