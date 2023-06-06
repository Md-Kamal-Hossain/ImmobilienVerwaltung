namespace ImmobilienVerwaltung
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_Immobilie = new System.Windows.Forms.Label();
            this.label_BauJahr = new System.Windows.Forms.Label();
            this.label_Grundstücksgröße = new System.Windows.Forms.Label();
            this.label_Wohnfläche = new System.Windows.Forms.Label();
            this.label_Kellerfläche = new System.Windows.Forms.Label();
            this.textBox_baujahr = new System.Windows.Forms.TextBox();
            this.textBox_GründstückSize = new System.Windows.Forms.TextBox();
            this.textBox_WohnfläscheSize = new System.Windows.Forms.TextBox();
            this.textBox_Kellerfläschesize = new System.Windows.Forms.TextBox();
            this.labelStraße = new System.Windows.Forms.Label();
            this.label_Hausnr = new System.Windows.Forms.Label();
            this.label_PLZ = new System.Windows.Forms.Label();
            this.label_Stadt = new System.Windows.Forms.Label();
            this.textBox_StraßeName = new System.Windows.Forms.TextBox();
            this.textBox_HausNr = new System.Windows.Forms.TextBox();
            this.textBox_PLZ = new System.Windows.Forms.TextBox();
            this.textBox_Stadt = new System.Windows.Forms.TextBox();
            this.label_Address = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.button_Delete = new System.Windows.Forms.Button();
            this.button_Read = new System.Windows.Forms.Button();
            this.button_Save = new System.Windows.Forms.Button();
            this.comboBox_Heizung = new System.Windows.Forms.ComboBox();
            this.label_HeizungTyp = new System.Windows.Forms.Label();
            this.listView_Immobilie = new System.Windows.Forms.ListView();
            this.Baujahr = new System.Windows.Forms.ColumnHeader();
            this.Gründstücksgrüße = new System.Windows.Forms.ColumnHeader();
            this.Wohnfläsche = new System.Windows.Forms.ColumnHeader();
            this.Kellerfläsche = new System.Windows.Forms.ColumnHeader();
            this.Heizungtyp = new System.Windows.Forms.ColumnHeader();
            this.Address = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label_Immobilie
            // 
            this.label_Immobilie.AutoSize = true;
            this.label_Immobilie.Location = new System.Drawing.Point(418, 16);
            this.label_Immobilie.Name = "label_Immobilie";
            this.label_Immobilie.Size = new System.Drawing.Size(77, 20);
            this.label_Immobilie.TabIndex = 0;
            this.label_Immobilie.Text = "Immobilie";
            this.label_Immobilie.Click += new System.EventHandler(this.label1_Click);
            // 
            // label_BauJahr
            // 
            this.label_BauJahr.AutoSize = true;
            this.label_BauJahr.Location = new System.Drawing.Point(43, 99);
            this.label_BauJahr.Name = "label_BauJahr";
            this.label_BauJahr.Size = new System.Drawing.Size(59, 20);
            this.label_BauJahr.TabIndex = 1;
            this.label_BauJahr.Text = "Baujahr";
            // 
            // label_Grundstücksgröße
            // 
            this.label_Grundstücksgröße.AutoSize = true;
            this.label_Grundstücksgröße.Location = new System.Drawing.Point(43, 145);
            this.label_Grundstücksgröße.Name = "label_Grundstücksgröße";
            this.label_Grundstücksgröße.Size = new System.Drawing.Size(127, 20);
            this.label_Grundstücksgröße.TabIndex = 2;
            this.label_Grundstücksgröße.Text = "Grundstücksgröße";
            // 
            // label_Wohnfläche
            // 
            this.label_Wohnfläche.AutoSize = true;
            this.label_Wohnfläche.Location = new System.Drawing.Point(43, 190);
            this.label_Wohnfläche.Name = "label_Wohnfläche";
            this.label_Wohnfläche.Size = new System.Drawing.Size(87, 20);
            this.label_Wohnfläche.TabIndex = 3;
            this.label_Wohnfläche.Text = "Wohnfläche";
            // 
            // label_Kellerfläche
            // 
            this.label_Kellerfläche.AutoSize = true;
            this.label_Kellerfläche.Location = new System.Drawing.Point(43, 239);
            this.label_Kellerfläche.Name = "label_Kellerfläche";
            this.label_Kellerfläche.Size = new System.Drawing.Size(87, 20);
            this.label_Kellerfläche.TabIndex = 4;
            this.label_Kellerfläche.Text = "Kellerfläche";
            // 
            // textBox_baujahr
            // 
            this.textBox_baujahr.Location = new System.Drawing.Point(193, 92);
            this.textBox_baujahr.Name = "textBox_baujahr";
            this.textBox_baujahr.Size = new System.Drawing.Size(125, 27);
            this.textBox_baujahr.TabIndex = 6;
            this.textBox_baujahr.TextChanged += new System.EventHandler(this.textBox_baujahr_TextChanged);
            // 
            // textBox_GründstückSize
            // 
            this.textBox_GründstückSize.Location = new System.Drawing.Point(193, 138);
            this.textBox_GründstückSize.Name = "textBox_GründstückSize";
            this.textBox_GründstückSize.Size = new System.Drawing.Size(125, 27);
            this.textBox_GründstückSize.TabIndex = 7;
            this.textBox_GründstückSize.TextChanged += new System.EventHandler(this.textBox_GründstückSize_TextChanged);
            // 
            // textBox_WohnfläscheSize
            // 
            this.textBox_WohnfläscheSize.Location = new System.Drawing.Point(193, 190);
            this.textBox_WohnfläscheSize.Name = "textBox_WohnfläscheSize";
            this.textBox_WohnfläscheSize.Size = new System.Drawing.Size(125, 27);
            this.textBox_WohnfläscheSize.TabIndex = 8;
            this.textBox_WohnfläscheSize.TextChanged += new System.EventHandler(this.textBox_WohnfläscheSize_TextChanged);
            // 
            // textBox_Kellerfläschesize
            // 
            this.textBox_Kellerfläschesize.Location = new System.Drawing.Point(193, 239);
            this.textBox_Kellerfläschesize.Name = "textBox_Kellerfläschesize";
            this.textBox_Kellerfläschesize.Size = new System.Drawing.Size(125, 27);
            this.textBox_Kellerfläschesize.TabIndex = 9;
            this.textBox_Kellerfläschesize.TextChanged += new System.EventHandler(this.textBox_Kellerfläschesize_TextChanged);
            // 
            // labelStraße
            // 
            this.labelStraße.AutoSize = true;
            this.labelStraße.Location = new System.Drawing.Point(406, 92);
            this.labelStraße.Name = "labelStraße";
            this.labelStraße.Size = new System.Drawing.Size(51, 20);
            this.labelStraße.TabIndex = 11;
            this.labelStraße.Text = "Straße";
            // 
            // label_Hausnr
            // 
            this.label_Hausnr.AutoSize = true;
            this.label_Hausnr.Location = new System.Drawing.Point(406, 138);
            this.label_Hausnr.Name = "label_Hausnr";
            this.label_Hausnr.Size = new System.Drawing.Size(58, 20);
            this.label_Hausnr.TabIndex = 12;
            this.label_Hausnr.Text = "Hausnr.";
            // 
            // label_PLZ
            // 
            this.label_PLZ.AutoSize = true;
            this.label_PLZ.Location = new System.Drawing.Point(406, 187);
            this.label_PLZ.Name = "label_PLZ";
            this.label_PLZ.Size = new System.Drawing.Size(33, 20);
            this.label_PLZ.TabIndex = 13;
            this.label_PLZ.Text = "PLZ";
            // 
            // label_Stadt
            // 
            this.label_Stadt.AutoSize = true;
            this.label_Stadt.Location = new System.Drawing.Point(410, 236);
            this.label_Stadt.Name = "label_Stadt";
            this.label_Stadt.Size = new System.Drawing.Size(44, 20);
            this.label_Stadt.TabIndex = 14;
            this.label_Stadt.Text = "Stadt";
            // 
            // textBox_StraßeName
            // 
            this.textBox_StraßeName.Location = new System.Drawing.Point(553, 89);
            this.textBox_StraßeName.Name = "textBox_StraßeName";
            this.textBox_StraßeName.Size = new System.Drawing.Size(125, 27);
            this.textBox_StraßeName.TabIndex = 15;
            // 
            // textBox_HausNr
            // 
            this.textBox_HausNr.Location = new System.Drawing.Point(553, 138);
            this.textBox_HausNr.Name = "textBox_HausNr";
            this.textBox_HausNr.Size = new System.Drawing.Size(125, 27);
            this.textBox_HausNr.TabIndex = 16;
            // 
            // textBox_PLZ
            // 
            this.textBox_PLZ.Location = new System.Drawing.Point(553, 184);
            this.textBox_PLZ.Name = "textBox_PLZ";
            this.textBox_PLZ.Size = new System.Drawing.Size(125, 27);
            this.textBox_PLZ.TabIndex = 17;
            // 
            // textBox_Stadt
            // 
            this.textBox_Stadt.Location = new System.Drawing.Point(553, 229);
            this.textBox_Stadt.Name = "textBox_Stadt";
            this.textBox_Stadt.Size = new System.Drawing.Size(125, 27);
            this.textBox_Stadt.TabIndex = 18;
            this.textBox_Stadt.TextChanged += new System.EventHandler(this.textBox_Stadt_TextChanged);
            // 
            // label_Address
            // 
            this.label_Address.AutoSize = true;
            this.label_Address.Location = new System.Drawing.Point(597, 42);
            this.label_Address.Name = "label_Address";
            this.label_Address.Size = new System.Drawing.Size(70, 20);
            this.label_Address.TabIndex = 19;
            this.label_Address.Text = "Addresse";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(59, 412);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(94, 29);
            this.button_Add.TabIndex = 20;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Location = new System.Drawing.Point(226, 412);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(94, 29);
            this.button_Edit.TabIndex = 21;
            this.button_Edit.Text = "Edit";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(360, 412);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(94, 29);
            this.button_Delete.TabIndex = 22;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // button_Read
            // 
            this.button_Read.Location = new System.Drawing.Point(59, 485);
            this.button_Read.Name = "button_Read";
            this.button_Read.Size = new System.Drawing.Size(94, 29);
            this.button_Read.TabIndex = 23;
            this.button_Read.Text = "Read";
            this.button_Read.UseVisualStyleBackColor = true;
            this.button_Read.Click += new System.EventHandler(this.button_Read_Click);
            // 
            // button_Save
            // 
            this.button_Save.Location = new System.Drawing.Point(224, 485);
            this.button_Save.Name = "button_Save";
            this.button_Save.Size = new System.Drawing.Size(94, 29);
            this.button_Save.TabIndex = 24;
            this.button_Save.Text = "Save";
            this.button_Save.UseVisualStyleBackColor = true;
            this.button_Save.Click += new System.EventHandler(this.button_Save_Click);
            // 
            // comboBox_Heizung
            // 
            this.comboBox_Heizung.FormattingEnabled = true;
            this.comboBox_Heizung.Location = new System.Drawing.Point(193, 303);
            this.comboBox_Heizung.Name = "comboBox_Heizung";
            this.comboBox_Heizung.Size = new System.Drawing.Size(151, 28);
            this.comboBox_Heizung.TabIndex = 25;
            this.comboBox_Heizung.SelectedIndexChanged += new System.EventHandler(this.comboBox_Heizung_SelectedIndexChanged);
            // 
            // label_HeizungTyp
            // 
            this.label_HeizungTyp.AutoSize = true;
            this.label_HeizungTyp.Location = new System.Drawing.Point(45, 303);
            this.label_HeizungTyp.Name = "label_HeizungTyp";
            this.label_HeizungTyp.Size = new System.Drawing.Size(85, 20);
            this.label_HeizungTyp.TabIndex = 26;
            this.label_HeizungTyp.Text = "Heizungtyp";
            // 
            // listView_Immobilie
            // 
            this.listView_Immobilie.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Baujahr,
            this.Gründstücksgrüße,
            this.Wohnfläsche,
            this.Kellerfläsche,
            this.Heizungtyp,
            this.Address});
            this.listView_Immobilie.FullRowSelect = true;
            this.listView_Immobilie.GridLines = true;
            this.listView_Immobilie.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView_Immobilie.Location = new System.Drawing.Point(469, 262);
            this.listView_Immobilie.MultiSelect = false;
            this.listView_Immobilie.Name = "listView_Immobilie";
            this.listView_Immobilie.Size = new System.Drawing.Size(548, 256);
            this.listView_Immobilie.TabIndex = 27;
            this.listView_Immobilie.UseCompatibleStateImageBehavior = false;
            this.listView_Immobilie.View = System.Windows.Forms.View.Details;
            this.listView_Immobilie.SelectedIndexChanged += new System.EventHandler(this.listView_Immobilie_SelectedIndexChanged);
            this.listView_Immobilie.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // Baujahr
            // 
            this.Baujahr.Text = "Const. Year";
            this.Baujahr.Width = 40;
            // 
            // Gründstücksgrüße
            // 
            this.Gründstücksgrüße.Text = "Plot Size";
            this.Gründstücksgrüße.Width = 40;
            // 
            // Wohnfläsche
            // 
            this.Wohnfläsche.Text = "LivingSpace";
            this.Wohnfläsche.Width = 40;
            // 
            // Kellerfläsche
            // 
            this.Kellerfläsche.Text = "Keller Space";
            this.Kellerfläsche.Width = 40;
            // 
            // Heizungtyp
            // 
            this.Heizungtyp.Text = "Heating Type";
            this.Heizungtyp.Width = 90;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 230;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 526);
            this.Controls.Add(this.listView_Immobilie);
            this.Controls.Add(this.label_HeizungTyp);
            this.Controls.Add(this.comboBox_Heizung);
            this.Controls.Add(this.button_Save);
            this.Controls.Add(this.button_Read);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_Address);
            this.Controls.Add(this.textBox_Stadt);
            this.Controls.Add(this.textBox_PLZ);
            this.Controls.Add(this.textBox_HausNr);
            this.Controls.Add(this.textBox_StraßeName);
            this.Controls.Add(this.label_Stadt);
            this.Controls.Add(this.label_PLZ);
            this.Controls.Add(this.label_Hausnr);
            this.Controls.Add(this.labelStraße);
            this.Controls.Add(this.textBox_Kellerfläschesize);
            this.Controls.Add(this.textBox_WohnfläscheSize);
            this.Controls.Add(this.textBox_GründstückSize);
            this.Controls.Add(this.textBox_baujahr);
            this.Controls.Add(this.label_Kellerfläche);
            this.Controls.Add(this.label_Wohnfläche);
            this.Controls.Add(this.label_Grundstücksgröße);
            this.Controls.Add(this.label_BauJahr);
            this.Controls.Add(this.label_Immobilie);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label_Immobilie;
        private Label label_BauJahr;
        private Label label_Grundstücksgröße;
        private Label label_Wohnfläche;
        private Label label_Kellerfläche;
        private TextBox textBox_baujahr;
        private TextBox textBox_GründstückSize;
        private TextBox textBox_WohnfläscheSize;
        private TextBox textBox_Kellerfläschesize;
        private Label labelStraße;
        private Label label_Hausnr;
        private Label label_PLZ;
        private Label label_Stadt;
        private TextBox textBox_StraßeName;
        private TextBox textBox_HausNr;
        private TextBox textBox_PLZ;
        private TextBox textBox_Stadt;
        private Label label_Address;
        private Button button_Add;
        private Button button_Edit;
        private Button button_Delete;
        private Button button_Read;
        private Button button_Save;
        private ComboBox comboBox_Heizung;
        private Label label_HeizungTyp;
        private ColumnHeader Baujahr;
        private ColumnHeader Gründstücksgrüße;
        private ColumnHeader Heizungtyp;
        private ColumnHeader Address;
        private ColumnHeader Kellerfläsche;
        private ColumnHeader Wohnfläsche;
        public ListView listView_Immobilie;
    }
}