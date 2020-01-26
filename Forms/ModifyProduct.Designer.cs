namespace ISS
{
    partial class ModPro
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
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.ModProMnBx = new System.Windows.Forms.TextBox();
            this.ModProMxBx = new System.Windows.Forms.TextBox();
            this.ModProPriceBx = new System.Windows.Forms.TextBox();
            this.ModProInvBx = new System.Windows.Forms.TextBox();
            this.ModProNameBx = new System.Windows.Forms.TextBox();
            this.ModProIDbox = new System.Windows.Forms.TextBox();
            this.MdProSvBtn = new System.Windows.Forms.Button();
            this.MoPrtCxlBtn = new System.Windows.Forms.Button();
            this.ModProDeleteBtn = new System.Windows.Forms.Button();
            this.process2 = new System.Diagnostics.Process();
            this.AddProCanPartGrid = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.MdProSrchbx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.AssocPartGrid = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.ModProAddbtn = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.MdProSrchBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.AddProCanPartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssocPartGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(227, 562);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 25);
            this.label9.TabIndex = 51;
            this.label9.Text = "Min";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 562);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 25);
            this.label8.TabIndex = 50;
            this.label8.Text = "Max";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 483);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 25);
            this.label7.TabIndex = 49;
            this.label7.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 404);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 25);
            this.label6.TabIndex = 48;
            this.label6.Text = "Inventory";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 322);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 25);
            this.label5.TabIndex = 47;
            this.label5.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 25);
            this.label4.TabIndex = 46;
            this.label4.Text = "ID";
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
            // ModProMnBx
            // 
            this.ModProMnBx.Location = new System.Drawing.Point(290, 557);
            this.ModProMnBx.Name = "ModProMnBx";
            this.ModProMnBx.Size = new System.Drawing.Size(100, 31);
            this.ModProMnBx.TabIndex = 45;
            this.ModProMnBx.TextChanged += new System.EventHandler(this.ModProMnBx_TextChanged);
            // 
            // ModProMxBx
            // 
            this.ModProMxBx.Location = new System.Drawing.Point(105, 557);
            this.ModProMxBx.Name = "ModProMxBx";
            this.ModProMxBx.Size = new System.Drawing.Size(100, 31);
            this.ModProMxBx.TabIndex = 44;
            this.ModProMxBx.TextChanged += new System.EventHandler(this.ModProMxBx_TextChanged);
            // 
            // ModProPriceBx
            // 
            this.ModProPriceBx.Location = new System.Drawing.Point(141, 478);
            this.ModProPriceBx.Name = "ModProPriceBx";
            this.ModProPriceBx.Size = new System.Drawing.Size(208, 31);
            this.ModProPriceBx.TabIndex = 43;
            this.ModProPriceBx.TextChanged += new System.EventHandler(this.ModProPriceBx_TextChanged);
            // 
            // ModProInvBx
            // 
            this.ModProInvBx.Location = new System.Drawing.Point(141, 400);
            this.ModProInvBx.Name = "ModProInvBx";
            this.ModProInvBx.Size = new System.Drawing.Size(208, 31);
            this.ModProInvBx.TabIndex = 42;
            this.ModProInvBx.TextChanged += new System.EventHandler(this.ModProInvBx_TextChanged);
            // 
            // ModProNameBx
            // 
            this.ModProNameBx.Location = new System.Drawing.Point(141, 319);
            this.ModProNameBx.Name = "ModProNameBx";
            this.ModProNameBx.Size = new System.Drawing.Size(208, 31);
            this.ModProNameBx.TabIndex = 41;
            this.ModProNameBx.TextChanged += new System.EventHandler(this.ModProNameBx_TextChanged);
            // 
            // ModProIDbox
            // 
            this.ModProIDbox.Location = new System.Drawing.Point(141, 235);
            this.ModProIDbox.Name = "ModProIDbox";
            this.ModProIDbox.Size = new System.Drawing.Size(208, 31);
            this.ModProIDbox.TabIndex = 40;
            this.ModProIDbox.TextChanged += new System.EventHandler(this.ModProIDbox_TextChanged);
            // 
            // MdProSvBtn
            // 
            this.MdProSvBtn.BackColor = System.Drawing.Color.Silver;
            this.MdProSvBtn.Location = new System.Drawing.Point(1022, 773);
            this.MdProSvBtn.Name = "MdProSvBtn";
            this.MdProSvBtn.Size = new System.Drawing.Size(95, 52);
            this.MdProSvBtn.TabIndex = 39;
            this.MdProSvBtn.Text = "Save";
            this.MdProSvBtn.UseVisualStyleBackColor = false;
            this.MdProSvBtn.Click += new System.EventHandler(this.MdProSvBtn_Click_1);
            // 
            // MoPrtCxlBtn
            // 
            this.MoPrtCxlBtn.BackColor = System.Drawing.Color.Silver;
            this.MoPrtCxlBtn.Font = new System.Drawing.Font("Microsoft YaHei UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MoPrtCxlBtn.Location = new System.Drawing.Point(1144, 773);
            this.MoPrtCxlBtn.Name = "MoPrtCxlBtn";
            this.MoPrtCxlBtn.Size = new System.Drawing.Size(111, 52);
            this.MoPrtCxlBtn.TabIndex = 38;
            this.MoPrtCxlBtn.Text = "Cancel";
            this.MoPrtCxlBtn.UseVisualStyleBackColor = false;
            this.MoPrtCxlBtn.Click += new System.EventHandler(this.MoPrtCxlBtn_Click_1);
            // 
            // ModProDeleteBtn
            // 
            this.ModProDeleteBtn.BackColor = System.Drawing.Color.Silver;
            this.ModProDeleteBtn.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModProDeleteBtn.Location = new System.Drawing.Point(1144, 696);
            this.ModProDeleteBtn.Name = "ModProDeleteBtn";
            this.ModProDeleteBtn.Size = new System.Drawing.Size(111, 58);
            this.ModProDeleteBtn.TabIndex = 37;
            this.ModProDeleteBtn.Text = "Delete";
            this.ModProDeleteBtn.UseVisualStyleBackColor = false;
            this.ModProDeleteBtn.Click += new System.EventHandler(this.ModProDeleteBtn_Click_1);
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
            // AddProCanPartGrid
            // 
            this.AddProCanPartGrid.AllowUserToAddRows = false;
            this.AddProCanPartGrid.AllowUserToDeleteRows = false;
            this.AddProCanPartGrid.AllowUserToResizeColumns = false;
            this.AddProCanPartGrid.AllowUserToResizeRows = false;
            this.AddProCanPartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AddProCanPartGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AddProCanPartGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.AddProCanPartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AddProCanPartGrid.Location = new System.Drawing.Point(446, 124);
            this.AddProCanPartGrid.Name = "AddProCanPartGrid";
            this.AddProCanPartGrid.RowHeadersVisible = false;
            this.AddProCanPartGrid.RowHeadersWidth = 82;
            this.AddProCanPartGrid.RowTemplate.Height = 33;
            this.AddProCanPartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AddProCanPartGrid.Size = new System.Drawing.Size(809, 199);
            this.AddProCanPartGrid.TabIndex = 33;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(442, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 25);
            this.label2.TabIndex = 32;
            this.label2.Text = "All Candidate Parts";
            // 
            // MdProSrchbx
            // 
            this.MdProSrchbx.Location = new System.Drawing.Point(903, 50);
            this.MdProSrchbx.Name = "MdProSrchbx";
            this.MdProSrchbx.Size = new System.Drawing.Size(352, 31);
            this.MdProSrchbx.TabIndex = 31;
            this.MdProSrchbx.TextChanged += new System.EventHandler(this.MdProSrchbx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 37);
            this.label1.TabIndex = 29;
            this.label1.Text = "Modify Product";
            // 
            // AssocPartGrid
            // 
            this.AssocPartGrid.AllowUserToAddRows = false;
            this.AssocPartGrid.AllowUserToDeleteRows = false;
            this.AssocPartGrid.AllowUserToResizeColumns = false;
            this.AssocPartGrid.AllowUserToResizeRows = false;
            this.AssocPartGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.AssocPartGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.AssocPartGrid.BackgroundColor = System.Drawing.Color.Gray;
            this.AssocPartGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AssocPartGrid.Location = new System.Drawing.Point(456, 478);
            this.AssocPartGrid.Name = "AssocPartGrid";
            this.AssocPartGrid.RowHeadersVisible = false;
            this.AssocPartGrid.RowHeadersWidth = 82;
            this.AssocPartGrid.RowTemplate.Height = 33;
            this.AssocPartGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AssocPartGrid.Size = new System.Drawing.Size(809, 185);
            this.AssocPartGrid.TabIndex = 36;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(441, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(338, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "Parts Associated with this Product";
            // 
            // ModProAddbtn
            // 
            this.ModProAddbtn.BackColor = System.Drawing.Color.Silver;
            this.ModProAddbtn.Font = new System.Drawing.Font("Segoe UI", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModProAddbtn.Location = new System.Drawing.Point(1144, 342);
            this.ModProAddbtn.Name = "ModProAddbtn";
            this.ModProAddbtn.Size = new System.Drawing.Size(111, 55);
            this.ModProAddbtn.TabIndex = 34;
            this.ModProAddbtn.Text = "Add";
            this.ModProAddbtn.UseVisualStyleBackColor = false;
            this.ModProAddbtn.Click += new System.EventHandler(this.ModProAddbtn_Click_1);
            // 
            // MdProSrchBtn
            // 
            this.MdProSrchBtn.BackColor = System.Drawing.Color.Silver;
            this.MdProSrchBtn.Location = new System.Drawing.Point(772, 35);
            this.MdProSrchBtn.Name = "MdProSrchBtn";
            this.MdProSrchBtn.Size = new System.Drawing.Size(125, 49);
            this.MdProSrchBtn.TabIndex = 52;
            this.MdProSrchBtn.Text = "ID Search";
            this.MdProSrchBtn.UseVisualStyleBackColor = false;
            this.MdProSrchBtn.Click += new System.EventHandler(this.MdProSrchBtn_Click_1);
            // 
            // ModPro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1305, 884);
            this.Controls.Add(this.MdProSrchBtn);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ModProMnBx);
            this.Controls.Add(this.ModProMxBx);
            this.Controls.Add(this.ModProPriceBx);
            this.Controls.Add(this.ModProInvBx);
            this.Controls.Add(this.ModProNameBx);
            this.Controls.Add(this.ModProIDbox);
            this.Controls.Add(this.MdProSvBtn);
            this.Controls.Add(this.MoPrtCxlBtn);
            this.Controls.Add(this.ModProDeleteBtn);
            this.Controls.Add(this.AddProCanPartGrid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MdProSrchbx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AssocPartGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ModProAddbtn);
            this.Name = "ModPro";
            this.Text = "Product";
            ((System.ComponentModel.ISupportInitialize)(this.AddProCanPartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AssocPartGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Diagnostics.Process process1;
        private System.Windows.Forms.TextBox ModProMnBx;
        private System.Windows.Forms.TextBox ModProMxBx;
        private System.Windows.Forms.TextBox ModProPriceBx;
        private System.Windows.Forms.TextBox ModProInvBx;
        private System.Windows.Forms.TextBox ModProNameBx;
        private System.Windows.Forms.TextBox ModProIDbox;
        private System.Windows.Forms.Button MdProSvBtn;
        private System.Windows.Forms.Button MoPrtCxlBtn;
        private System.Windows.Forms.Button ModProDeleteBtn;
        private System.Windows.Forms.DataGridView AddProCanPartGrid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox MdProSrchbx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView AssocPartGrid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ModProAddbtn;
        private System.Diagnostics.Process process2;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.Button MdProSrchBtn;
    }
}