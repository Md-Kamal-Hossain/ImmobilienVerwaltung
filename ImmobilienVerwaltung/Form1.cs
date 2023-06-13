using ImmobilienVerwaltung;
using System.Collections;
using System;
using System.IO;
using CsvHelper;

namespace ImmobilienVerwaltung
{
    public partial class Form1 : Form
    {
        //creating an object of ImmobiliVerhaltung-class
        //ImmobiliVerhaltung immoVerwaltung = new ImmobiliVerhaltung();
        string path = @"C:/Users/Public/RealEstateData/PropertyINFO.txt";
        public Form1()
        {
            InitializeComponent();
            
            

            comboBox_Heizung.DataSource = Enum.GetValues(typeof(HeizungSystemTyp));
           

        }

        public void listView_Immobilie_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            // SelectedIndices property returns collection of indices wich is stored in indexes
            // which is a instance of ListView.SelectedIndexCollection
            ListView.SelectedIndexCollection indexes = listView_Immobilie.SelectedIndices;
            foreach (int index in indexes)
            {
                //assigning values(subitems) from listview to the corresponding textboxes
                textBox_baujahr.Text = this.listView_Immobilie.Items[index].SubItems[0].Text;
                textBox_GründstückSize.Text = this.listView_Immobilie.Items[index].SubItems[1].Text;
                textBox_WohnfläscheSize.Text = this.listView_Immobilie.Items[index].SubItems[2].Text;
                textBox_Kellerfläschesize.Text = this.listView_Immobilie.Items[index].SubItems[3].Text;
                comboBox_Heizung.Text = this.listView_Immobilie.Items[index].SubItems[5].Text;

                //splitting address into Street, housno, PLZ and Stadt
                //so that asign those to corresponding textboxes
                char[] separators = { ';', '-', '.', ':' };
                string[] parts2 = this.listView_Immobilie.Items[index].SubItems[6].Text.Split(separators);
                textBox_StraßeName.Text = parts2[2];
                textBox_HausNr.Text = parts2[4];
                textBox_PLZ.Text = parts2[6];
                textBox_Stadt.Text = parts2[8];
            }
            if(indexes.Count<1)
            {
                textBox_baujahr.Clear();
                textBox_GründstückSize.Clear();
                textBox_Kellerfläschesize.Clear();
                textBox_WohnfläscheSize.Clear();
                comboBox_Heizung.SelectedIndex = -1;
                textBox_StraßeName.Clear();
                textBox_HausNr.Clear();
                textBox_PLZ.Clear();
                textBox_Stadt.Clear();
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
            if (string.IsNullOrEmpty(textBox_baujahr.Text) && string.IsNullOrEmpty(textBox_GründstückSize.Text)
                && string.IsNullOrEmpty(textBox_WohnfläscheSize.Text) && string.IsNullOrEmpty(textBox_StraßeName.Text) && string.IsNullOrEmpty(textBox_HausNr.Text))
            {
                MessageBox.Show("Please fill in all the required textboxes.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AddItemToListView();
            }
           

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
            //only call the method if an item from litview gets selected
            if (listView_Immobilie.SelectedItems.Count > 0)
            {
                EditItemInListView();
            }
            else
            {  
                //Messege if click on edit without selecting an item
                MessageBox.Show("Please select the line you want to edit", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void comboBox_Heizung_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void button_Save_Click(object sender, EventArgs e)
        {
                      
                SaveListViewItemsToFile();            

        }
        private void button_Read_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(path);
            string line;
            if((line = reader.ReadLine()) != null)
            {
                ReadDataFromTextFile();
                reader.Close();
            }
            else
            {
                MessageBox.Show("Your file does not have any data!");
            }
        
        }

        private void button_Delete_Click(object sender, EventArgs e)
        {
            if (listView_Immobilie.SelectedItems.Count > 0)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to delete?", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    DeleteItemFromListView();
                }
               
            }
            else
            {
                MessageBox.Show("Please select the line you want to delete");
            }

            


        }
        private void textBox_Stadt_TextChanged(object sender, EventArgs e)
        {

        }
        //Read Text file
        private void ReadDataFromTextFile()
        {  
            //clear ListView control before reading; otherwise redundent might be shown data
            listView_Immobilie.Items.Clear();
            using (StreamReader reader = new StreamReader(path))
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
                   MessageBox.Show("An error occurred: " + ex.Message);
                }
                reader.Dispose();


            }
            


        }
        // Save the ListView items to a text file
        private void SaveListViewItemsToFile()
        {
           
               // instance of Streamwriter                 
                using (StreamWriter writer = new StreamWriter(path))
                {
                    //iterate through all the item in listview_Immobilie instance
                    foreach (ListViewItem item in listView_Immobilie.Items)
                    {
                        //Empty list
                        List<string> subItems = new List<string>();
                        //iterate through all the subitems of an item
                        for (int i = 0; i < item.SubItems.Count; i++)
                        {
                        //populating the emptylist through appending
                        subItems.Add(item.SubItems[i].Text);
                        }
                        // Write the properties to the file
                        writer.WriteLine(string.Join(",", subItems));

                    }

                }

                        textBox_baujahr.Clear();
                        textBox_GründstückSize.Clear();
                        textBox_Kellerfläschesize.Clear();
                        textBox_WohnfläscheSize.Clear();
                        comboBox_Heizung.SelectedIndex = -1;
                        textBox_StraßeName.Clear();
                        textBox_HausNr.Clear();
                        textBox_PLZ.Clear();
                        textBox_Stadt.Clear();

        }
        // Add an item to the ListView and save it to a file
        private void AddItemToListView()
        {
            HeizungSystemTyp heizungT = new HeizungSystemTyp();
            Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
            Immobilie immo = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text),
                Convert.ToDouble(textBox_WohnfläscheSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), heizungT,ad);
            immo.GetGesamtWohnfläche(Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
            //immoVerwaltung.AddImmobilie(immo);
            var doubleKeller = Convert.ToDouble(textBox_Kellerfläschesize.Text);
            var doubleWohnflasche = Convert.ToDouble(textBox_WohnfläscheSize.Text);
            double TotalWhonflasche = immo.GetGesamtWohnfläche(doubleKeller, doubleWohnflasche);
        
            
            // creates instance of  ListviewItem 
            ListViewItem item = new ListViewItem(textBox_baujahr.Text);
            // creates instance of List 
            List<string> subItems = new List<string>();
            //apppending subitems
            subItems.Add(textBox_GründstückSize.Text);
            subItems.Add(textBox_WohnfläscheSize.Text);
            subItems.Add(textBox_Kellerfläschesize.Text);
            subItems.Add(TotalWhonflasche.ToString());
            subItems.Add(comboBox_Heizung.Text);
            subItems.Add(ad.ToString());
            //iterate through all the subitems and add to the item
            foreach (string subItem in subItems)
            {
                item.SubItems.Add(subItem);
            }

            // Add the item to the ListView
            listView_Immobilie.Items.Add(item);

            textBox_baujahr.Clear();
            textBox_GründstückSize.Clear();
            textBox_Kellerfläschesize.Clear();
            textBox_WohnfläscheSize.Clear();
            comboBox_Heizung.SelectedIndex = -1;
            textBox_StraßeName.Clear();
            textBox_HausNr.Clear();
            textBox_PLZ.Clear();
            textBox_Stadt.Clear();
        }
        // Edit an item in the ListView and save it to a file
        private void EditItemInListView()
        {
            HeizungSystemTyp heizungT = new HeizungSystemTyp();
            Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
            Immobilie immo = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text),
                Convert.ToDouble(textBox_WohnfläscheSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), heizungT, ad);
            immo.GetGesamtWohnfläche(Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
            //subscribing listView_Immobilie_SelectedIndexChanged to the event SelectedIndexChanged
            listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;

            if (listView_Immobilie.SelectedItems.Count > 0)
            {
                // Retrieve the selected ListViewItem
                // Here we only edit one line at a time
                ListViewItem item = listView_Immobilie.SelectedItems[0];

                // Update the properties of the ListViewItem
                // Asssigning value from textboxes to to respective subitems 
                item.SubItems[0].Text = textBox_baujahr.Text;
                item.SubItems[1].Text = textBox_GründstückSize.Text;
                item.SubItems[2].Text = textBox_Kellerfläschesize.Text;
                item.SubItems[3].Text = textBox_WohnfläscheSize.Text;
                var doubleKeller = Convert.ToDouble(textBox_Kellerfläschesize.Text);
                var doubleWohnflasche = Convert.ToDouble(textBox_WohnfläscheSize.Text);
                double TotalWhonflasche = immo.GetGesamtWohnfläche(doubleKeller, doubleWohnflasche);
                item.SubItems[4].Text = TotalWhonflasche.ToString();
                item.SubItems[5].Text = comboBox_Heizung.Text;
                item.SubItems[6].Text = $"Address:  Straße-{textBox_StraßeName.Text}; HouseNo- {textBox_HausNr.Text}; PLZ- {textBox_PLZ.Text}; Stadt- {textBox_Stadt.Text}.";
            }

        }
        private void DeleteItemFromListView()
        {
            //subscribing listView_Immobilie_SelectedIndexChanged to the event SelectedIndexChanged
            listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;
            // Here we can select one line at a time and delete one line at a time
            ListViewItem item = listView_Immobilie.SelectedItems[0];
            int index = listView_Immobilie.SelectedItems[0].Index;
            //For future if want to delete more than one lines
            if (index >= 0 && index < listView_Immobilie.Items.Count)
            {
                // Remove the ListViewItem at the specified index
                listView_Immobilie.Items.RemoveAt(index);
            }
            textBox_baujahr.Clear();
            textBox_GründstückSize.Clear();
            textBox_Kellerfläschesize.Clear();
            textBox_WohnfläscheSize.Clear();
            comboBox_Heizung.SelectedIndex = -1;
            textBox_StraßeName.Clear();
            textBox_HausNr.Clear();
            textBox_PLZ.Clear();
            textBox_Stadt.Clear();
        }          
    }

 
}