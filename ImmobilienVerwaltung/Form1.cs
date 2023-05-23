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
                Address ad = new Address(textBox_Stra�eName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text); 
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text), ad);
                immoVerwaltung.AddImmobilie(imm);
                //immoVerwaltung.AddImmobilie(new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text)));
                imm.GetGesamtWohnfl�che( Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text));
          
            };
            button_Edit.Click += (s, e) =>
            {
                Address ad = new Address(textBox_Stra�eName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text),ad);
                immoVerwaltung.EditImmobilie(imm);
            };
            button_Delete.Click += (s, e) =>
            {
                Address ad = new Address(textBox_Stra�eName.Text, textBox_HausNr.Text, textBox_PLZ.Text, textBox_Stadt.Text);
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_Gr�ndst�ckSize.Text), Convert.ToDouble(textBox_Kellerfl�schesize.Text), Convert.ToDouble(textBox_Wohnfl�scheSize.Text), ad);
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
    }
}