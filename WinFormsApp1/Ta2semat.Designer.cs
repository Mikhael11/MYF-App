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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ta2semat));
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.txtraba = new System.Windows.Forms.TextBox();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.listBox6 = new System.Windows.Forms.ListBox();
            this.listBox7 = new System.Windows.Forms.ListBox();
            this.listBox8 = new System.Windows.Forms.ListBox();
            this.ADD = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ComboBox1 = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnpush = new Guna.UI2.WinForms.Guna2Button();
            this.btnpuzzle = new Guna.UI2.WinForms.Guna2Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(35, 102);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(186, 274);
            this.listBox1.TabIndex = 0;
            // 
            // txtraba
            // 
            this.txtraba.Location = new System.Drawing.Point(36, 56);
            this.txtraba.Name = "txtraba";
            this.txtraba.PlaceholderText = "الاسم";
            this.txtraba.Size = new System.Drawing.Size(162, 23);
            this.txtraba.TabIndex = 4;
            this.txtraba.TextChanged += new System.EventHandler(this.txtraba_TextChanged);
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.ItemHeight = 15;
            this.listBox5.Location = new System.Drawing.Point(626, 493);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(162, 184);
            this.listBox5.TabIndex = 12;
            this.listBox5.SelectedIndexChanged += new System.EventHandler(this.listBox5_SelectedIndexChanged);
            // 
            // listBox6
            // 
            this.listBox6.FormattingEnabled = true;
            this.listBox6.ItemHeight = 15;
            this.listBox6.Location = new System.Drawing.Point(427, 493);
            this.listBox6.Name = "listBox6";
            this.listBox6.Size = new System.Drawing.Size(162, 184);
            this.listBox6.TabIndex = 11;
            // 
            // listBox7
            // 
            this.listBox7.FormattingEnabled = true;
            this.listBox7.ItemHeight = 15;
            this.listBox7.Location = new System.Drawing.Point(233, 493);
            this.listBox7.Name = "listBox7";
            this.listBox7.Size = new System.Drawing.Size(162, 184);
            this.listBox7.TabIndex = 10;
            // 
            // listBox8
            // 
            this.listBox8.FormattingEnabled = true;
            this.listBox8.ItemHeight = 15;
            this.listBox8.Location = new System.Drawing.Point(36, 493);
            this.listBox8.Name = "listBox8";
            this.listBox8.Size = new System.Drawing.Size(162, 184);
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
            this.guna2ComboBox1.Location = new System.Drawing.Point(35, 10);
            this.guna2ComboBox1.Name = "guna2ComboBox1";
            this.guna2ComboBox1.Size = new System.Drawing.Size(163, 36);
            this.guna2ComboBox1.TabIndex = 14;
            this.guna2ComboBox1.SelectedIndexChanged += new System.EventHandler(this.guna2ComboBox1_SelectedIndexChanged);
            // 
            // btnpush
            // 
            this.btnpush.BorderRadius = 26;
            this.btnpush.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpush.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpush.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpush.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpush.FillColor = System.Drawing.Color.SteelBlue;
            this.btnpush.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpush.ForeColor = System.Drawing.Color.White;
            this.btnpush.Location = new System.Drawing.Point(20, 435);
            this.btnpush.Name = "btnpush";
            this.btnpush.Size = new System.Drawing.Size(168, 41);
            this.btnpush.TabIndex = 15;
            this.btnpush.Text = "Push";
            this.btnpush.Click += new System.EventHandler(this.btnpush_Click);
            // 
            // btnpuzzle
            // 
            this.btnpuzzle.BorderRadius = 26;
            this.btnpuzzle.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnpuzzle.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnpuzzle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnpuzzle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnpuzzle.FillColor = System.Drawing.Color.Crimson;
            this.btnpuzzle.Font = new System.Drawing.Font("Verdana", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnpuzzle.ForeColor = System.Drawing.Color.White;
            this.btnpuzzle.Location = new System.Drawing.Point(444, 435);
            this.btnpuzzle.Name = "btnpuzzle";
            this.btnpuzzle.Size = new System.Drawing.Size(168, 41);
            this.btnpuzzle.TabIndex = 16;
            this.btnpuzzle.Text = "Puzzle";
            this.btnpuzzle.Click += new System.EventHandler(this.btnpuzzle_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 15;
            this.listBox2.Location = new System.Drawing.Point(256, 12);
            this.listBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(566, 364);
            this.listBox2.TabIndex = 17;
            // 
            // Ta2semat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 562);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.btnpuzzle);
            this.Controls.Add(this.btnpush);
            this.Controls.Add(this.guna2ComboBox1);
            this.Controls.Add(this.ADD);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.listBox6);
            this.Controls.Add(this.listBox7);
            this.Controls.Add(this.listBox8);
            this.Controls.Add(this.txtraba);
            this.Controls.Add(this.listBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Ta2semat";
            this.Text = "Ta2semat";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox listBox1;
        private TextBox txtraba;
        private ListBox listBox5;
        private ListBox listBox6;
        private ListBox listBox7;
        private ListBox listBox8;
        private Guna.UI2.WinForms.Guna2Button ADD;
        private Guna.UI2.WinForms.Guna2ComboBox guna2ComboBox1;
        private Guna.UI2.WinForms.Guna2Button btnpush;
        private Guna.UI2.WinForms.Guna2Button btnpuzzle;
        private ListBox listBox2;
    }
}