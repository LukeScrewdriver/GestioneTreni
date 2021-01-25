namespace GestioneTreni
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Connect_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.NamePort_txtbox = new System.Windows.Forms.TextBox();
            this.StatusConnection_lab = new System.Windows.Forms.Label();
            this.software_info = new System.Windows.Forms.Button();
            this.Change_btn = new System.Windows.Forms.Button();
            this.Make_btn = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Position_txtb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.name_txtb = new System.Windows.Forms.TextBox();
            this.ListItems = new System.Windows.Forms.ListView();
            this.NameComponents = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Quantity = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Remove_btn = new System.Windows.Forms.Button();
            this.Add_btn = new System.Windows.Forms.Button();
            this.Move_btn = new System.Windows.Forms.Button();
            this.PosizioneCrursore_lab = new System.Windows.Forms.TextBox();
            this.Antiorario_btn = new System.Windows.Forms.Button();
            this.Orario_btn = new System.Windows.Forms.Button();
            this.mlssXsec_txtb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Occupata_chkbox = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.CorrectionMove_txtbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Connect_btn
            // 
            this.Connect_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Connect_btn.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Connect_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Connect_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.Connect_btn.ForeColor = System.Drawing.Color.White;
            this.Connect_btn.Location = new System.Drawing.Point(464, 42);
            this.Connect_btn.Name = "Connect_btn";
            this.Connect_btn.Size = new System.Drawing.Size(188, 30);
            this.Connect_btn.TabIndex = 0;
            this.Connect_btn.Text = "Connetti";
            this.Connect_btn.UseVisualStyleBackColor = false;
            this.Connect_btn.Click += new System.EventHandler(this.Connect_btn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(461, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "PORTA:";
            // 
            // NamePort_txtbox
            // 
            this.NamePort_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NamePort_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NamePort_txtbox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NamePort_txtbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NamePort_txtbox.Location = new System.Drawing.Point(514, 10);
            this.NamePort_txtbox.Name = "NamePort_txtbox";
            this.NamePort_txtbox.Size = new System.Drawing.Size(138, 26);
            this.NamePort_txtbox.TabIndex = 1;
            this.NamePort_txtbox.Text = "COM4";
            this.NamePort_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StatusConnection_lab
            // 
            this.StatusConnection_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StatusConnection_lab.AutoSize = true;
            this.StatusConnection_lab.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusConnection_lab.Location = new System.Drawing.Point(499, 75);
            this.StatusConnection_lab.Name = "StatusConnection_lab";
            this.StatusConnection_lab.Size = new System.Drawing.Size(124, 18);
            this.StatusConnection_lab.TabIndex = 3;
            this.StatusConnection_lab.Text = "Stato: Disconnesso";
            // 
            // software_info
            // 
            this.software_info.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.software_info.BackColor = System.Drawing.SystemColors.HotTrack;
            this.software_info.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.software_info.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.software_info.ForeColor = System.Drawing.Color.White;
            this.software_info.Location = new System.Drawing.Point(570, 426);
            this.software_info.Name = "software_info";
            this.software_info.Size = new System.Drawing.Size(82, 32);
            this.software_info.TabIndex = 25;
            this.software_info.Text = "Settings";
            this.software_info.UseVisualStyleBackColor = false;
            this.software_info.Click += new System.EventHandler(this.software_info_Click);
            // 
            // Change_btn
            // 
            this.Change_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Change_btn.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Change_btn.Enabled = false;
            this.Change_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Change_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_btn.ForeColor = System.Drawing.Color.White;
            this.Change_btn.Location = new System.Drawing.Point(461, 426);
            this.Change_btn.Name = "Change_btn";
            this.Change_btn.Size = new System.Drawing.Size(82, 32);
            this.Change_btn.TabIndex = 24;
            this.Change_btn.Text = "Modifica";
            this.Change_btn.UseVisualStyleBackColor = false;
            this.Change_btn.Click += new System.EventHandler(this.Change_btn_Click);
            // 
            // Make_btn
            // 
            this.Make_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Make_btn.BackColor = System.Drawing.Color.SandyBrown;
            this.Make_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Make_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Make_btn.ForeColor = System.Drawing.Color.White;
            this.Make_btn.Location = new System.Drawing.Point(461, 241);
            this.Make_btn.Name = "Make_btn";
            this.Make_btn.Size = new System.Drawing.Size(191, 42);
            this.Make_btn.TabIndex = 23;
            this.Make_btn.Text = "Crea";
            this.Make_btn.UseVisualStyleBackColor = false;
            this.Make_btn.Visible = false;
            this.Make_btn.Click += new System.EventHandler(this.Make_btn_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label5.Location = new System.Drawing.Point(458, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 22;
            this.label5.Text = "Posizione (in step):";
            this.label5.Visible = false;
            // 
            // Position_txtb
            // 
            this.Position_txtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Position_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Position_txtb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Position_txtb.Location = new System.Drawing.Point(576, 126);
            this.Position_txtb.MaxLength = 4;
            this.Position_txtb.Name = "Position_txtb";
            this.Position_txtb.Size = new System.Drawing.Size(76, 23);
            this.Position_txtb.TabIndex = 21;
            this.Position_txtb.Text = "0";
            this.Position_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Position_txtb.Visible = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label6.Location = new System.Drawing.Point(458, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 17);
            this.label6.TabIndex = 20;
            this.label6.Text = "Nome binario:";
            this.label6.Visible = false;
            // 
            // name_txtb
            // 
            this.name_txtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.name_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_txtb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_txtb.Location = new System.Drawing.Point(549, 99);
            this.name_txtb.Name = "name_txtb";
            this.name_txtb.Size = new System.Drawing.Size(103, 23);
            this.name_txtb.TabIndex = 19;
            this.name_txtb.Text = "Binario1";
            this.name_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.name_txtb.Visible = false;
            // 
            // ListItems
            // 
            this.ListItems.AllowColumnReorder = true;
            this.ListItems.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListItems.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameComponents,
            this.Quantity,
            this.columnHeader1});
            this.ListItems.FullRowSelect = true;
            this.ListItems.HideSelection = false;
            this.ListItems.Location = new System.Drawing.Point(16, 10);
            this.ListItems.Name = "ListItems";
            this.ListItems.Size = new System.Drawing.Size(436, 529);
            this.ListItems.TabIndex = 18;
            this.ListItems.UseCompatibleStateImageBehavior = false;
            this.ListItems.View = System.Windows.Forms.View.Details;
            this.ListItems.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListItems_MouseClick);
            // 
            // NameComponents
            // 
            this.NameComponents.Text = "Nome binario";
            this.NameComponents.Width = 180;
            // 
            // Quantity
            // 
            this.Quantity.Text = "Posizione";
            this.Quantity.Width = 73;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Occupata";
            // 
            // Remove_btn
            // 
            this.Remove_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Remove_btn.BackColor = System.Drawing.Color.Red;
            this.Remove_btn.Enabled = false;
            this.Remove_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Remove_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Remove_btn.ForeColor = System.Drawing.Color.White;
            this.Remove_btn.Location = new System.Drawing.Point(570, 388);
            this.Remove_btn.Name = "Remove_btn";
            this.Remove_btn.Size = new System.Drawing.Size(82, 32);
            this.Remove_btn.TabIndex = 17;
            this.Remove_btn.Text = "Rimuovi";
            this.Remove_btn.UseVisualStyleBackColor = false;
            this.Remove_btn.Click += new System.EventHandler(this.button2_Click);
            // 
            // Add_btn
            // 
            this.Add_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Add_btn.BackColor = System.Drawing.Color.GreenYellow;
            this.Add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Add_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_btn.ForeColor = System.Drawing.Color.White;
            this.Add_btn.Location = new System.Drawing.Point(461, 388);
            this.Add_btn.Name = "Add_btn";
            this.Add_btn.Size = new System.Drawing.Size(82, 32);
            this.Add_btn.TabIndex = 16;
            this.Add_btn.Text = "Aggiungi";
            this.Add_btn.UseVisualStyleBackColor = false;
            this.Add_btn.Click += new System.EventHandler(this.button3_Click);
            // 
            // Move_btn
            // 
            this.Move_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Move_btn.BackColor = System.Drawing.Color.Gold;
            this.Move_btn.Enabled = false;
            this.Move_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Move_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Move_btn.ForeColor = System.Drawing.Color.White;
            this.Move_btn.Location = new System.Drawing.Point(461, 497);
            this.Move_btn.Name = "Move_btn";
            this.Move_btn.Size = new System.Drawing.Size(191, 42);
            this.Move_btn.TabIndex = 26;
            this.Move_btn.Text = "Muovi";
            this.Move_btn.UseVisualStyleBackColor = false;
            this.Move_btn.Click += new System.EventHandler(this.Move_btn_Click);
            // 
            // PosizioneCrursore_lab
            // 
            this.PosizioneCrursore_lab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PosizioneCrursore_lab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PosizioneCrursore_lab.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PosizioneCrursore_lab.Location = new System.Drawing.Point(510, 464);
            this.PosizioneCrursore_lab.Name = "PosizioneCrursore_lab";
            this.PosizioneCrursore_lab.Size = new System.Drawing.Size(93, 23);
            this.PosizioneCrursore_lab.TabIndex = 28;
            this.PosizioneCrursore_lab.Text = "0";
            this.PosizioneCrursore_lab.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PosizioneCrursore_lab.TextChanged += new System.EventHandler(this.PosizioneCrursore_lab_TextChanged);
            // 
            // Antiorario_btn
            // 
            this.Antiorario_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Antiorario_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Antiorario_btn.Enabled = false;
            this.Antiorario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Antiorario_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.Antiorario_btn.ForeColor = System.Drawing.Color.White;
            this.Antiorario_btn.Location = new System.Drawing.Point(461, 461);
            this.Antiorario_btn.Name = "Antiorario_btn";
            this.Antiorario_btn.Size = new System.Drawing.Size(44, 30);
            this.Antiorario_btn.TabIndex = 29;
            this.Antiorario_btn.Text = "Ant";
            this.Antiorario_btn.UseVisualStyleBackColor = false;
            this.Antiorario_btn.Click += new System.EventHandler(this.Antiorario_btn_Click);
            // 
            // Orario_btn
            // 
            this.Orario_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Orario_btn.BackColor = System.Drawing.Color.CadetBlue;
            this.Orario_btn.Enabled = false;
            this.Orario_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Orario_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold);
            this.Orario_btn.ForeColor = System.Drawing.Color.White;
            this.Orario_btn.Location = new System.Drawing.Point(608, 461);
            this.Orario_btn.Name = "Orario_btn";
            this.Orario_btn.Size = new System.Drawing.Size(44, 30);
            this.Orario_btn.TabIndex = 30;
            this.Orario_btn.Text = "Ora";
            this.Orario_btn.UseVisualStyleBackColor = false;
            this.Orario_btn.Click += new System.EventHandler(this.Orario_btn_Click);
            // 
            // mlssXsec_txtb
            // 
            this.mlssXsec_txtb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.mlssXsec_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mlssXsec_txtb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mlssXsec_txtb.Location = new System.Drawing.Point(576, 356);
            this.mlssXsec_txtb.MaxLength = 4;
            this.mlssXsec_txtb.Name = "mlssXsec_txtb";
            this.mlssXsec_txtb.Size = new System.Drawing.Size(76, 23);
            this.mlssXsec_txtb.TabIndex = 31;
            this.mlssXsec_txtb.Text = "1000";
            this.mlssXsec_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(463, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Millisec. per step:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Occupata_chkbox
            // 
            this.Occupata_chkbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Occupata_chkbox.AutoSize = true;
            this.Occupata_chkbox.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.Occupata_chkbox.Location = new System.Drawing.Point(464, 152);
            this.Occupata_chkbox.Name = "Occupata_chkbox";
            this.Occupata_chkbox.Size = new System.Drawing.Size(81, 21);
            this.Occupata_chkbox.TabIndex = 33;
            this.Occupata_chkbox.Text = "Occupata";
            this.Occupata_chkbox.UseVisualStyleBackColor = true;
            this.Occupata_chkbox.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.checkBox1.Location = new System.Drawing.Point(464, 194);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(109, 21);
            this.checkBox1.TabIndex = 34;
            this.checkBox1.Text = "Cancella nome";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox2.AutoSize = true;
            this.checkBox2.Checked = true;
            this.checkBox2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.checkBox2.Location = new System.Drawing.Point(464, 214);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(129, 21);
            this.checkBox2.TabIndex = 35;
            this.checkBox2.Text = "Cancella posizione";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label3.Location = new System.Drawing.Point(463, 329);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 17);
            this.label3.TabIndex = 37;
            this.label3.Text = "Correz. spostamento:";
            // 
            // CorrectionMove_txtbox
            // 
            this.CorrectionMove_txtbox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CorrectionMove_txtbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.CorrectionMove_txtbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CorrectionMove_txtbox.Location = new System.Drawing.Point(598, 326);
            this.CorrectionMove_txtbox.MaxLength = 4;
            this.CorrectionMove_txtbox.Name = "CorrectionMove_txtbox";
            this.CorrectionMove_txtbox.Size = new System.Drawing.Size(54, 23);
            this.CorrectionMove_txtbox.TabIndex = 36;
            this.CorrectionMove_txtbox.Text = "0";
            this.CorrectionMove_txtbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.CorrectionMove_txtbox.TextChanged += new System.EventHandler(this.CorrectionMove_txtbox_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(664, 551);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.CorrectionMove_txtbox);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.Occupata_chkbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.mlssXsec_txtb);
            this.Controls.Add(this.Orario_btn);
            this.Controls.Add(this.Antiorario_btn);
            this.Controls.Add(this.PosizioneCrursore_lab);
            this.Controls.Add(this.Move_btn);
            this.Controls.Add(this.software_info);
            this.Controls.Add(this.Change_btn);
            this.Controls.Add(this.Make_btn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Position_txtb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.name_txtb);
            this.Controls.Add(this.ListItems);
            this.Controls.Add(this.Remove_btn);
            this.Controls.Add(this.Add_btn);
            this.Controls.Add(this.StatusConnection_lab);
            this.Controls.Add(this.NamePort_txtbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Connect_btn);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestione piattaforma";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Connect_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox NamePort_txtbox;
        private System.Windows.Forms.Label StatusConnection_lab;
        private System.Windows.Forms.Button software_info;
        private System.Windows.Forms.Button Change_btn;
        private System.Windows.Forms.Button Make_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Position_txtb;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox name_txtb;
        private System.Windows.Forms.ListView ListItems;
        private System.Windows.Forms.ColumnHeader NameComponents;
        private System.Windows.Forms.ColumnHeader Quantity;
        private System.Windows.Forms.Button Remove_btn;
        private System.Windows.Forms.Button Add_btn;
        private System.Windows.Forms.Button Move_btn;
        private System.Windows.Forms.TextBox PosizioneCrursore_lab;
        private System.Windows.Forms.Button Antiorario_btn;
        private System.Windows.Forms.Button Orario_btn;
        private System.Windows.Forms.TextBox mlssXsec_txtb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.CheckBox Occupata_chkbox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox CorrectionMove_txtbox;
    }
}

