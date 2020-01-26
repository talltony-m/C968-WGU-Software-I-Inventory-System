using System.Windows.Forms;

namespace ISS
{
    partial class MnScrn
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
            this.label2 = new System.Windows.Forms.Label();
            this.MnPrtSrcBtn = new System.Windows.Forms.Button();
            this.MnProSrcBtn = new System.Windows.Forms.Button();
            this.SrchPrtBx = new System.Windows.Forms.TextBox();
            this.SrchProBx = new System.Windows.Forms.TextBox();
            this.DgPrt = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.PartAddButton = new System.Windows.Forms.Button();
            this.PartModButton = new System.Windows.Forms.Button();
            this.PrtDltBtn = new System.Windows.Forms.Button();
            this.ProAddButton = new System.Windows.Forms.Button();
            this.ProModButton = new System.Windows.Forms.Button();
            this.ProDltBtn = new System.Windows.Forms.Button();
            this.ExitButton = new System.Windows.Forms.Button();
            this.DgPro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DgPrt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPro)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Management System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 45);
            this.label2.TabIndex = 1;
            this.label2.Text = "Parts";
            // 
            // MnPrtSrcBtn
            // 
            this.MnPrtSrcBtn.BackColor = System.Drawing.Color.Silver;
            this.MnPrtSrcBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnPrtSrcBtn.Location = new System.Drawing.Point(458, 91);
            this.MnPrtSrcBtn.Name = "MnPrtSrcBtn";
            this.MnPrtSrcBtn.Size = new System.Drawing.Size(155, 51);
            this.MnPrtSrcBtn.TabIndex = 3;
            this.MnPrtSrcBtn.Text = "ID Search";
            this.MnPrtSrcBtn.UseVisualStyleBackColor = false;
            this.MnPrtSrcBtn.Click += new System.EventHandler(this.MnPrtSrcBtn_Click_1);
            // 
            // MnProSrcBtn
            // 
            this.MnProSrcBtn.BackColor = System.Drawing.Color.Silver;
            this.MnProSrcBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MnProSrcBtn.Location = new System.Drawing.Point(1316, 91);
            this.MnProSrcBtn.Name = "MnProSrcBtn";
            this.MnProSrcBtn.Size = new System.Drawing.Size(167, 51);
            this.MnProSrcBtn.TabIndex = 4;
            this.MnProSrcBtn.Text = "ID Search";
            this.MnProSrcBtn.UseVisualStyleBackColor = false;
            this.MnProSrcBtn.Click += new System.EventHandler(this.MnProSrcBtn_Click_1);
            // 
            // SrchPrtBx
            // 
            this.SrchPrtBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchPrtBx.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchPrtBx.Location = new System.Drawing.Point(619, 96);
            this.SrchPrtBx.Name = "SrchPrtBx";
            this.SrchPrtBx.Size = new System.Drawing.Size(237, 43);
            this.SrchPrtBx.TabIndex = 5;
            // 
            // SrchProBx
            // 
            this.SrchProBx.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SrchProBx.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SrchProBx.Location = new System.Drawing.Point(1489, 94);
            this.SrchProBx.Name = "SrchProBx";
            this.SrchProBx.Size = new System.Drawing.Size(237, 43);
            this.SrchProBx.TabIndex = 6;
            // 
            // DgPrt
            // 
            this.DgPrt.AllowUserToAddRows = false;
            this.DgPrt.AllowUserToDeleteRows = false;
            this.DgPrt.AllowUserToResizeColumns = false;
            this.DgPrt.AllowUserToResizeRows = false;
            this.DgPrt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgPrt.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgPrt.BackgroundColor = System.Drawing.Color.Gray;
            this.DgPrt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPrt.Location = new System.Drawing.Point(75, 168);
            this.DgPrt.Name = "DgPrt";
            this.DgPrt.ReadOnly = true;
            this.DgPrt.RowHeadersVisible = false;
            this.DgPrt.RowHeadersWidth = 82;
            this.DgPrt.RowTemplate.Height = 33;
            this.DgPrt.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgPrt.Size = new System.Drawing.Size(808, 252);
            this.DgPrt.StandardTab = true;
            this.DgPrt.TabIndex = 7;
            this.DgPrt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgPrt_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(910, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 45);
            this.label4.TabIndex = 9;
            this.label4.Text = "Products";
            // 
            // PartAddButton
            // 
            this.PartAddButton.BackColor = System.Drawing.Color.Silver;
            this.PartAddButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartAddButton.Location = new System.Drawing.Point(458, 455);
            this.PartAddButton.Name = "PartAddButton";
            this.PartAddButton.Size = new System.Drawing.Size(128, 57);
            this.PartAddButton.TabIndex = 10;
            this.PartAddButton.Text = "Add";
            this.PartAddButton.UseVisualStyleBackColor = false;
            this.PartAddButton.Click += new System.EventHandler(this.PartAddButton_Click_1);
            // 
            // PartModButton
            // 
            this.PartModButton.BackColor = System.Drawing.Color.Silver;
            this.PartModButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PartModButton.Location = new System.Drawing.Point(593, 455);
            this.PartModButton.Name = "PartModButton";
            this.PartModButton.Size = new System.Drawing.Size(125, 57);
            this.PartModButton.TabIndex = 11;
            this.PartModButton.Text = "Modify";
            this.PartModButton.UseVisualStyleBackColor = false;
            this.PartModButton.Click += new System.EventHandler(this.PartModButton_Click_1);
            // 
            // PrtDltBtn
            // 
            this.PrtDltBtn.BackColor = System.Drawing.Color.Silver;
            this.PrtDltBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PrtDltBtn.Location = new System.Drawing.Point(724, 455);
            this.PrtDltBtn.Name = "PrtDltBtn";
            this.PrtDltBtn.Size = new System.Drawing.Size(132, 57);
            this.PrtDltBtn.TabIndex = 12;
            this.PrtDltBtn.Text = "Delete";
            this.PrtDltBtn.UseVisualStyleBackColor = false;
            this.PrtDltBtn.Click += new System.EventHandler(this.PrtDltBtn_Click_1);
            // 
            // ProAddButton
            // 
            this.ProAddButton.BackColor = System.Drawing.Color.Silver;
            this.ProAddButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProAddButton.Location = new System.Drawing.Point(1329, 455);
            this.ProAddButton.Name = "ProAddButton";
            this.ProAddButton.Size = new System.Drawing.Size(133, 57);
            this.ProAddButton.TabIndex = 13;
            this.ProAddButton.Text = "Add";
            this.ProAddButton.UseVisualStyleBackColor = false;
            this.ProAddButton.Click += new System.EventHandler(this.ProAddButton_Click_1);
            // 
            // ProModButton
            // 
            this.ProModButton.BackColor = System.Drawing.Color.Silver;
            this.ProModButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProModButton.Location = new System.Drawing.Point(1468, 455);
            this.ProModButton.Name = "ProModButton";
            this.ProModButton.Size = new System.Drawing.Size(124, 57);
            this.ProModButton.TabIndex = 14;
            this.ProModButton.Text = "Modify";
            this.ProModButton.UseVisualStyleBackColor = false;
            this.ProModButton.Click += new System.EventHandler(this.ProModButton_Click_1);
            // 
            // ProDltBtn
            // 
            this.ProDltBtn.BackColor = System.Drawing.Color.Silver;
            this.ProDltBtn.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProDltBtn.Location = new System.Drawing.Point(1598, 455);
            this.ProDltBtn.Name = "ProDltBtn";
            this.ProDltBtn.Size = new System.Drawing.Size(127, 57);
            this.ProDltBtn.TabIndex = 15;
            this.ProDltBtn.Text = "Delete";
            this.ProDltBtn.UseVisualStyleBackColor = false;
            this.ProDltBtn.Click += new System.EventHandler(this.ProDltBtn_Click_1);
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Silver;
            this.ExitButton.Font = new System.Drawing.Font("Segoe UI", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitButton.Location = new System.Drawing.Point(1598, 561);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(128, 56);
            this.ExitButton.TabIndex = 16;
            this.ExitButton.Text = "Exit";
            this.ExitButton.UseVisualStyleBackColor = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click_1);
            // 
            // DgPro
            // 
            this.DgPro.AllowUserToAddRows = false;
            this.DgPro.AllowUserToDeleteRows = false;
            this.DgPro.AllowUserToResizeColumns = false;
            this.DgPro.AllowUserToResizeRows = false;
            this.DgPro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.DgPro.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DgPro.BackgroundColor = System.Drawing.Color.Gray;
            this.DgPro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPro.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.DgPro.Location = new System.Drawing.Point(918, 168);
            this.DgPro.MultiSelect = false;
            this.DgPro.Name = "DgPro";
            this.DgPro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.DgPro.RowHeadersVisible = false;
            this.DgPro.RowHeadersWidth = 82;
            this.DgPro.RowTemplate.Height = 33;
            this.DgPro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgPro.ShowEditingIcon = false;
            this.DgPro.Size = new System.Drawing.Size(808, 252);
            this.DgPro.StandardTab = true;
            this.DgPro.TabIndex = 7;
            // 
            // MnScrn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1757, 697);
            this.Controls.Add(this.DgPro);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ProDltBtn);
            this.Controls.Add(this.ProModButton);
            this.Controls.Add(this.ProAddButton);
            this.Controls.Add(this.PrtDltBtn);
            this.Controls.Add(this.PartModButton);
            this.Controls.Add(this.PartAddButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgPrt);
            this.Controls.Add(this.SrchProBx);
            this.Controls.Add(this.SrchPrtBx);
            this.Controls.Add(this.MnProSrcBtn);
            this.Controls.Add(this.MnPrtSrcBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MnScrn";
            this.Text = " Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.DgPrt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgPro)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button MnPrtSrcBtn;
        private System.Windows.Forms.Button MnProSrcBtn;
        private System.Windows.Forms.TextBox SrchPrtBx;
        private System.Windows.Forms.TextBox SrchProBx;
        private DataGridView DgPrt;
        private Label label4;
        private Button PartAddButton;
        private Button PartModButton;
        private Button PrtDltBtn;
        private Button ProAddButton;
        private Button ProModButton;
        private Button ProDltBtn;
        private Button ExitButton;
        private DataGridView DgPro;

        public Label Label3 { get => label3; set => label3 = value; }
    }
}

