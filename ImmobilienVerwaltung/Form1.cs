using ImmobilienVerwaltung;
using System.Collections;
using System;
using System.IO;

namespace ImmobilienVerwaltung
{
    public partial class Form1 : Form
    {
        ImmobiliVerhaltung immoVerwaltung = new ImmobiliVerhaltung();

        public Form1()
        {
            InitializeComponent();
            comboBox_Heizung.DataSource = Enum.GetValues(typeof(HeizungSystemTyp));

            //ImmobiliVerhaltung immoVerwaltung = new ImmobiliVerhaltung();

            //immoVerwaltung.immobilienList = listView_Immobilie.ge
            //listView_Immobilie.LabelEdit = true;


            button_Add.Click += (s, e) =>
            {  
                HeizungSystemTyp heizungT= new HeizungSystemTyp();
                Address ad = new Address(textBox_Stra�eName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie immo = new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text),
                    Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text),heizungT, ad);
                immo.GetGesamtWohnfl�che(Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text));
                immoVerwaltung.AddImmobilie(immo);
                
                    ListViewItem listViewItem = new ListViewItem(textBox_baujahr.Text);
                    //listViewItem.SubItems.Add(textBox_baujahr.Text);
                    listViewItem.SubItems.Add(textBox_Gr�ndst�ckSize.Text);
                    listViewItem.SubItems.Add(textBox_Wohnfl�scheSize.Text);
                    listViewItem.SubItems.Add(textBox_Kellerfl�schesize.Text);
                    listViewItem.SubItems.Add(comboBox_Heizung.Text);
                    listViewItem.SubItems.Add(ad.ToString());
                    listView_Immobilie.Items.Add(listViewItem);
                    textBox_baujahr.Clear();    
                    textBox_Gr�ndst�ckSize.Clear();
                    textBox_Kellerfl�schesize.Clear();
                    textBox_Wohnfl�scheSize.Clear();
                    textBox_Stra�eName.Clear(); 
                    textBox_HausNr.Clear(); 
                    textBox_PLZ.Clear();    
                    textBox_Stadt.Clear(); 
                    

                //SaveImmobilie();

                //immoVerwaltung.SaveImmobilie();

            };

            button_Edit.Click += (s, e) =>
            {
                listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;
  
                if (listView_Immobilie.SelectedItems.Count > 0)
                {
                    ListViewItem selectedItem = listView_Immobilie.SelectedItems[0];

                    //Update the selected item with the modified values
                    selectedItem.SubItems[0].Text = textBox_baujahr.Text;
                    selectedItem.SubItems[1].Text = textBox_Gr�ndst�ckSize.Text;
                    selectedItem.SubItems[2].Text = textBox_Kellerfl�schesize.Text;
                    selectedItem.SubItems[3].Text = textBox_Wohnfl�scheSize.Text;
                    selectedItem.SubItems[4].Text = comboBox_Heizung.Text;

                    // Clear the editing controls after the update
                    textBox_baujahr.Text = string.Empty;
                    textBox_Gr�ndst�ckSize.Text = string.Empty;
                    textBox_Kellerfl�schesize.Text = string.Empty;
                    textBox_Wohnfl�scheSize.Text = string.Empty;
                }
                

            };
            button_Delete.Click += (s, e) =>
            {

                for (int x = listView_Immobilie.SelectedIndices.Count - 1; x >= 0; x--)
                {
                    int var = listView_Immobilie.SelectedIndices[x];
                    listView_Immobilie.Items.RemoveAt(var);
                }
                // Clear the editing controls after the update
                textBox_baujahr.Text = string.Empty;
                textBox_Gr�ndst�ckSize.Text = string.Empty;
                textBox_Kellerfl�schesize.Text = string.Empty;
                textBox_Wohnfl�scheSize.Text = string.Empty;
            };

        }
        //Form1 constructor ends here


        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button_Add_Click(object sender, EventArgs e)

        { 
      
             
           

        }

        private void textBox_baujahr_TextChanged(object sender, EventArgs e)
        {
            
           
        }

        public void textBox_Wohnfl�scheSize_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        public void textBox_Gr�ndst�ckSize_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox_Kellerfl�schesize_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_Edit_Click(object sender, EventArgs e)
        {
           
        }

        private void comboBox_Heizung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            TextWriter tw = new StreamWriter("C:/Users/Public/RealStateData/PropertyInfo.txt");
            for(int i = 0; i< immoVerwaltung.immobilienList.Count;i++)
            {
                //tw.WriteLine(immoVerwaltung.immobilienList.All());
                tw.WriteLine(i.ToString() + "|" + listView_Immobilie.Items[i].SubItems[0].Text + "|" + listView_Immobilie.Items[i].SubItems[1].Text
                    +"|"+ listView_Immobilie.Items[i].SubItems[2].Text+ "|" + listView_Immobilie.Items[i].SubItems[3].Text+ "|" 
                    + listView_Immobilie.Items[i].SubItems[4].Text + "|" + listView_Immobilie.Items[i].SubItems[5].Text);
            }
            
            tw.Close();

        }

        private void button_Read_Click(object sender, EventArgs e)
        {
            string path = @"C:/Users/Public/RealStateData/PropertyInfo.txt";
            StreamReader sr = new StreamReader(path);   
            string  text = sr.ReadToEnd();
            MessageBox.Show(text);
            sr.Close();

        }

        private void listView_Immobilie_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedIndexCollection indexes = this.listView_Immobilie.SelectedIndices;
            foreach(int index in indexes)
            {
                textBox_baujahr.Text = this.listView_Immobilie.Items[index].SubItems[0].Text;
                textBox_Gr�ndst�ckSize.Text = this.listView_Immobilie.Items[index].SubItems[1].Text;
                textBox_Wohnfl�scheSize.Text = this.listView_Immobilie.Items[index].SubItems[2].Text;
                textBox_Kellerfl�schesize.Text = this.listView_Immobilie.Items[index].SubItems[3].Text;
                comboBox_Heizung.Text = this.listView_Immobilie.Items[index].SubItems[4].Text;
                
            }
          

        }
        private void button_Delete_Click(object sender, EventArgs e)
        {
            
        }
        private void textBox_Stadt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}