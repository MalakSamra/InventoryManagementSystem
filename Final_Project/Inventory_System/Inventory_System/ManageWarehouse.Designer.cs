namespace Inventory_System
{
    partial class ManageWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageWarehouse));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Exit_Btn = new System.Windows.Forms.Label();
            this.Display_All_WH_Btn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.WH_Datagrid_View = new Guna.UI.WinForms.GunaDataGridView();
            this.Go_To_WH_Data_Btn = new System.Windows.Forms.Button();
            this.WH_GB = new System.Windows.Forms.GroupBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Upd_WH_Btn = new System.Windows.Forms.Button();
            this.Add_WH_Btn = new System.Windows.Forms.Button();
            this.Manager_Txt_Box_WH = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Address_Txt_Box_WH = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_Txt_Box_WH = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.WH_Name_ComboBox = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WH_Datagrid_View)).BeginInit();
            this.WH_GB.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 126);
            this.panel1.TabIndex = 37;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(300, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(420, 49);
            this.label3.TabIndex = 24;
            this.label3.Text = "Manage Warehouse";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(228, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(599, 47);
            this.label2.TabIndex = 22;
            this.label2.Text = "Inventory Managment System";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.AutoSize = true;
            this.Exit_Btn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_Btn.Location = new System.Drawing.Point(979, 4);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(39, 39);
            this.Exit_Btn.TabIndex = 23;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Display_All_WH_Btn
            // 
            this.Display_All_WH_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Display_All_WH_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_All_WH_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display_All_WH_Btn.Location = new System.Drawing.Point(333, 174);
            this.Display_All_WH_Btn.Name = "Display_All_WH_Btn";
            this.Display_All_WH_Btn.Size = new System.Drawing.Size(158, 36);
            this.Display_All_WH_Btn.TabIndex = 44;
            this.Display_All_WH_Btn.Text = "Display All";
            this.Display_All_WH_Btn.UseVisualStyleBackColor = false;
            this.Display_All_WH_Btn.Click += new System.EventHandler(this.Display_All_WH_Btn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Crimson;
            this.label4.Location = new System.Drawing.Point(47, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(253, 36);
            this.label4.TabIndex = 43;
            this.label4.Text = "Warehouses List";
            // 
            // WH_Datagrid_View
            // 
            this.WH_Datagrid_View.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.WH_Datagrid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.WH_Datagrid_View.Location = new System.Drawing.Point(36, 222);
            this.WH_Datagrid_View.Name = "WH_Datagrid_View";
            this.WH_Datagrid_View.RowHeadersVisible = false;
            this.WH_Datagrid_View.RowHeadersWidth = 51;
            this.WH_Datagrid_View.RowTemplate.Height = 30;
            this.WH_Datagrid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.WH_Datagrid_View.Size = new System.Drawing.Size(479, 383);
            this.WH_Datagrid_View.TabIndex = 42;
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
            this.WH_Datagrid_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WH_Datagrid_View_MouseClick);
            // 
            // Go_To_WH_Data_Btn
            // 
            this.Go_To_WH_Data_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Go_To_WH_Data_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_To_WH_Data_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Go_To_WH_Data_Btn.Location = new System.Drawing.Point(720, 131);
            this.Go_To_WH_Data_Btn.Name = "Go_To_WH_Data_Btn";
            this.Go_To_WH_Data_Btn.Size = new System.Drawing.Size(69, 36);
            this.Go_To_WH_Data_Btn.TabIndex = 41;
            this.Go_To_WH_Data_Btn.Text = ">>";
            this.Go_To_WH_Data_Btn.UseVisualStyleBackColor = false;
            this.Go_To_WH_Data_Btn.Click += new System.EventHandler(this.Go_To_WH_Data_Btn_Click);
            // 
            // WH_GB
            // 
            this.WH_GB.Controls.Add(this.Add_Btn);
            this.WH_GB.Controls.Add(this.Upd_WH_Btn);
            this.WH_GB.Controls.Add(this.Add_WH_Btn);
            this.WH_GB.Controls.Add(this.Manager_Txt_Box_WH);
            this.WH_GB.Controls.Add(this.label8);
            this.WH_GB.Controls.Add(this.Address_Txt_Box_WH);
            this.WH_GB.Controls.Add(this.label7);
            this.WH_GB.Controls.Add(this.Name_Txt_Box_WH);
            this.WH_GB.Controls.Add(this.label6);
            this.WH_GB.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WH_GB.ForeColor = System.Drawing.Color.Crimson;
            this.WH_GB.Location = new System.Drawing.Point(551, 189);
            this.WH_GB.Name = "WH_GB";
            this.WH_GB.Size = new System.Drawing.Size(446, 422);
            this.WH_GB.TabIndex = 40;
            this.WH_GB.TabStop = false;
            this.WH_GB.Text = "Warehouse\'s Data";
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Btn.Location = new System.Drawing.Point(39, 332);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(116, 42);
            this.Add_Btn.TabIndex = 26;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Upd_WH_Btn
            // 
            this.Upd_WH_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Upd_WH_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upd_WH_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upd_WH_Btn.Location = new System.Drawing.Point(283, 332);
            this.Upd_WH_Btn.Name = "Upd_WH_Btn";
            this.Upd_WH_Btn.Size = new System.Drawing.Size(128, 42);
            this.Upd_WH_Btn.TabIndex = 38;
            this.Upd_WH_Btn.Text = "Update";
            this.Upd_WH_Btn.UseVisualStyleBackColor = false;
            this.Upd_WH_Btn.Click += new System.EventHandler(this.Upd_WH_Btn_Click);
            // 
            // Add_WH_Btn
            // 
            this.Add_WH_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Add_WH_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_WH_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_WH_Btn.Location = new System.Drawing.Point(161, 332);
            this.Add_WH_Btn.Name = "Add_WH_Btn";
            this.Add_WH_Btn.Size = new System.Drawing.Size(116, 42);
            this.Add_WH_Btn.TabIndex = 37;
            this.Add_WH_Btn.Text = "Add";
            this.Add_WH_Btn.UseVisualStyleBackColor = false;
            this.Add_WH_Btn.Click += new System.EventHandler(this.Add_WH_Btn_Click);
            // 
            // Manager_Txt_Box_WH
            // 
            this.Manager_Txt_Box_WH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Manager_Txt_Box_WH.Location = new System.Drawing.Point(11, 142);
            this.Manager_Txt_Box_WH.Name = "Manager_Txt_Box_WH";
            this.Manager_Txt_Box_WH.Size = new System.Drawing.Size(202, 30);
            this.Manager_Txt_Box_WH.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Manager:";
            // 
            // Address_Txt_Box_WH
            // 
            this.Address_Txt_Box_WH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Address_Txt_Box_WH.Location = new System.Drawing.Point(11, 221);
            this.Address_Txt_Box_WH.Multiline = true;
            this.Address_Txt_Box_WH.Name = "Address_Txt_Box_WH";
            this.Address_Txt_Box_WH.Size = new System.Drawing.Size(400, 71);
            this.Address_Txt_Box_WH.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(6, 179);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Address:";
            // 
            // Name_Txt_Box_WH
            // 
            this.Name_Txt_Box_WH.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Txt_Box_WH.Location = new System.Drawing.Point(11, 70);
            this.Name_Txt_Box_WH.Name = "Name_Txt_Box_WH";
            this.Name_Txt_Box_WH.Size = new System.Drawing.Size(202, 30);
            this.Name_Txt_Box_WH.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(6, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Name:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.Crimson;
            this.label13.Location = new System.Drawing.Point(303, 127);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(96, 36);
            this.label13.TabIndex = 39;
            this.label13.Text = "Name";
            // 
            // WH_Name_ComboBox
            // 
            this.WH_Name_ComboBox.DisplayMember = "ID";
            this.WH_Name_ComboBox.FormattingEnabled = true;
            this.WH_Name_ComboBox.Location = new System.Drawing.Point(421, 139);
            this.WH_Name_ComboBox.Name = "WH_Name_ComboBox";
            this.WH_Name_ComboBox.Size = new System.Drawing.Size(253, 24);
            this.WH_Name_ComboBox.TabIndex = 38;
            this.WH_Name_ComboBox.ValueMember = "ID";
            this.WH_Name_ComboBox.SelectedIndexChanged += new System.EventHandler(this.WH_Name_ComboBox_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 620);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1021, 23);
            this.panel2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(1135, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 39);
            this.label5.TabIndex = 1;
            this.label5.Text = "X";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ManageWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 643);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Display_All_WH_Btn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WH_Datagrid_View);
            this.Controls.Add(this.Go_To_WH_Data_Btn);
            this.Controls.Add(this.WH_GB);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.WH_Name_ComboBox);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageWarehouse";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageWarehouse";
            this.Load += new System.EventHandler(this.ManageWarehouse_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.WH_Datagrid_View)).EndInit();
            this.WH_GB.ResumeLayout(false);
            this.WH_GB.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Exit_Btn;
        private System.Windows.Forms.Button Display_All_WH_Btn;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaDataGridView WH_Datagrid_View;
        private System.Windows.Forms.Button Go_To_WH_Data_Btn;
        private System.Windows.Forms.GroupBox WH_GB;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Upd_WH_Btn;
        private System.Windows.Forms.Button Add_WH_Btn;
        private System.Windows.Forms.TextBox Manager_Txt_Box_WH;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Address_Txt_Box_WH;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Name_Txt_Box_WH;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox WH_Name_ComboBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
    }
}