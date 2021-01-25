namespace GestioneTreni
{
    partial class Settings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Scannowforupdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Scanupdateboot_chkbox = new System.Windows.Forms.CheckBox();
            this.Scanupdatehour_chkbox = new System.Windows.Forms.CheckBox();
            this.Hourtoscan_txtb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Changelog_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Hourtochange_txtb = new System.Windows.Forms.TextBox();
            this.Changethemeathour_chkbox = new System.Windows.Forms.CheckBox();
            this.Info_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Scannowforupdate
            // 
            this.Scannowforupdate.BackColor = System.Drawing.Color.White;
            this.Scannowforupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Scannowforupdate.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scannowforupdate.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Scannowforupdate.Location = new System.Drawing.Point(267, 33);
            this.Scannowforupdate.Name = "Scannowforupdate";
            this.Scannowforupdate.Size = new System.Drawing.Size(159, 28);
            this.Scannowforupdate.TabIndex = 26;
            this.Scannowforupdate.Text = "Verifica aggiornamenti";
            this.Scannowforupdate.UseVisualStyleBackColor = false;
            this.Scannowforupdate.Click += new System.EventHandler(this.Scannowforupdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label5.Location = new System.Drawing.Point(7, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Aggiornamenti";
            // 
            // Scanupdateboot_chkbox
            // 
            this.Scanupdateboot_chkbox.AutoSize = true;
            this.Scanupdateboot_chkbox.Checked = true;
            this.Scanupdateboot_chkbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.Scanupdateboot_chkbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanupdateboot_chkbox.Location = new System.Drawing.Point(15, 39);
            this.Scanupdateboot_chkbox.Name = "Scanupdateboot_chkbox";
            this.Scanupdateboot_chkbox.Size = new System.Drawing.Size(142, 22);
            this.Scanupdateboot_chkbox.TabIndex = 27;
            this.Scanupdateboot_chkbox.Text = "Scansiona all\'avvio";
            this.Scanupdateboot_chkbox.UseVisualStyleBackColor = true;
            this.Scanupdateboot_chkbox.CheckedChanged += new System.EventHandler(this.Scanupdateboot_chkbox_CheckedChanged);
            // 
            // Scanupdatehour_chkbox
            // 
            this.Scanupdatehour_chkbox.AutoSize = true;
            this.Scanupdatehour_chkbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Scanupdatehour_chkbox.Location = new System.Drawing.Point(15, 66);
            this.Scanupdatehour_chkbox.Name = "Scanupdatehour_chkbox";
            this.Scanupdatehour_chkbox.Size = new System.Drawing.Size(129, 22);
            this.Scanupdatehour_chkbox.TabIndex = 28;
            this.Scanupdatehour_chkbox.Text = "Scansiona all\'ora";
            this.Scanupdatehour_chkbox.UseVisualStyleBackColor = true;
            this.Scanupdatehour_chkbox.CheckedChanged += new System.EventHandler(this.Scanupdatehour_chkbox_CheckedChanged);
            // 
            // Hourtoscan_txtb
            // 
            this.Hourtoscan_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hourtoscan_txtb.Enabled = false;
            this.Hourtoscan_txtb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hourtoscan_txtb.Location = new System.Drawing.Point(152, 67);
            this.Hourtoscan_txtb.MaxLength = 5;
            this.Hourtoscan_txtb.Name = "Hourtoscan_txtb";
            this.Hourtoscan_txtb.Size = new System.Drawing.Size(76, 23);
            this.Hourtoscan_txtb.TabIndex = 29;
            this.Hourtoscan_txtb.Text = "00:00";
            this.Hourtoscan_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hourtoscan_txtb.TextChanged += new System.EventHandler(this.Hourtoscan_txtb_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label1.Location = new System.Drawing.Point(264, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 17);
            this.label1.TabIndex = 30;
            this.label1.Text = "Versione corrente: ";
            // 
            // Changelog_btn
            // 
            this.Changelog_btn.BackColor = System.Drawing.Color.White;
            this.Changelog_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Changelog_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changelog_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Changelog_btn.Location = new System.Drawing.Point(432, 33);
            this.Changelog_btn.Name = "Changelog_btn";
            this.Changelog_btn.Size = new System.Drawing.Size(89, 28);
            this.Changelog_btn.TabIndex = 31;
            this.Changelog_btn.Text = "Changelog";
            this.Changelog_btn.UseVisualStyleBackColor = false;
            this.Changelog_btn.Click += new System.EventHandler(this.Changelog_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 10.25F);
            this.label2.Location = new System.Drawing.Point(7, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 17);
            this.label2.TabIndex = 32;
            this.label2.Text = "Tema";
            this.label2.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Scuro",
            "Chiaro"});
            this.comboBox1.Location = new System.Drawing.Point(15, 162);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 26);
            this.comboBox1.TabIndex = 33;
            this.comboBox1.Text = "Chiaro";
            this.comboBox1.Visible = false;
            // 
            // Hourtochange_txtb
            // 
            this.Hourtochange_txtb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Hourtochange_txtb.Enabled = false;
            this.Hourtochange_txtb.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hourtochange_txtb.Location = new System.Drawing.Point(350, 165);
            this.Hourtochange_txtb.MaxLength = 4;
            this.Hourtochange_txtb.Name = "Hourtochange_txtb";
            this.Hourtochange_txtb.Size = new System.Drawing.Size(76, 23);
            this.Hourtochange_txtb.TabIndex = 35;
            this.Hourtochange_txtb.Text = "00:00";
            this.Hourtochange_txtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Hourtochange_txtb.Visible = false;
            // 
            // Changethemeathour_chkbox
            // 
            this.Changethemeathour_chkbox.AutoSize = true;
            this.Changethemeathour_chkbox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Changethemeathour_chkbox.Location = new System.Drawing.Point(161, 164);
            this.Changethemeathour_chkbox.Name = "Changethemeathour_chkbox";
            this.Changethemeathour_chkbox.Size = new System.Drawing.Size(186, 22);
            this.Changethemeathour_chkbox.TabIndex = 34;
            this.Changethemeathour_chkbox.Text = "Attiva il tema scuro all\'ora";
            this.Changethemeathour_chkbox.UseVisualStyleBackColor = true;
            this.Changethemeathour_chkbox.Visible = false;
            // 
            // Info_btn
            // 
            this.Info_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Info_btn.BackColor = System.Drawing.Color.White;
            this.Info_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Info_btn.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Info_btn.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Info_btn.Location = new System.Drawing.Point(491, 170);
            this.Info_btn.Name = "Info_btn";
            this.Info_btn.Size = new System.Drawing.Size(29, 28);
            this.Info_btn.TabIndex = 36;
            this.Info_btn.Text = "i";
            this.Info_btn.UseVisualStyleBackColor = false;
            this.Info_btn.Click += new System.EventHandler(this.Info_btn_Click);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(532, 210);
            this.Controls.Add(this.Info_btn);
            this.Controls.Add(this.Hourtochange_txtb);
            this.Controls.Add(this.Changethemeathour_chkbox);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Changelog_btn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Hourtoscan_txtb);
            this.Controls.Add(this.Scanupdatehour_chkbox);
            this.Controls.Add(this.Scanupdateboot_chkbox);
            this.Controls.Add(this.Scannowforupdate);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Settings";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Scannowforupdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox Scanupdateboot_chkbox;
        private System.Windows.Forms.CheckBox Scanupdatehour_chkbox;
        private System.Windows.Forms.TextBox Hourtoscan_txtb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Changelog_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox Hourtochange_txtb;
        private System.Windows.Forms.CheckBox Changethemeathour_chkbox;
        private System.Windows.Forms.Button Info_btn;
    }
}