using ImmobilienVerwaltung;

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
            listView_Immobilie.LabelEdit = true;


            button_Add.Click += (s, e) =>
            {  
                HeizungSystemTyp heizungT= new HeizungSystemTyp();    
                Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text); 
                Immobilie immo = new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text),heizungT, ad);
                immo.GetGesamtWohnfläche(Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
                immoVerwaltung.AddImmobilie(immo);
                
                    ListViewItem listViewItem = new ListViewItem(textBox_baujahr.Text);
                    //listViewItem.SubItems.Add(textBox_baujahr.Text);
                    listViewItem.SubItems.Add(textBox_GründstückSize.Text);
                    listViewItem.SubItems.Add(textBox_Kellerfläschesize.Text);
                    listViewItem.SubItems.Add(textBox_WohnfläscheSize.Text);
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






            };
            button_Delete.Click += (s, e) =>
            {
                HeizungSystemTyp heizungT = new HeizungSystemTyp();
                Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text), heizungT, ad);
                //immoVerwaltung.DeleteImmobilie();
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

            //TextWriter tw = new StreamWriter("C:/Users/Public/RealStateData/PropertyInfo.txt");  
            //tw.WriteLine(immoVerwaltung.immobilienList.SingleOrDefault());
            //tw.Close();
            
        }

        private void button_Read_Click(object sender, EventArgs e)
        {

        }

        private void listView_Immobilie_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}