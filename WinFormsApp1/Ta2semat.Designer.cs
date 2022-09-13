namespace WinFormsApp1
{
    partial class Ta2semat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ta2semat));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtraba = new System.Windows.Forms.TextBox();
            this.guna2DataGridView1 = new Guna.UI2.WinForms.Guna2DataGridView();
            this.الاسم = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.السنة = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.ADD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(36, 141);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 274);
            this.listBox1.TabIndex = 0;
            // 
            // txtraba
            // 
            this.txtraba.Location = new System.Drawing.Point(36, 95);
            this.txtraba.Name = "txtraba";
            this.txtraba.PlaceholderText = "سنة رابعة و خامسة";
            this.txtraba.Size = new System.Drawing.Size(162, 23);
            this.txtraba.TabIndex = 4;
            this.txtraba.TextChanged += new System.EventHandler(this.txtraba_TextChanged);
            // 
            // guna2DataGridView1
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.guna2DataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.guna2DataGridView1.ColumnHeadersHeight = 17;
            this.guna2DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.الاسم,
            this.السنة});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.guna2DataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.guna2DataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.Location = new System.Drawing.Point(411, 12);
            this.guna2DataGridView1.Name = "guna2DataGridView1";
            this.guna2DataGridView1.RowHeadersVisible = false;
            this.guna2DataGridView1.RowTemplate.Height = 25;
            this.guna2DataGridView1.Size = new System.Drawing.Size(479, 398);
            this.guna2DataGridView1.TabIndex = 8;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.guna2DataGridView1.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.guna2DataGridView1.ThemeStyle.HeaderStyle.Height = 17;
            this.guna2DataGridView1.ThemeStyle.ReadOnly = false;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2DataGridView1.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.Height = 25;
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.guna2DataGridView1.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // الاسم
            // 
            this.الاسم.HeaderText = "السنة";
            this.الاسم.Name = "الاسم";
            // 
            // السنة
            // 
            this.السنة.HeaderText = "الاسم";
            this.السنة.Name = "السنة";
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(1344, 531);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(162, 259);
            this.listBox5.TabIndex = 12;
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 15;
            this.listBox6.Location = new System.Drawing.Point(845, 531);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(162, 259);
            this.listBox6.TabIndex = 11;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 15;
            this.listBox7.Location = new System.Drawing.Point(423, 531);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(162, 259);
            this.listBox7.TabIndex = 10;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 15;
            this.listBox8.Location = new System.Drawing.Point(36, 531);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(162, 259);
            this.listBox8.TabIndex = 9;
            // 
            // ADD
            // 
            this.ADD.BorderRadius = 26;
            this.ADD.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.ADD.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.ADD.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.ADD.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.ADD.FillColor = System.Drawing.Color.DarkSlateBlue;
            this.ADD.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ADD.ForeColor = System.Drawing.Color.White;
            this.ADD.Location = new System.Drawing.Point(210, 435);
            this.ADD.Name = "ADD";
            this.ADD.Size = new System.Drawing.Size(168, 41);
            this.ADD.TabIndex = 13;
            this.ADD.Text = "نزود حد جديد";
            this.ADD.Click += new System.EventHandler(this.ADD_Click);
            // 
            // guna2ComboBox1
            // 
            this.guna2ComboBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ComboBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.guna2ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.guna2ComboBox1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.guna2ComboBox1.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guna2ComboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.guna2ComboBox1.ItemHeight = 30;
            this.guna2ComboBox1.Items.AddRange(new object[] {
            "سنة اولى",
            "سنة تانية",
            "سنة تالتة",
            "سنة رابعة و خامسة"});
            this.guna2ComboBox1.Location = new System.Drawing.Point(36, 39);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(163, 36);
            this.guna2ComboBox1.TabIndex = 14;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // Ta2semat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1540, 812);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.guna2DataGridView1);
            this.Controls.Add(this.txtraba);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ta2semat";
            this.Text = "Ta2semat";
            ((System.ComponentModel.ISupportInitialize)(this.guna2DataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox txtraba;
        private Guna.UI2.WinForms.Guna2DataGridView guna2DataGridView1;
        private DataGridViewTextBoxColumn الاسم;
        private DataGridViewTextBoxColumn السنة;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
        private ListBox listBox8;
        private Guna.UI2.WinForms.Guna2Button ADD;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
    }
}