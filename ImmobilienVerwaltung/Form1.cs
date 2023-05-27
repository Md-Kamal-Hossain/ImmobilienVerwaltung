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
                Address ad = new Address(textBox_Stra�eName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text); 
                Immobilie immo = new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text),heizungT, ad);
                immo.GetGesamtWohnfl�che(Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text));
                immoVerwaltung.AddImmobilie(immo);
                
                    ListViewItem listViewItem = new ListViewItem(textBox_baujahr.Text);
                    //listViewItem.SubItems.Add(textBox_baujahr.Text);
                    listViewItem.SubItems.Add(textBox_Gr�ndst�ckSize.Text);
                    listViewItem.SubItems.Add(textBox_Kellerfl�schesize.Text);
                    listViewItem.SubItems.Add(textBox_Wohnfl�scheSize.Text);
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






            };
            button_Delete.Click += (s, e) =>
            {
                HeizungSystemTyp heizungT = new HeizungSystemTyp();
                Address ad = new Address(textBox_Stra�eName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text), heizungT, ad);
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