namespace Inventory_System
{
    partial class ManageRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageRequests));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Exit_Btn = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Go_To_Data_Btn = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.Req_ID_comboBox = new System.Windows.Forms.ComboBox();
            this.Display_All_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Request_Datagrid_View = new Guna.UI.WinForms.GunaDataGridView();
            this.Request_GB = new System.Windows.Forms.GroupBox();
            this.Prod_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.WH_comboBox = new System.Windows.Forms.ComboBox();
            this.Supp_comboBox = new System.Windows.Forms.ComboBox();
            this.Prod_code_comboBox = new System.Windows.Forms.ComboBox();
            this.Req_Date = new System.Windows.Forms.DateTimePicker();
            this.label14 = new System.Windows.Forms.Label();
            this.Quant_Txt_Box = new System.Windows.Forms.TextBox();
            this.Req_Type_combo_box = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Upd_R_Btn = new System.Windows.Forms.Button();
            this.Add_Req_Btn = new System.Windows.Forms.Button();
            this.Validation_Period_Txt_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_Txt_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_Datagrid_View)).BeginInit();
            this.Request_GB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1039, 126);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(337, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(374, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Requests";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.AutoSize = true;
            this.Exit_Btn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_Btn.Location = new System.Drawing.Point(988, 12);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(39, 39);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(243, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Managment System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 23);
            this.panel2.TabIndex = 20;
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
            // Go_To_Data_Btn
            // 
            this.Go_To_Data_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Go_To_Data_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_To_Data_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Go_To_Data_Btn.Location = new System.Drawing.Point(567, 138);
            this.Go_To_Data_Btn.Name = "Go_To_Data_Btn";
            this.Go_To_Data_Btn.Size = new System.Drawing.Size(69, 36);
            this.Go_To_Data_Btn.TabIndex = 28;
            this.Go_To_Data_Btn.Text = ">>";
            this.Go_To_Data_Btn.UseVisualStyleBackColor = false;
            this.Go_To_Data_Btn.Click += new System.EventHandler(this.Go_To_Data_Btn_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(198, 138);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(173, 36);
            this.label10.TabIndex = 27;
            this.label10.Text = "Request ID";
            // 
            // Req_ID_comboBox
            // 
            this.Req_ID_comboBox.DisplayMember = "ID";
            this.Req_ID_comboBox.FormattingEnabled = true;
            this.Req_ID_comboBox.Location = new System.Drawing.Point(392, 146);
            this.Req_ID_comboBox.Name = "Req_ID_comboBox";
            this.Req_ID_comboBox.Size = new System.Drawing.Size(99, 24);
            this.Req_ID_comboBox.TabIndex = 26;
            this.Req_ID_comboBox.ValueMember = "ID";
            this.Req_ID_comboBox.SelectedIndexChanged += new System.EventHandler(this.Req_ID_comboBox_SelectedIndexChanged);
            // 
            // Display_All_Btn
            // 
            this.Display_All_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Display_All_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_All_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display_All_Btn.Location = new System.Drawing.Point(271, 191);
            this.Display_All_Btn.Name = "Display_All_Btn";
            this.Display_All_Btn.Size = new System.Drawing.Size(158, 36);
            this.Display_All_Btn.TabIndex = 31;
            this.Display_All_Btn.Text = "Display All";
            this.Display_All_Btn.UseVisualStyleBackColor = false;
            this.Display_All_Btn.Click += new System.EventHandler(this.Display_All_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(23, 191);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 36);
            this.label2.TabIndex = 30;
            this.label2.Text = "Request List";
            // 
            // Request_Datagrid_View
            // 
            this.Request_Datagrid_View.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Request_Datagrid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Request_Datagrid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Request_Datagrid_View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Request_Datagrid_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Request_Datagrid_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Request_Datagrid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Request_Datagrid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Request_Datagrid_View.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Request_Datagrid_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Request_Datagrid_View.EnableHeadersVisualStyles = false;
            this.Request_Datagrid_View.GridColor = System.Drawing.Color.Gray;
            this.Request_Datagrid_View.Location = new System.Drawing.Point(12, 244);
            this.Request_Datagrid_View.Name = "Request_Datagrid_View";
            this.Request_Datagrid_View.RowHeadersVisible = false;
            this.Request_Datagrid_View.RowHeadersWidth = 51;
            this.Request_Datagrid_View.RowTemplate.Height = 30;
            this.Request_Datagrid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Request_Datagrid_View.Size = new System.Drawing.Size(516, 383);
            this.Request_Datagrid_View.TabIndex = 29;
            this.Request_Datagrid_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Request_Datagrid_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Request_Datagrid_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Request_Datagrid_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Request_Datagrid_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Request_Datagrid_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Request_Datagrid_View.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.Request_Datagrid_View.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.Request_Datagrid_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.Request_Datagrid_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Request_Datagrid_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Request_Datagrid_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Request_Datagrid_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Request_Datagrid_View.ThemeStyle.HeaderStyle.Height = 30;
            this.Request_Datagrid_View.ThemeStyle.ReadOnly = false;
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.Height = 30;
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Request_Datagrid_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Request_Datagrid_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Request_Datagrid_View_MouseClick);
            // 
            // Request_GB
            // 
            this.Request_GB.Controls.Add(this.Prod_dateTimePicker);
            this.Request_GB.Controls.Add(this.WH_comboBox);
            this.Request_GB.Controls.Add(this.Supp_comboBox);
            this.Request_GB.Controls.Add(this.Prod_code_comboBox);
            this.Request_GB.Controls.Add(this.Req_Date);
            this.Request_GB.Controls.Add(this.label14);
            this.Request_GB.Controls.Add(this.Quant_Txt_Box);
            this.Request_GB.Controls.Add(this.Req_Type_combo_box);
            this.Request_GB.Controls.Add(this.label13);
            this.Request_GB.Controls.Add(this.Add_Btn);
            this.Request_GB.Controls.Add(this.Upd_R_Btn);
            this.Request_GB.Controls.Add(this.Add_Req_Btn);
            this.Request_GB.Controls.Add(this.Validation_Period_Txt_Box);
            this.Request_GB.Controls.Add(this.label12);
            this.Request_GB.Controls.Add(this.label11);
            this.Request_GB.Controls.Add(this.label9);
            this.Request_GB.Controls.Add(this.label8);
            this.Request_GB.Controls.Add(this.label7);
            this.Request_GB.Controls.Add(this.label6);
            this.Request_GB.Controls.Add(this.ID_Txt_Box);
            this.Request_GB.Controls.Add(this.label4);
            this.Request_GB.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Request_GB.ForeColor = System.Drawing.Color.Crimson;
            this.Request_GB.Location = new System.Drawing.Point(534, 217);
            this.Request_GB.Name = "Request_GB";
            this.Request_GB.Size = new System.Drawing.Size(493, 422);
            this.Request_GB.TabIndex = 32;
            this.Request_GB.TabStop = false;
            this.Request_GB.Text = "Request\'s Data";
            // 
            // Prod_dateTimePicker
            // 
            this.Prod_dateTimePicker.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Prod_dateTimePicker.Location = new System.Drawing.Point(253, 255);
            this.Prod_dateTimePicker.Name = "Prod_dateTimePicker";
            this.Prod_dateTimePicker.Size = new System.Drawing.Size(203, 34);
            this.Prod_dateTimePicker.TabIndex = 47;
            // 
            // WH_comboBox
            // 
            this.WH_comboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WH_comboBox.FormattingEnabled = true;
            this.WH_comboBox.Location = new System.Drawing.Point(253, 159);
            this.WH_comboBox.Name = "WH_comboBox";
            this.WH_comboBox.Size = new System.Drawing.Size(175, 34);
            this.WH_comboBox.TabIndex = 46;
            // 
            // Supp_comboBox
            // 
            this.Supp_comboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Supp_comboBox.FormattingEnabled = true;
            this.Supp_comboBox.Location = new System.Drawing.Point(253, 118);
            this.Supp_comboBox.Name = "Supp_comboBox";
            this.Supp_comboBox.Size = new System.Drawing.Size(175, 34);
            this.Supp_comboBox.TabIndex = 45;
            // 
            // Prod_code_comboBox
            // 
            this.Prod_code_comboBox.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Prod_code_comboBox.FormattingEnabled = true;
            this.Prod_code_comboBox.Location = new System.Drawing.Point(253, 77);
            this.Prod_code_comboBox.Name = "Prod_code_comboBox";
            this.Prod_code_comboBox.Size = new System.Drawing.Size(175, 34);
            this.Prod_code_comboBox.TabIndex = 44;
            // 
            // Req_Date
            // 
            this.Req_Date.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Req_Date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Req_Date.Location = new System.Drawing.Point(83, 204);
            this.Req_Date.Name = "Req_Date";
            this.Req_Date.Size = new System.Drawing.Size(141, 30);
            this.Req_Date.TabIndex = 43;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.SystemColors.Control;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label14.Location = new System.Drawing.Point(6, 249);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(207, 29);
            this.label14.TabIndex = 42;
            this.label14.Text = "Production Date:";
            // 
            // Quant_Txt_Box
            // 
            this.Quant_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quant_Txt_Box.Location = new System.Drawing.Point(376, 204);
            this.Quant_Txt_Box.Name = "Quant_Txt_Box";
            this.Quant_Txt_Box.Size = new System.Drawing.Size(80, 30);
            this.Quant_Txt_Box.TabIndex = 41;
            // 
            // Req_Type_combo_box
            // 
            this.Req_Type_combo_box.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Req_Type_combo_box.FormattingEnabled = true;
            this.Req_Type_combo_box.Location = new System.Drawing.Point(333, 35);
            this.Req_Type_combo_box.Name = "Req_Type_combo_box";
            this.Req_Type_combo_box.Size = new System.Drawing.Size(123, 34);
            this.Req_Type_combo_box.TabIndex = 40;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.SystemColors.Control;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label13.Location = new System.Drawing.Point(248, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(79, 29);
            this.label13.TabIndex = 39;
            this.label13.Text = "Type:";
            // 
            // Add_Btn
            // 
            this.Add_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Add_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Btn.Location = new System.Drawing.Point(56, 350);
            this.Add_Btn.Name = "Add_Btn";
            this.Add_Btn.Size = new System.Drawing.Size(116, 42);
            this.Add_Btn.TabIndex = 26;
            this.Add_Btn.Text = "Add";
            this.Add_Btn.UseVisualStyleBackColor = false;
            this.Add_Btn.Click += new System.EventHandler(this.Add_Btn_Click);
            // 
            // Upd_R_Btn
            // 
            this.Upd_R_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Upd_R_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upd_R_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upd_R_Btn.Location = new System.Drawing.Point(300, 350);
            this.Upd_R_Btn.Name = "Upd_R_Btn";
            this.Upd_R_Btn.Size = new System.Drawing.Size(128, 42);
            this.Upd_R_Btn.TabIndex = 38;
            this.Upd_R_Btn.Text = "Update";
            this.Upd_R_Btn.UseVisualStyleBackColor = false;
            this.Upd_R_Btn.Click += new System.EventHandler(this.Upd_R_Btn_Click);
            // 
            // Add_Req_Btn
            // 
            this.Add_Req_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Add_Req_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Req_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Req_Btn.Location = new System.Drawing.Point(178, 350);
            this.Add_Req_Btn.Name = "Add_Req_Btn";
            this.Add_Req_Btn.Size = new System.Drawing.Size(116, 42);
            this.Add_Req_Btn.TabIndex = 37;
            this.Add_Req_Btn.Text = "Add";
            this.Add_Req_Btn.UseVisualStyleBackColor = false;
            this.Add_Req_Btn.Click += new System.EventHandler(this.Add_Req_Btn_Click);
            // 
            // Validation_Period_Txt_Box
            // 
            this.Validation_Period_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Validation_Period_Txt_Box.Location = new System.Drawing.Point(253, 294);
            this.Validation_Period_Txt_Box.Name = "Validation_Period_Txt_Box";
            this.Validation_Period_Txt_Box.Size = new System.Drawing.Size(203, 30);
            this.Validation_Period_Txt_Box.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(6, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "Validity Period:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(248, 204);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 29);
            this.label11.TabIndex = 33;
            this.label11.Text = "Quantity:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(3, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(74, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Date:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(3, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(228, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Warehouse Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Supplier Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Product Code:";
            // 
            // ID_Txt_Box
            // 
            this.ID_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Txt_Box.Location = new System.Drawing.Point(59, 39);
            this.ID_Txt_Box.Name = "ID_Txt_Box";
            this.ID_Txt_Box.Size = new System.Drawing.Size(69, 30);
            this.ID_Txt_Box.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(4, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 29);
            this.label4.TabIndex = 23;
            this.label4.Text = "ID:";
            // 
            // ManageRequests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 690);
            this.Controls.Add(this.Request_GB);
            this.Controls.Add(this.Display_All_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Request_Datagrid_View);
            this.Controls.Add(this.Go_To_Data_Btn);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Req_ID_comboBox);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageRequests";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ManageRequests";
            this.Load += new System.EventHandler(this.ManageRequests_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Request_Datagrid_View)).EndInit();
            this.Request_GB.ResumeLayout(false);
            this.Request_GB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Exit_Btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Go_To_Data_Btn;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox Req_ID_comboBox;
        private System.Windows.Forms.Button Display_All_Btn;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaDataGridView Request_Datagrid_View;
        private System.Windows.Forms.GroupBox Request_GB;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Upd_R_Btn;
        private System.Windows.Forms.Button Add_Req_Btn;
        private System.Windows.Forms.TextBox Validation_Period_Txt_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID_Txt_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Req_Date;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox Quant_Txt_Box;
        private System.Windows.Forms.ComboBox Req_Type_combo_box;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox WH_comboBox;
        private System.Windows.Forms.ComboBox Supp_comboBox;
        private System.Windows.Forms.ComboBox Prod_code_comboBox;
        private System.Windows.Forms.DateTimePicker Prod_dateTimePicker;
    }
}