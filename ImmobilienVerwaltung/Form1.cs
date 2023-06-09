using ImmobilienVerwaltung;
using System.Collections;
using System;
using System.IO;
using CsvHelper;

namespace ImmobilienVerwaltung
{
    public partial class Form1 : Form
    {
       
        ImmobiliVerhaltung immoVerwaltung = new ImmobiliVerhaltung();
        string path = @"C:/Users/Public/RealEstateData/PropertyInfo.txt";
        

        public Form1()
        {   
            InitializeComponent();
            //button_Save.Enabled = false; // Disable the save button by default
           // button_Save.Enabled = button_Add.MouseClick||button_Edit_Click||button_Delete_Click;
            comboBox_Heizung.DataSource = Enum.GetValues(typeof(HeizungSystemTyp));
            ListView.SelectedIndexCollection indexes = listView_Immobilie.SelectedIndices;

        }
        //Form1 constructor ends here
        
        public void listView_Immobilie_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            ListView.SelectedIndexCollection indexes = this.listView_Immobilie.SelectedIndices;
            foreach (int index in indexes)
            {
                textBox_baujahr.Text = this.listView_Immobilie.Items[index].SubItems[0].Text;
                textBox_GründstückSize.Text = this.listView_Immobilie.Items[index].SubItems[1].Text;
                textBox_WohnfläscheSize.Text = this.listView_Immobilie.Items[index].SubItems[2].Text;
                textBox_Kellerfläschesize.Text = this.listView_Immobilie.Items[index].SubItems[3].Text;
                comboBox_Heizung.Text = this.listView_Immobilie.Items[index].SubItems[4].Text;
                char[] separators = { ';','-','.',':'};
                             
                                                      
                string[] parts2 = this.listView_Immobilie.Items[index].SubItems[5].Text.Split(separators);
                //string[] part22 = parts2[0].Split(Sep);  
                

               
                textBox_StraßeName.Text = parts2[2];
                textBox_HausNr.Text = parts2[4];
                textBox_PLZ.Text = parts2[6];
                textBox_Stadt.Text = parts2[8];



            }

        }
           
        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void Form1_Load(object sender, EventArgs e)
        {

        }

        public void button_Add_Click(object sender, EventArgs e)

        {
            
            AddItemToListViewAndSave();

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
            
            EditItemInListViewAndSave();
        }
       
        private void comboBox_Heizung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_Save_Click(object sender, EventArgs e)
        {

            if (listView_Immobilie.Items.Count > 0)
            {
                SaveListViewItemsToFile();
            }
            
            
            

        }
       


        private void button_Read_Click(object sender, EventArgs e)
        {
            listView_Immobilie.Items.Clear();
            if (listView_Immobilie.Items.Count == 0)
            {
                
                try
                {
                    // Read all lines from the text file
                    string[] lines = File.ReadAllLines(path);




                    // Add subitems to the ListViewItem
                    foreach (string line in lines)
                    {
                        // Split the line by comma to extract the data
                        string[] parts = line.Split(',');

                        // Create a new ListViewItem with the first part as text
                        ListViewItem item = new ListViewItem(parts[0]);

                        // Add subitems to the ListViewItem
                        for (int i = 1; i < parts.Length; i++)
                        {
                            item.SubItems.Add(parts[i]);
                        }

                        // Add the ListViewItem to the ListView
                        listView_Immobilie.Items.Add(item);
                    }



                }
                catch (Exception ex)
                {
                    // MessageBox.Show("Error reading file: " + ex.Message);
                    MessageBox.Show("Your file does not hsve any data!");
                }
            }


        }


        private void button_Delete_Click(object sender, EventArgs e)
        {
            
            DeleteItemFromListViewAndSave();
           
        }
       
                    
        
        private void textBox_Stadt_TextChanged(object sender, EventArgs e)
        {

        }
        // Save the ListView items to a text file
        private void SaveListViewItemsToFile()
        {
            // string path = @"C:/Users/Public/RealStateData/PropertyInfo.txt";
            //// ListView listView_Immobilie = new ListView();
            if(listView_Immobilie.Items!=null)
            {
                using (StreamWriter writer = new StreamWriter(path))
                {


                    foreach (ListViewItem item in listView_Immobilie.Items)
                    {

                        List<string> subItems = new List<string>();
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                            subItems.Add(item.SubItems[i].Text);
                        }

                        // Write the properties to the file
                        writer.WriteLine(string.Join(",", subItems));
                    }



                }

            }
           
            textBox_baujahr.Clear();
            textBox_GründstückSize.Clear();
            textBox_Kellerfläschesize.Clear();
            textBox_WohnfläscheSize.Clear();
            textBox_StraßeName.Clear();
            textBox_HausNr.Clear();
            textBox_PLZ.Clear();
            textBox_Stadt.Clear();
            //if (!File.Exists(path))
            //{
            //    using (var stream = File.Create(path)) ;
            //}
            //else
            //{
            //    using (TextWriter tw = new StreamWriter(path))
            //    {

            //    for (int i = 0; i < listView_Immobilie.Items.Count; i++)
            //    {
            //        tw.WriteLine(listView_Immobilie.Items[i].SubItems[0].Text + "," + listView_Immobilie.Items[i].SubItems[1].Text
            //    + "," + listView_Immobilie.Items[i].SubItems[2].Text + "," + listView_Immobilie.Items[i].SubItems[3].Text + ","
            //    + listView_Immobilie.Items[i].SubItems[4].Text + "," + listView_Immobilie.Items[i].SubItems[5].Text);
            //    }

            //    }

            //}
        }
        // Add an item to the ListView and save it to a file
        private void AddItemToListViewAndSave()
        {
            //// Create a new ListViewItem
            //HeizungSystemTyp heizungT = new HeizungSystemTyp();
            Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
            //Immobilie immo = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text),
            //    Convert.ToDouble(textBox_WohnfläscheSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), heizungT, ad);
            //immo.GetGesamtWohnfläche(Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
            //immoVerwaltung.AddImmobilie(immo);

            ListViewItem item = new ListViewItem(textBox_baujahr.Text);
            List<string> subItems = new List<string>();
           // subItems.Add(textBox_baujahr.Text);
            subItems.Add(textBox_GründstückSize.Text);
            subItems.Add(textBox_WohnfläscheSize.Text);
            subItems.Add(textBox_Kellerfläschesize.Text);
            subItems.Add(comboBox_Heizung.Text);
            subItems.Add(ad.ToString());

            foreach (string subItem in subItems )
            {
                item.SubItems.Add(subItem);
            }

            // Add the item to the ListView
            listView_Immobilie.Items.Add(item);

            textBox_baujahr.Clear();
            textBox_GründstückSize.Clear();
            textBox_Kellerfläschesize.Clear();
            textBox_WohnfläscheSize.Clear();
            textBox_StraßeName.Clear();
            textBox_HausNr.Clear();
            textBox_PLZ.Clear();
            textBox_Stadt.Clear();
        }
        // Edit an item in the ListView and save it to a file
        private void EditItemInListViewAndSave( )
        {

            listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;

            //ListViewItem item = listView_Immobilie.SelectedItems[0];
            int index = listView_Immobilie.SelectedItems[0].Index;
            if (listView_Immobilie.SelectedItems.Count > 0)
            {
                // Retrieve the selected ListViewItem
                ListViewItem item = listView_Immobilie.SelectedItems[0];

                // Update the properties of the ListViewItem
                //item.Text = "New Text";
                item.SubItems[0].Text = textBox_baujahr.Text;
                item.SubItems[1].Text = textBox_GründstückSize.Text;
                item.SubItems[2].Text = textBox_Kellerfläschesize.Text;
                item.SubItems[3].Text = textBox_WohnfläscheSize.Text;
                item.SubItems[4].Text = comboBox_Heizung.Text;
                item.SubItems[5].Text = $"Address:  Straße-{textBox_StraßeName.Text} , HouseNo- {textBox_HausNr.Text} ; PLZ- {textBox_PLZ.Text} ; Stadt- {textBox_Stadt.Text}.";
                




            }
            button_Save.Enabled = (listView_Immobilie.Items.Count > 0);
          


        }

        // Delete an item from the ListView and save it to a file
        private void DeleteItemFromListViewAndSave()
        {
            listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;
            ListViewItem item = listView_Immobilie.SelectedItems[0];
            int index = listView_Immobilie.SelectedItems[0].Index;

            if (index >= 0 && index < listView_Immobilie.Items.Count)
            {
                // Remove the ListViewItem at the specified index
                listView_Immobilie.Items.RemoveAt(index);

                // Save the updated ListView items to a file
                //SaveListViewItemsToFile();
            }
                textBox_baujahr.Clear();
                textBox_GründstückSize.Clear();
                textBox_Kellerfläschesize.Clear();
                textBox_WohnfläscheSize.Clear();
                textBox_StraßeName.Clear();
                textBox_HausNr.Clear();
                textBox_PLZ.Clear();
                textBox_Stadt.Clear();
        }





    }
}