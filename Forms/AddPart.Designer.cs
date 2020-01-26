namespace ISS
{
    partial class AddPrt
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
            this.label1 = new System.Windows.Forms.Label();
            this.InHseBtn = new System.Windows.Forms.RadioButton();
            this.OutBtn = new System.Windows.Forms.RadioButton();
            this.IdBx = new System.Windows.Forms.TextBox();
            this.NmBx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.InvBx = new System.Windows.Forms.TextBox();
            this.PrBx = new System.Windows.Forms.TextBox();
            this.MxBx = new System.Windows.Forms.TextBox();
            this.MidBx = new System.Windows.Forms.TextBox();
            this.MnBx = new System.Windows.Forms.TextBox();
            this.AddPartSave = new System.Windows.Forms.Button();
            this.AddPartCxl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Part";
            // 
            // InHseBtn
            // 
            this.InHseBtn.AutoSize = true;
            this.InHseBtn.Checked = true;
            this.InHseBtn.Location = new System.Drawing.Point(172, 12);
            this.InHseBtn.Name = "InHseBtn";
            this.InHseBtn.Size = new System.Drawing.Size(129, 29);
            this.InHseBtn.TabIndex = 1;
            this.InHseBtn.TabStop = true;
            this.InHseBtn.Text = "In-House";
            this.InHseBtn.UseVisualStyleBackColor = true;
            this.InHseBtn.CheckedChanged += new System.EventHandler(this.InHseBtn_CheckedChanged);
            // 
            // OutBtn
            // 
            this.OutBtn.AutoSize = true;
            this.OutBtn.Location = new System.Drawing.Point(345, 12);
            this.OutBtn.Name = "OutBtn";
            this.OutBtn.Size = new System.Drawing.Size(154, 29);
            this.OutBtn.TabIndex = 2;
            this.OutBtn.Text = "Outsourced";
            this.OutBtn.UseVisualStyleBackColor = true;
            this.OutBtn.CheckedChanged += new System.EventHandler(this.OutBtn_CheckedChanged);
            // 
            // IdBx
            // 
            this.IdBx.Location = new System.Drawing.Point(191, 92);
            this.IdBx.Name = "IdBx";
            this.IdBx.Size = new System.Drawing.Size(100, 31);
            this.IdBx.TabIndex = 3;
            this.IdBx.TextChanged += new System.EventHandler(this.IdBx_TextChanged);
            // 
            // NmBx
            // 
            this.NmBx.Location = new System.Drawing.Point(191, 161);
            this.NmBx.Name = "NmBx";
            this.NmBx.Size = new System.Drawing.Size(100, 31);
            this.NmBx.TabIndex = 4;
            this.NmBx.TextChanged += new System.EventHandler(this.NmBx_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(100, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 233);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 300);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Price / Cost";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(79, 360);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 428);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 25);
            this.label7.TabIndex = 10;
            this.label7.Text = "Machine ID";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(331, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 11;
            this.label8.Text = "Min";
            // 
            // InvBx
            // 
            this.InvBx.Location = new System.Drawing.Point(191, 227);
            this.InvBx.Name = "InvBx";
            this.InvBx.Size = new System.Drawing.Size(100, 31);
            this.InvBx.TabIndex = 12;
            this.InvBx.TextChanged += new System.EventHandler(this.InvBx_TextChanged);
            // 
            // PrBx
            // 
            this.PrBx.Location = new System.Drawing.Point(191, 294);
            this.PrBx.Name = "PrBx";
            this.PrBx.Size = new System.Drawing.Size(100, 31);
            this.PrBx.TabIndex = 13;
            this.PrBx.TextChanged += new System.EventHandler(this.PrBx_TextChanged);
            // 
            // MxBx
            // 
            this.MxBx.Location = new System.Drawing.Point(191, 362);
            this.MxBx.Name = "MxBx";
            this.MxBx.Size = new System.Drawing.Size(100, 31);
            this.MxBx.TabIndex = 14;
            this.MxBx.TextChanged += new System.EventHandler(this.MxBx_TextChanged);
            // 
            // MidBx
            // 
            this.MidBx.Location = new System.Drawing.Point(191, 425);
            this.MidBx.Name = "MidBx";
            this.MidBx.Size = new System.Drawing.Size(100, 31);
            this.MidBx.TabIndex = 15;
            this.MidBx.TextChanged += new System.EventHandler(this.MidBx_TextChanged);
            // 
            // MnBx
            // 
            this.MnBx.Location = new System.Drawing.Point(397, 362);
            this.MnBx.Name = "MnBx";
            this.MnBx.Size = new System.Drawing.Size(100, 31);
            this.MnBx.TabIndex = 16;
            this.MnBx.TextChanged += new System.EventHandler(this.MnBx_TextChanged);
            // 
            // AddPartSave
            // 
            this.AddPartSave.BackColor = System.Drawing.Color.Silver;
            this.AddPartSave.Location = new System.Drawing.Point(272, 484);
            this.AddPartSave.Name = "AddPartSave";
            this.AddPartSave.Size = new System.Drawing.Size(106, 51);
            this.AddPartSave.TabIndex = 17;
            this.AddPartSave.Text = "Save";
            this.AddPartSave.UseVisualStyleBackColor = false;
            this.AddPartSave.Click += new System.EventHandler(this.AddPartSave_Click_1);
            // 
            // AddPartCxl
            // 
            this.AddPartCxl.BackColor = System.Drawing.Color.Silver;
            this.AddPartCxl.Location = new System.Drawing.Point(397, 484);
            this.AddPartCxl.Name = "AddPartCxl";
            this.AddPartCxl.Size = new System.Drawing.Size(125, 51);
            this.AddPartCxl.TabIndex = 18;
            this.AddPartCxl.Text = "Cancel";
            this.AddPartCxl.UseVisualStyleBackColor = false;
            this.AddPartCxl.Click += new System.EventHandler(this.AddPartCxl_Click_1);
            // 
            // AddPrt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(537, 599);
            this.Controls.Add(this.AddPartCxl);
            this.Controls.Add(this.AddPartSave);
            this.Controls.Add(this.MnBx);
            this.Controls.Add(this.MidBx);
            this.Controls.Add(this.MxBx);
            this.Controls.Add(this.PrBx);
            this.Controls.Add(this.InvBx);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NmBx);
            this.Controls.Add(this.IdBx);
            this.Controls.Add(this.OutBtn);
            this.Controls.Add(this.InHseBtn);
            this.Controls.Add(this.label1);
            this.Name = "AddPrt";
            this.Text = "Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton InHseBtn;
        private System.Windows.Forms.RadioButton OutBtn;
        private System.Windows.Forms.TextBox IdBx;
        private System.Windows.Forms.TextBox NmBx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox InvBx;
        private System.Windows.Forms.TextBox PrBx;
        private System.Windows.Forms.TextBox MxBx;
        private System.Windows.Forms.TextBox MidBx;
        private System.Windows.Forms.TextBox MnBx;
        private System.Windows.Forms.Button AddPartSave;
        private System.Windows.Forms.Button AddPartCxl;
    }
}