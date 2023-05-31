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
                Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie immo = new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text),
                    Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text),heizungT, ad);
                immo.GetGesamtWohnfläche(Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
                immoVerwaltung.AddImmobilie(immo);
                
                    ListViewItem listViewItem = new ListViewItem(textBox_baujahr.Text);
                    //listViewItem.SubItems.Add(textBox_baujahr.Text);
                    listViewItem.SubItems.Add(textBox_GründstückSize.Text);
                    listViewItem.SubItems.Add(textBox_WohnfläscheSize.Text);
                    listViewItem.SubItems.Add(textBox_Kellerfläschesize.Text);
                    listViewItem.SubItems.Add(comboBox_Heizung.Text);
                    listViewItem.SubItems.Add(ad.ToString());
                    listView_Immobilie.Items.Add(listViewItem);
                    textBox_baujahr.Clear();    
                    textBox_GründstückSize.Clear();
                    textBox_Kellerfläschesize.Clear();
                    textBox_WohnfläscheSize.Clear();
                    textBox_StraßeName.Clear(); 
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
                    selectedItem.SubItems[1].Text = textBox_GründstückSize.Text;
                    selectedItem.SubItems[2].Text = textBox_Kellerfläschesize.Text;
                    selectedItem.SubItems[3].Text = textBox_WohnfläscheSize.Text;
                    selectedItem.SubItems[4].Text = comboBox_Heizung.Text;

                    // Clear the editing controls after the update
                    textBox_baujahr.Text = string.Empty;
                    textBox_GründstückSize.Text = string.Empty;
                    textBox_Kellerfläschesize.Text = string.Empty;
                    textBox_WohnfläscheSize.Text = string.Empty;
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
                textBox_GründstückSize.Text = string.Empty;
                textBox_Kellerfläschesize.Text = string.Empty;
                textBox_WohnfläscheSize.Text = string.Empty;
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

        public void textBox_WohnfläscheSize_TextChanged(object sender, EventArgs e)
        {
            
         
        }

        public void textBox_GründstückSize_TextChanged(object sender, EventArgs e)
        {

           
        }

        private void textBox_Kellerfläschesize_TextChanged(object sender, EventArgs e)
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
                textBox_GründstückSize.Text = this.listView_Immobilie.Items[index].SubItems[1].Text;
                textBox_WohnfläscheSize.Text = this.listView_Immobilie.Items[index].SubItems[2].Text;
                textBox_Kellerfläschesize.Text = this.listView_Immobilie.Items[index].SubItems[3].Text;
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