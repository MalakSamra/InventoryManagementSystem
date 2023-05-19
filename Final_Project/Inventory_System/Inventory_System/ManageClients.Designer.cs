namespace Inventory_System
{
    partial class ManageClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ManageClients));
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.Client_GB = new System.Windows.Forms.GroupBox();
            this.Add_Btn = new System.Windows.Forms.Button();
            this.Upd_C_Btn = new System.Windows.Forms.Button();
            this.Add_Client_Btn = new System.Windows.Forms.Button();
            this.Website_Txt_Box = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Email_Txt_Box = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Fax_Txt_Box = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Work_Num_Txt_Box = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Mob_Num_Txt_Box = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Name_Txt_Box = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.ID_Txt_Box = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Go_To_Data_Btn = new System.Windows.Forms.Button();
            this.Client_Datagrid_View = new Guna.UI.WinForms.GunaDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Exit_Btn = new System.Windows.Forms.Label();
            this.Display_All_Btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.Client_GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Datagrid_View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DisplayMember = "ID";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(400, 150);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(99, 24);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.ValueMember = "ID";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Crimson;
            this.label10.Location = new System.Drawing.Point(348, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 36);
            this.label10.TabIndex = 15;
            this.label10.Text = "ID";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkCyan;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 667);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1039, 23);
            this.panel2.TabIndex = 19;
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
            // Client_GB
            // 
            this.Client_GB.Controls.Add(this.Add_Btn);
            this.Client_GB.Controls.Add(this.Upd_C_Btn);
            this.Client_GB.Controls.Add(this.Add_Client_Btn);
            this.Client_GB.Controls.Add(this.Website_Txt_Box);
            this.Client_GB.Controls.Add(this.label12);
            this.Client_GB.Controls.Add(this.Email_Txt_Box);
            this.Client_GB.Controls.Add(this.label11);
            this.Client_GB.Controls.Add(this.Fax_Txt_Box);
            this.Client_GB.Controls.Add(this.label9);
            this.Client_GB.Controls.Add(this.Work_Num_Txt_Box);
            this.Client_GB.Controls.Add(this.label8);
            this.Client_GB.Controls.Add(this.Mob_Num_Txt_Box);
            this.Client_GB.Controls.Add(this.label7);
            this.Client_GB.Controls.Add(this.Name_Txt_Box);
            this.Client_GB.Controls.Add(this.label6);
            this.Client_GB.Controls.Add(this.ID_Txt_Box);
            this.Client_GB.Controls.Add(this.label4);
            this.Client_GB.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Client_GB.ForeColor = System.Drawing.Color.Crimson;
            this.Client_GB.Location = new System.Drawing.Point(552, 215);
            this.Client_GB.Name = "Client_GB";
            this.Client_GB.Size = new System.Drawing.Size(446, 422);
            this.Client_GB.TabIndex = 23;
            this.Client_GB.TabStop = false;
            this.Client_GB.Text = "Client\'s Data";
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
            // Upd_C_Btn
            // 
            this.Upd_C_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Upd_C_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Upd_C_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Upd_C_Btn.Location = new System.Drawing.Point(300, 350);
            this.Upd_C_Btn.Name = "Upd_C_Btn";
            this.Upd_C_Btn.Size = new System.Drawing.Size(128, 42);
            this.Upd_C_Btn.TabIndex = 38;
            this.Upd_C_Btn.Text = "Update";
            this.Upd_C_Btn.UseVisualStyleBackColor = false;
            this.Upd_C_Btn.Click += new System.EventHandler(this.Upd_C_Btn_Click);
            // 
            // Add_Client_Btn
            // 
            this.Add_Client_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Add_Client_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add_Client_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Add_Client_Btn.Location = new System.Drawing.Point(178, 350);
            this.Add_Client_Btn.Name = "Add_Client_Btn";
            this.Add_Client_Btn.Size = new System.Drawing.Size(116, 42);
            this.Add_Client_Btn.TabIndex = 37;
            this.Add_Client_Btn.Text = "Add";
            this.Add_Client_Btn.UseVisualStyleBackColor = false;
            this.Add_Client_Btn.Click += new System.EventHandler(this.Add_Client_Btn_Click);
            // 
            // Website_Txt_Box
            // 
            this.Website_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Website_Txt_Box.Location = new System.Drawing.Point(187, 294);
            this.Website_Txt_Box.Name = "Website_Txt_Box";
            this.Website_Txt_Box.Size = new System.Drawing.Size(241, 30);
            this.Website_Txt_Box.TabIndex = 36;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.SystemColors.Control;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(6, 295);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 29);
            this.label12.TabIndex = 35;
            this.label12.Text = "Website:";
            // 
            // Email_Txt_Box
            // 
            this.Email_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email_Txt_Box.Location = new System.Drawing.Point(187, 248);
            this.Email_Txt_Box.Name = "Email_Txt_Box";
            this.Email_Txt_Box.Size = new System.Drawing.Size(241, 30);
            this.Email_Txt_Box.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.SystemColors.Control;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(6, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(86, 29);
            this.label11.TabIndex = 33;
            this.label11.Text = "Email:";
            // 
            // Fax_Txt_Box
            // 
            this.Fax_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fax_Txt_Box.Location = new System.Drawing.Point(226, 203);
            this.Fax_Txt_Box.Name = "Fax_Txt_Box";
            this.Fax_Txt_Box.Size = new System.Drawing.Size(202, 30);
            this.Fax_Txt_Box.TabIndex = 32;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label9.Location = new System.Drawing.Point(3, 204);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(62, 29);
            this.label9.TabIndex = 31;
            this.label9.Text = "Fax:";
            // 
            // Work_Num_Txt_Box
            // 
            this.Work_Num_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Work_Num_Txt_Box.Location = new System.Drawing.Point(226, 161);
            this.Work_Num_Txt_Box.Name = "Work_Num_Txt_Box";
            this.Work_Num_Txt_Box.Size = new System.Drawing.Size(202, 30);
            this.Work_Num_Txt_Box.TabIndex = 30;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.Control;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label8.Location = new System.Drawing.Point(3, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(187, 29);
            this.label8.TabIndex = 29;
            this.label8.Text = "Work_Number:";
            // 
            // Mob_Num_Txt_Box
            // 
            this.Mob_Num_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mob_Num_Txt_Box.Location = new System.Drawing.Point(226, 117);
            this.Mob_Num_Txt_Box.Name = "Mob_Num_Txt_Box";
            this.Mob_Num_Txt_Box.Size = new System.Drawing.Size(202, 30);
            this.Mob_Num_Txt_Box.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Control;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(3, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 29);
            this.label7.TabIndex = 27;
            this.label7.Text = "Mobile_Number:";
            // 
            // Name_Txt_Box
            // 
            this.Name_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name_Txt_Box.Location = new System.Drawing.Point(226, 78);
            this.Name_Txt_Box.Name = "Name_Txt_Box";
            this.Name_Txt_Box.Size = new System.Drawing.Size(202, 30);
            this.Name_Txt_Box.TabIndex = 26;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(3, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 29);
            this.label6.TabIndex = 25;
            this.label6.Text = "Name:";
            // 
            // ID_Txt_Box
            // 
            this.ID_Txt_Box.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID_Txt_Box.Location = new System.Drawing.Point(226, 39);
            this.ID_Txt_Box.Name = "ID_Txt_Box";
            this.ID_Txt_Box.Size = new System.Drawing.Size(202, 30);
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
            // Go_To_Data_Btn
            // 
            this.Go_To_Data_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Go_To_Data_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Go_To_Data_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Go_To_Data_Btn.Location = new System.Drawing.Point(575, 142);
            this.Go_To_Data_Btn.Name = "Go_To_Data_Btn";
            this.Go_To_Data_Btn.Size = new System.Drawing.Size(69, 36);
            this.Go_To_Data_Btn.TabIndex = 25;
            this.Go_To_Data_Btn.Text = ">>";
            this.Go_To_Data_Btn.UseVisualStyleBackColor = false;
            this.Go_To_Data_Btn.Click += new System.EventHandler(this.Go_To_Data_Btn_Click);
            // 
            // Client_Datagrid_View
            // 
            this.Client_Datagrid_View.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.Client_Datagrid_View.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.Client_Datagrid_View.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Client_Datagrid_View.BackgroundColor = System.Drawing.SystemColors.Control;
            this.Client_Datagrid_View.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Client_Datagrid_View.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Client_Datagrid_View.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.Client_Datagrid_View.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.Client_Datagrid_View.ColumnHeadersHeight = 30;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Client_Datagrid_View.DefaultCellStyle = dataGridViewCellStyle3;
            this.Client_Datagrid_View.EnableHeadersVisualStyles = false;
            this.Client_Datagrid_View.GridColor = System.Drawing.Color.Gray;
            this.Client_Datagrid_View.Location = new System.Drawing.Point(29, 254);
            this.Client_Datagrid_View.Name = "Client_Datagrid_View";
            this.Client_Datagrid_View.RowHeadersVisible = false;
            this.Client_Datagrid_View.RowHeadersWidth = 51;
            this.Client_Datagrid_View.RowTemplate.Height = 30;
            this.Client_Datagrid_View.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Client_Datagrid_View.Size = new System.Drawing.Size(479, 383);
            this.Client_Datagrid_View.TabIndex = 26;
            this.Client_Datagrid_View.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.Client_Datagrid_View.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.Client_Datagrid_View.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.Client_Datagrid_View.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.Client_Datagrid_View.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.Client_Datagrid_View.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.Client_Datagrid_View.ThemeStyle.BackColor = System.Drawing.SystemColors.Control;
            this.Client_Datagrid_View.ThemeStyle.GridColor = System.Drawing.Color.Gray;
            this.Client_Datagrid_View.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Teal;
            this.Client_Datagrid_View.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.Client_Datagrid_View.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Client_Datagrid_View.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.Client_Datagrid_View.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.Client_Datagrid_View.ThemeStyle.HeaderStyle.Height = 30;
            this.Client_Datagrid_View.ThemeStyle.ReadOnly = false;
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.Height = 30;
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.Client_Datagrid_View.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.Client_Datagrid_View.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Client_Datagrid_View_MouseClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(40, 201);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 36);
            this.label2.TabIndex = 27;
            this.label2.Text = "Clients List";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(381, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 47);
            this.label1.TabIndex = 0;
            this.label1.Text = "Inventory Managment System";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(472, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 49);
            this.label3.TabIndex = 2;
            this.label3.Text = "Manage Clients";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(157, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(39, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkCyan;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Exit_Btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-155, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1200, 126);
            this.panel1.TabIndex = 1;
            // 
            // Exit_Btn
            // 
            this.Exit_Btn.AutoSize = true;
            this.Exit_Btn.Font = new System.Drawing.Font("Century Gothic", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Btn.ForeColor = System.Drawing.SystemColors.Control;
            this.Exit_Btn.Location = new System.Drawing.Point(1149, 8);
            this.Exit_Btn.Name = "Exit_Btn";
            this.Exit_Btn.Size = new System.Drawing.Size(39, 39);
            this.Exit_Btn.TabIndex = 1;
            this.Exit_Btn.Text = "X";
            this.Exit_Btn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit_Btn.Click += new System.EventHandler(this.Exit_Btn_Click);
            // 
            // Display_All_Btn
            // 
            this.Display_All_Btn.BackColor = System.Drawing.Color.Crimson;
            this.Display_All_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Display_All_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Display_All_Btn.Location = new System.Drawing.Point(326, 201);
            this.Display_All_Btn.Name = "Display_All_Btn";
            this.Display_All_Btn.Size = new System.Drawing.Size(158, 36);
            this.Display_All_Btn.TabIndex = 28;
            this.Display_All_Btn.Text = "Display All";
            this.Display_All_Btn.UseVisualStyleBackColor = false;
            this.Display_All_Btn.Click += new System.EventHandler(this.Display_All_Btn_Click);
            // 
            // ManageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1039, 690);
            this.Controls.Add(this.Display_All_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Client_Datagrid_View);
            this.Controls.Add(this.Go_To_Data_Btn);
            this.Controls.Add(this.Client_GB);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ManageClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User_Application";
            this.Load += new System.EventHandler(this.User_Application_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.Client_GB.ResumeLayout(false);
            this.Client_GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Client_Datagrid_View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox Client_GB;
        private System.Windows.Forms.TextBox Website_Txt_Box;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Email_Txt_Box;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Fax_Txt_Box;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Work_Num_Txt_Box;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Mob_Num_Txt_Box;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Name_Txt_Box;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ID_Txt_Box;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Go_To_Data_Btn;
        private System.Windows.Forms.Button Add_Client_Btn;
        private System.Windows.Forms.Button Add_Btn;
        private System.Windows.Forms.Button Upd_C_Btn;
        private Guna.UI.WinForms.GunaDataGridView Client_Datagrid_View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Exit_Btn;
        private System.Windows.Forms.Button Display_All_Btn;
    }
}