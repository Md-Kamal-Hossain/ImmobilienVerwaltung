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

            comboBox_Heizung.DataSource = Enum.GetValues(typeof(HeizungSystemTyp));
            ListView.SelectedIndexCollection indexes = listView_Immobilie.SelectedIndices;

        }

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
                char[] separators = { ';', '-', '.', ':' };
                string[] parts2 = this.listView_Immobilie.Items[index].SubItems[5].Text.Split(separators);
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

            AddItemToListView();

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
            if (listView_Immobilie.SelectedItems.Count > 0)
            {
                EditItemInListView();
            }
            else
            {
                MessageBox.Show("Please select the line you want to edit");
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

                DeleteItemFromListView();
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
            listView_Immobilie.Items.Clear();
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
        // Save the ListView items to a text file
        private void SaveListViewItemsToFile()
        {

            if (listView_Immobilie.SelectedItems.Count > 0)
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
            comboBox_Heizung.SelectedIndex = -1;
            textBox_StraßeName.Clear();
            textBox_HausNr.Clear();
            textBox_PLZ.Clear();
            textBox_Stadt.Clear();

        }
        // Add an item to the ListView and save it to a file
        private void AddItemToListView()
        {
            Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
            ListViewItem item = new ListViewItem(textBox_baujahr.Text);
            List<string> subItems = new List<string>();
            subItems.Add(textBox_GründstückSize.Text);
            subItems.Add(textBox_WohnfläscheSize.Text);
            subItems.Add(textBox_Kellerfläschesize.Text);
            subItems.Add(comboBox_Heizung.Text);
            subItems.Add(ad.ToString());

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

            listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;
            int index = listView_Immobilie.SelectedItems[0].Index;
            if (listView_Immobilie.SelectedItems.Count > 0)
            {
                // Retrieve the selected ListViewItem
                ListViewItem item = listView_Immobilie.SelectedItems[0];

                // Update the properties of the ListViewItem               
                item.SubItems[0].Text = textBox_baujahr.Text;
                item.SubItems[1].Text = textBox_GründstückSize.Text;
                item.SubItems[2].Text = textBox_Kellerfläschesize.Text;
                item.SubItems[3].Text = textBox_WohnfläscheSize.Text;
                item.SubItems[4].Text = comboBox_Heizung.Text;
                item.SubItems[5].Text = $"Address:  Straße-{textBox_StraßeName.Text}; HouseNo- {textBox_HausNr.Text}; PLZ- {textBox_PLZ.Text}; Stadt- {textBox_Stadt.Text}.";
            }

        }
        private void DeleteItemFromListView()
        {
            listView_Immobilie.SelectedIndexChanged += listView_Immobilie_SelectedIndexChanged;
            ListViewItem item = listView_Immobilie.SelectedItems[0];
            int index = listView_Immobilie.SelectedItems[0].Index;

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


            // button_Save.Enabled = (listView_Immobilie.Items.Count > 0);

        }

    // Delete an item from the ListView and save it to a file






}