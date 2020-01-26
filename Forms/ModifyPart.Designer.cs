namespace ISS
{
    partial class MdPrt
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
            this.ModPartCxl = new System.Windows.Forms.Button();
            this.ModPartSave = new System.Windows.Forms.Button();
            this.ModPartMinBox = new System.Windows.Forms.TextBox();
            this.MdPrtMac = new System.Windows.Forms.TextBox();
            this.ModPartMaxBox = new System.Windows.Forms.TextBox();
            this.ModPartPriceBox = new System.Windows.Forms.TextBox();
            this.ModPartInvBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ModPartIDLabel = new System.Windows.Forms.Label();
            this.ModPartName = new System.Windows.Forms.TextBox();
            this.ModPartIDBox = new System.Windows.Forms.TextBox();
            this.ModPartOutRad = new System.Windows.Forms.RadioButton();
            this.ModPartInRadio = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ModPartCxl
            // 
            this.ModPartCxl.BackColor = System.Drawing.Color.Silver;
            this.ModPartCxl.Location = new System.Drawing.Point(404, 523);
            this.ModPartCxl.Name = "ModPartCxl";
            this.ModPartCxl.Size = new System.Drawing.Size(103, 43);
            this.ModPartCxl.TabIndex = 37;
            this.ModPartCxl.Text = "Cancel";
            this.ModPartCxl.UseVisualStyleBackColor = false;
            this.ModPartCxl.Click += new System.EventHandler(this.ModPartCxl_Click_1);
            // 
            // ModPartSave
            // 
            this.ModPartSave.BackColor = System.Drawing.Color.Silver;
            this.ModPartSave.Location = new System.Drawing.Point(284, 523);
            this.ModPartSave.Name = "ModPartSave";
            this.ModPartSave.Size = new System.Drawing.Size(96, 43);
            this.ModPartSave.TabIndex = 36;
            this.ModPartSave.Text = "Save";
            this.ModPartSave.UseVisualStyleBackColor = false;
            this.ModPartSave.Click += new System.EventHandler(this.ModPartSave_Click_1);
            // 
            // ModPartMinBox
            // 
            this.ModPartMinBox.Location = new System.Drawing.Point(368, 404);
            this.ModPartMinBox.Name = "ModPartMinBox";
            this.ModPartMinBox.Size = new System.Drawing.Size(100, 31);
            this.ModPartMinBox.TabIndex = 35;
            this.ModPartMinBox.TextChanged += new System.EventHandler(this.ModPartMinBox_TextChanged);
            // 
            // MdPrtMac
            // 
            this.MdPrtMac.Location = new System.Drawing.Point(176, 477);
            this.MdPrtMac.Name = "MdPrtMac";
            this.MdPrtMac.Size = new System.Drawing.Size(100, 31);
            this.MdPrtMac.TabIndex = 34;
            this.MdPrtMac.TextChanged += new System.EventHandler(this.MdPrtMac_TextChanged);
            // 
            // ModPartMaxBox
            // 
            this.ModPartMaxBox.Location = new System.Drawing.Point(176, 404);
            this.ModPartMaxBox.Name = "ModPartMaxBox";
            this.ModPartMaxBox.Size = new System.Drawing.Size(100, 31);
            this.ModPartMaxBox.TabIndex = 33;
            this.ModPartMaxBox.TextChanged += new System.EventHandler(this.ModPartMaxBox_TextChanged);
            // 
            // ModPartPriceBox
            // 
            this.ModPartPriceBox.Location = new System.Drawing.Point(176, 332);
            this.ModPartPriceBox.Name = "ModPartPriceBox";
            this.ModPartPriceBox.Size = new System.Drawing.Size(100, 31);
            this.ModPartPriceBox.TabIndex = 32;
            this.ModPartPriceBox.TextChanged += new System.EventHandler(this.ModPartPriceBox_TextChanged);
            // 
            // ModPartInvBox
            // 
            this.ModPartInvBox.Location = new System.Drawing.Point(176, 256);
            this.ModPartInvBox.Name = "ModPartInvBox";
            this.ModPartInvBox.Size = new System.Drawing.Size(100, 31);
            this.ModPartInvBox.TabIndex = 31;
            this.ModPartInvBox.TextChanged += new System.EventHandler(this.ModPartInvBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 407);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 30;
            this.label8.Text = "Min";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 480);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 29;
            this.label7.Text = "Machine ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(77, 406);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 28;
            this.label6.Text = "Max";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 27;
            this.label5.Text = "Price / Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "Inventory";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Name";
            // 
            // ModPartIDLabel
            // 
            this.ModPartIDLabel.AutoSize = true;
            this.ModPartIDLabel.Location = new System.Drawing.Point(93, 111);
            this.ModPartIDLabel.Name = "ModPartIDLabel";
            this.ModPartIDLabel.Size = new System.Drawing.Size(32, 25);
            this.ModPartIDLabel.TabIndex = 24;
            this.ModPartIDLabel.Text = "ID";
            // 
            // ModPartName
            // 
            this.ModPartName.Location = new System.Drawing.Point(176, 177);
            this.ModPartName.Name = "ModPartName";
            this.ModPartName.Size = new System.Drawing.Size(100, 31);
            this.ModPartName.TabIndex = 23;
            this.ModPartName.TextChanged += new System.EventHandler(this.ModPartName_TextChanged);
            // 
            // ModPartIDBox
            // 
            this.ModPartIDBox.Location = new System.Drawing.Point(176, 105);
            this.ModPartIDBox.Name = "ModPartIDBox";
            this.ModPartIDBox.Size = new System.Drawing.Size(100, 31);
            this.ModPartIDBox.TabIndex = 22;
            this.ModPartIDBox.TextChanged += new System.EventHandler(this.ModPartIDBox_TextChanged);
            // 
            // ModPartOutRad
            // 
            this.ModPartOutRad.AutoSize = true;
            this.ModPartOutRad.Location = new System.Drawing.Point(353, 21);
            this.ModPartOutRad.Name = "ModPartOutRad";
            this.ModPartOutRad.Size = new System.Drawing.Size(154, 29);
            this.ModPartOutRad.TabIndex = 21;
            this.ModPartOutRad.Text = "Outsourced";
            this.ModPartOutRad.UseVisualStyleBackColor = true;
            this.ModPartOutRad.CheckedChanged += new System.EventHandler(this.ModPartOutRad_CheckedChanged);
            // 
            // ModPartInRadio
            // 
            this.ModPartInRadio.AutoSize = true;
            this.ModPartInRadio.Checked = true;
            this.ModPartInRadio.Location = new System.Drawing.Point(200, 21);
            this.ModPartInRadio.Name = "ModPartInRadio";
            this.ModPartInRadio.Size = new System.Drawing.Size(129, 29);
            this.ModPartInRadio.TabIndex = 20;
            this.ModPartInRadio.TabStop = true;
            this.ModPartInRadio.Text = "In-House";
            this.ModPartInRadio.UseVisualStyleBackColor = true;
            this.ModPartInRadio.CheckedChanged += new System.EventHandler(this.ModPartInRadio_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 37);
            this.label1.TabIndex = 19;
            this.label1.Text = "Modify Part";
            // 
            // MdPrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(537, 599);
            this.Controls.Add(this.ModPartCxl);
            this.Controls.Add(this.ModPartSave);
            this.Controls.Add(this.ModPartMinBox);
            this.Controls.Add(this.MdPrtMac);
            this.Controls.Add(this.ModPartMaxBox);
            this.Controls.Add(this.ModPartPriceBox);
            this.Controls.Add(this.ModPartInvBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModPartIDLabel);
            this.Controls.Add(this.ModPartName);
            this.Controls.Add(this.ModPartIDBox);
            this.Controls.Add(this.ModPartOutRad);
            this.Controls.Add(this.ModPartInRadio);
            this.Controls.Add(this.label1);
            this.Name = "MdPrt";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ModPartCxl;
        private System.Windows.Forms.Button ModPartSave;
        private System.Windows.Forms.TextBox ModPartMinBox;
        private System.Windows.Forms.TextBox MdPrtMac;
        private System.Windows.Forms.TextBox ModPartMaxBox;
        private System.Windows.Forms.TextBox ModPartPriceBox;
        private System.Windows.Forms.TextBox ModPartInvBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label ModPartIDLabel;
        private System.Windows.Forms.TextBox ModPartName;
        private System.Windows.Forms.TextBox ModPartIDBox;
        private System.Windows.Forms.RadioButton ModPartOutRad;
        private System.Windows.Forms.RadioButton ModPartInRadio;
        private System.Windows.Forms.Label label1;
    }
}