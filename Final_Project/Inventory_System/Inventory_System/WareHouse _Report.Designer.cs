﻿namespace Inventory_System
{
    partial class WareHouse__Report
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WareHouse__Report));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Go_To_Prod_Data_Btn = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.WH_Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.WH_Datagrid_View = new Guna.UI.WinForms.GunaDataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.From_DatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.To_DatetimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WH_Datagrid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 91);
            this.panel1.TabIndex = 40;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.AutoSize = true;
            this.Exit_Btn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_Btn.Location = new System.Drawing.Point(970, 9);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(39, 39);
            this.Exit_Btn.TabIndex = 24;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(1135, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "X";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(316, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 47);
            this.label2.TabIndex = 22;
            this.label2.Text = "Warehouse Report";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Go_To_Prod_Data_Btn
            // 
            this.Go_To_Prod_Data_Btn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Go_To_Prod_Data_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Go_To_Prod_Data_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_To_Prod_Data_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Go_To_Prod_Data_Btn.Location = new System.Drawing.Point(857, 143);
            this.Go_To_Prod_Data_Btn.Name = "Go_To_Prod_Data_Btn";
            this.Go_To_Prod_Data_Btn.Size = new System.Drawing.Size(69, 36);
            this.Go_To_Prod_Data_Btn.TabIndex = 51;
            this.Go_To_Prod_Data_Btn.Text = ">>";
            this.Go_To_Prod_Data_Btn.UseVisualStyleBackColor = false;
            this.Go_To_Prod_Data_Btn.Click += new System.EventHandler(this.Go_To_Prod_Data_Btn_Click);
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(203, 107);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(149, 32);
            this.label13.TabIndex = 50;
            this.label13.Text = "WH Name";
            // 
            // WH_Name_ComboBox
            // 
            this.WH_Name_ComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_Name_ComboBox.DisplayMember = "ID";
            this.WH_Name_ComboBox.FormattingEnabled = true;
            this.WH_Name_ComboBox.Location = new System.Drawing.Point(371, 114);
            this.WH_Name_ComboBox.Name = "WH_Name_ComboBox";
            this.WH_Name_ComboBox.Size = new System.Drawing.Size(253, 24);
            this.WH_Name_ComboBox.TabIndex = 49;
            this.WH_Name_ComboBox.ValueMember = "ID";
            // 
            // WH_Datagrid_View
            // 
            this.WH_Datagrid_View.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.WH_Datagrid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.WH_Datagrid_View.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WH_Datagrid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.WH_Datagrid_View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.WH_Datagrid_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.WH_Datagrid_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WH_Datagrid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.WH_Datagrid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.WH_Datagrid_View.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.WH_Datagrid_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.WH_Datagrid_View.EnableHeadersVisualStyles = false;
            this.WH_Datagrid_View.GridColor = System.Drawing.Color.Gray;
            this.WH_Datagrid_View.Location = new System.Drawing.Point(12, 200);
            this.WH_Datagrid_View.Name = "WH_Datagrid_View";
            this.WH_Datagrid_View.RowHeadersVisible = false;
            this.WH_Datagrid_View.RowHeadersWidth = 51;
            this.WH_Datagrid_View.RowTemplate.Height = 30;
            this.WH_Datagrid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WH_Datagrid_View.Size = new System.Drawing.Size(997, 383);
            this.WH_Datagrid_View.TabIndex = 52;
            this.WH_Datagrid_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.WH_Datagrid_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.WH_Datagrid_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.WH_Datagrid_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.WH_Datagrid_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.WH_Datagrid_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.WH_Datagrid_View.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.WH_Datagrid_View.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.WH_Datagrid_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.WH_Datagrid_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.WH_Datagrid_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.WH_Datagrid_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.WH_Datagrid_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.WH_Datagrid_View.ThemeStyle.HeaderStyle.Height = 30;
            this.WH_Datagrid_View.ThemeStyle.ReadOnly = false;
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.Height = 30;
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.WH_Datagrid_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(76, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 29);
            this.label6.TabIndex = 53;
            this.label6.Text = "From:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(511, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 29);
            this.label3.TabIndex = 54;
            this.label3.Text = "To:";
            // 
            // From_DatetimePicker
            // 
            this.From_DatetimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.From_DatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.From_DatetimePicker.Location = new System.Drawing.Point(163, 152);
            this.From_DatetimePicker.Name = "From_DatetimePicker";
            this.From_DatetimePicker.Size = new System.Drawing.Size(135, 27);
            this.From_DatetimePicker.TabIndex = 55;
            // 
            // To_DatetimePicker
            // 
            this.To_DatetimePicker.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.To_DatetimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.To_DatetimePicker.Location = new System.Drawing.Point(571, 152);
            this.To_DatetimePicker.Name = "To_DatetimePicker";
            this.To_DatetimePicker.Size = new System.Drawing.Size(135, 27);
            this.To_DatetimePicker.TabIndex = 56;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(793, 589);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(198, 36);
            this.button1.TabIndex = 57;
            this.button1.Text = "Save as PDF";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 54);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // WareHouse__Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 643);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.To_DatetimePicker);
            this.Controls.Add(this.From_DatetimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.WH_Datagrid_View);
            this.Controls.Add(this.Go_To_Prod_Data_Btn);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WH_Name_ComboBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WareHouse__Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WareHouse__Report";
            this.Load += new System.EventHandler(this.WareHouse__Report_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WH_Datagrid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Go_To_Prod_Data_Btn;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox WH_Name_ComboBox;
        private Guna.UI.WinForms.GunaDataGridView WH_Datagrid_View;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker From_DatetimePicker;
        private System.Windows.Forms.DateTimePicker To_DatetimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Exit_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}