namespace ISS
{
    partial class AddPro
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.AdProSearhBtn = new System.Windows.Forms.Button();
            this.AddProSearchbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddProCanPartGrid = new System.Windows.Forms.DataGridView();
            this.AddProBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.AssocPartGrid = new System.Windows.Forms.DataGridView();
            this.DelProBtn = new System.Windows.Forms.Button();
            this.AdProCxlBtn = new System.Windows.Forms.Button();
            this.AddProSvBtn = new System.Windows.Forms.Button();
            this.AddProTxtBx = new System.Windows.Forms.TextBox();
            this.AdProNmBx = new System.Windows.Forms.TextBox();
            this.AdProInvBx = new System.Windows.Forms.TextBox();
            this.AdProPrcBx = new System.Windows.Forms.TextBox();
            this.AdProMxBx = new System.Windows.Forms.TextBox();
            this.AdProMnBx = new System.Windows.Forms.TextBox();
            this.process1 = new System.Diagnostics.Process();
            this.process2 = new System.Diagnostics.Process();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.AddProCanPartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssocPartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(165, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Product";
            // 
            // AdProSearhBtn
            // 
            this.AdProSearhBtn.BackColor = System.Drawing.Color.Silver;
            this.AdProSearhBtn.Location = new System.Drawing.Point(862, 46);
            this.AdProSearhBtn.Name = "AdProSearhBtn";
            this.AdProSearhBtn.Size = new System.Drawing.Size(122, 48);
            this.AdProSearhBtn.TabIndex = 1;
            this.AdProSearhBtn.Text = "ID Search";
            this.AdProSearhBtn.UseVisualStyleBackColor = false;
            this.AdProSearhBtn.Click += new System.EventHandler(this.AdProSearhBtn_Click_1);
            // 
            // AddProSearchbox
            // 
            this.AddProSearchbox.Location = new System.Drawing.Point(1009, 57);
            this.AddProSearchbox.Name = "AddProSearchbox";
            this.AddProSearchbox.Size = new System.Drawing.Size(352, 31);
            this.AddProSearchbox.TabIndex = 2;
            this.AddProSearchbox.TextChanged += new System.EventHandler(this.AddProSearchbox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(547, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "All Candidate Parts";
            // 
            // AddProCanPartGrid
            // 
            this.AddProCanPartGrid.AllowUserToAddRows = false;
            this.AddProCanPartGrid.AllowUserToDeleteRows = false;
            this.AddProCanPartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AddProCanPartGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AddProCanPartGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.AddProCanPartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProCanPartGrid.Location = new System.Drawing.Point(552, 138);
            this.AddProCanPartGrid.Name = "AddProCanPartGrid";
            this.AddProCanPartGrid.RowHeadersVisible = false;
            this.AddProCanPartGrid.RowHeadersWidth = 82;
            this.AddProCanPartGrid.RowTemplate.Height = 33;
            this.AddProCanPartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProCanPartGrid.Size = new System.Drawing.Size(809, 199);
            this.AddProCanPartGrid.TabIndex = 4;
            // 
            // AddProBtn
            // 
            this.AddProBtn.BackColor = System.Drawing.Color.Silver;
            this.AddProBtn.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddProBtn.Location = new System.Drawing.Point(1255, 365);
            this.AddProBtn.Name = "AddProBtn";
            this.AddProBtn.Size = new System.Drawing.Size(106, 49);
            this.AddProBtn.TabIndex = 5;
            this.AddProBtn.Text = "Add";
            this.AddProBtn.UseVisualStyleBackColor = false;
            this.AddProBtn.Click += new System.EventHandler(this.AddProBtn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(547, 441);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // AssocPartGrid
            // 
            this.AssocPartGrid.AllowUserToAddRows = false;
            this.AssocPartGrid.AllowUserToDeleteRows = false;
            this.AssocPartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AssocPartGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AssocPartGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.AssocPartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssocPartGrid.Location = new System.Drawing.Point(552, 490);
            this.AssocPartGrid.Name = "AssocPartGrid";
            this.AssocPartGrid.RowHeadersVisible = false;
            this.AssocPartGrid.RowHeadersWidth = 82;
            this.AssocPartGrid.RowTemplate.Height = 33;
            this.AssocPartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssocPartGrid.Size = new System.Drawing.Size(809, 185);
            this.AssocPartGrid.TabIndex = 7;
            // 
            // DelProBtn
            // 
            this.DelProBtn.BackColor = System.Drawing.Color.Silver;
            this.DelProBtn.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DelProBtn.Location = new System.Drawing.Point(1255, 695);
            this.DelProBtn.Name = "DelProBtn";
            this.DelProBtn.Size = new System.Drawing.Size(106, 54);
            this.DelProBtn.TabIndex = 8;
            this.DelProBtn.Text = "Delete";
            this.DelProBtn.UseVisualStyleBackColor = false;
            this.DelProBtn.Click += new System.EventHandler(this.DelProBtn_Click_1);
            // 
            // AdProCxlBtn
            // 
            this.AdProCxlBtn.BackColor = System.Drawing.Color.Silver;
            this.AdProCxlBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdProCxlBtn.Location = new System.Drawing.Point(1255, 769);
            this.AdProCxlBtn.Name = "AdProCxlBtn";
            this.AdProCxlBtn.Size = new System.Drawing.Size(106, 50);
            this.AdProCxlBtn.TabIndex = 9;
            this.AdProCxlBtn.Text = "Cancel";
            this.AdProCxlBtn.UseVisualStyleBackColor = false;
            this.AdProCxlBtn.Click += new System.EventHandler(this.AdProCxlBtn_Click_1);
            // 
            // AddProSvBtn
            // 
            this.AddProSvBtn.BackColor = System.Drawing.Color.Silver;
            this.AddProSvBtn.Location = new System.Drawing.Point(1129, 769);
            this.AddProSvBtn.Name = "AddProSvBtn";
            this.AddProSvBtn.Size = new System.Drawing.Size(106, 50);
            this.AddProSvBtn.TabIndex = 10;
            this.AddProSvBtn.Text = "Save";
            this.AddProSvBtn.UseVisualStyleBackColor = false;
            this.AddProSvBtn.Click += new System.EventHandler(this.AddProSvBtn_Click_1);
            // 
            // AddProTxtBx
            // 
            this.AddProTxtBx.Location = new System.Drawing.Point(171, 255);
            this.AddProTxtBx.Name = "AddProTxtBx";
            this.AddProTxtBx.Size = new System.Drawing.Size(208, 31);
            this.AddProTxtBx.TabIndex = 17;
            this.AddProTxtBx.TextChanged += new System.EventHandler(this.AddProTxtBx_TextChanged);
            // 
            // AdProNmBx
            // 
            this.AdProNmBx.Location = new System.Drawing.Point(171, 334);
            this.AdProNmBx.Name = "AdProNmBx";
            this.AdProNmBx.Size = new System.Drawing.Size(208, 31);
            this.AdProNmBx.TabIndex = 18;
            this.AdProNmBx.TextChanged += new System.EventHandler(this.AdProNmBx_TextChanged);
            // 
            // AdProInvBx
            // 
            this.AdProInvBx.Location = new System.Drawing.Point(171, 411);
            this.AdProInvBx.Name = "AdProInvBx";
            this.AdProInvBx.Size = new System.Drawing.Size(208, 31);
            this.AdProInvBx.TabIndex = 19;
            this.AdProInvBx.TextChanged += new System.EventHandler(this.AdProInvBx_TextChanged);
            // 
            // AdProPrcBx
            // 
            this.AdProPrcBx.Location = new System.Drawing.Point(171, 486);
            this.AdProPrcBx.Name = "AdProPrcBx";
            this.AdProPrcBx.Size = new System.Drawing.Size(208, 31);
            this.AdProPrcBx.TabIndex = 20;
            this.AdProPrcBx.TextChanged += new System.EventHandler(this.AdProPrcBx_TextChanged);
            // 
            // AdProMxBx
            // 
            this.AdProMxBx.Location = new System.Drawing.Point(121, 562);
            this.AdProMxBx.Name = "AdProMxBx";
            this.AdProMxBx.Size = new System.Drawing.Size(100, 31);
            this.AdProMxBx.TabIndex = 21;
            this.AdProMxBx.TextChanged += new System.EventHandler(this.AdProMxBx_TextChanged);
            // 
            // AdProMnBx
            // 
            this.AdProMnBx.Location = new System.Drawing.Point(356, 562);
            this.AdProMnBx.Name = "AdProMnBx";
            this.AdProMnBx.Size = new System.Drawing.Size(100, 31);
            this.AdProMnBx.TabIndex = 22;
            this.AdProMnBx.TextChanged += new System.EventHandler(this.AdProMnBx_TextChanged);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // process2
            // 
            this.process2.StartInfo.Domain = "";
            this.process2.StartInfo.LoadUserProfile = false;
            this.process2.StartInfo.Password = null;
            this.process2.StartInfo.StandardErrorEncoding = null;
            this.process2.StartInfo.StandardOutputEncoding = null;
            this.process2.StartInfo.UserName = "";
            this.process2.SynchronizingObject = this;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(39, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(29, 417);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 25;
            this.label6.Text = "Inventory";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(29, 492);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 26;
            this.label7.Text = "Price";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 568);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 27;
            this.label8.Text = "Max";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 568);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 28;
            this.label9.Text = "Min";
            // 
            // AddPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1417, 876);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AdProMnBx);
            this.Controls.Add(this.AdProMxBx);
            this.Controls.Add(this.AdProPrcBx);
            this.Controls.Add(this.AdProInvBx);
            this.Controls.Add(this.AdProNmBx);
            this.Controls.Add(this.AddProTxtBx);
            this.Controls.Add(this.AddProSvBtn);
            this.Controls.Add(this.AdProCxlBtn);
            this.Controls.Add(this.DelProBtn);
            this.Controls.Add(this.AssocPartGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AddProBtn);
            this.Controls.Add(this.AddProCanPartGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddProSearchbox);
            this.Controls.Add(this.AdProSearhBtn);
            this.Controls.Add(this.label1);
            this.Name = "AddPro";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddProCanPartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssocPartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AdProSearhBtn;
        private System.Windows.Forms.TextBox AddProSearchbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AddProCanPartGrid;
        private System.Windows.Forms.Button AddProBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView AssocPartGrid;
        private System.Windows.Forms.Button DelProBtn;
        private System.Windows.Forms.Button AdProCxlBtn;
        private System.Windows.Forms.Button AddProSvBtn;
        private System.Windows.Forms.TextBox AddProTxtBx;
        private System.Windows.Forms.TextBox AdProNmBx;
        private System.Windows.Forms.TextBox AdProInvBx;
        private System.Windows.Forms.TextBox AdProPrcBx;
        private System.Windows.Forms.TextBox AdProMxBx;
        private System.Windows.Forms.TextBox AdProMnBx;
        private System.Diagnostics.Process process1;
        private System.Diagnostics.Process process2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
    }
}