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
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
                immoVerwaltung.AddImmobilie(imm);
                //immoVerwaltung.AddImmobilie(new Immobilie( Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text)));
                imm.GetGesamtWohnfläche( Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
          
            };
            button_Edit.Click += (s, e) =>
            {
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
                immoVerwaltung.EditImmobilie(imm);
            };
            button_Delete.Click += (s, e) =>
            {
                Immobilie imm = new Immobilie(Convert.ToInt32(textBox_baujahr.Text), Convert.ToDouble(textBox_GründstückSize.Text), Convert.ToDouble(textBox_Kellerfläschesize.Text), Convert.ToDouble(textBox_WohnfläscheSize.Text));
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