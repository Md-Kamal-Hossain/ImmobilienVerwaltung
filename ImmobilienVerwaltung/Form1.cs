using ImmobilienVerwaltung;

namespace ImmobilienVerwaltung
{
    public partial class Form1 : Form
    {
        private int id;

        public Form1()
        {
            InitializeComponent();
            ImmobiliVerhaltung immoVerwaltung = new ImmobiliVerhaltung();
            
            
            button_Add.Click += (s, e) =>
            {
                Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text); 
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text), ad);
                immoVerwaltung.AddImmobilie(imm);
                //immoVerwaltung.AddImmobilie(new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text)));
                imm.GetGesamtWohnfläche( Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
          
            };
            button_Edit.Click += (s, e) =>
            {
                Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text),ad);
                immoVerwaltung.EditImmobilie(imm);
            };
            button_Delete.Click += (s, e) =>
            {
                Address ad = new Address(textBox_StraßeName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text), ad);
                //int id = new Immobilie.Id;
                immoVerwaltung.DeleteImmobilie(imm.Id);
            };

        }
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
    }
}