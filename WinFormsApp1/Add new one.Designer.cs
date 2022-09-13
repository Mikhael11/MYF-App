namespace MYF_APP
{
    partial class Add_new_one
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
            this.label5 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.btnAddone = new Guna.UI2.WinForms.Guna2Button();
            this.txtaddress = new System.Windows.Forms.TextBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtlev = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(165, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "السنة العمرية";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(551, 132);
            this.txtname.Multiline = true;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(212, 34);
            this.txtname.TabIndex = 17;
            // 
            // btnAddone
            // 
            this.btnAddone.BorderRadius = 15;
            this.btnAddone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddone.FillColor = System.Drawing.Color.LightCoral;
            this.btnAddone.Font = new System.Drawing.Font("MS Reference Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAddone.ForeColor = System.Drawing.Color.Black;
            this.btnAddone.Location = new System.Drawing.Point(347, 423);
            this.btnAddone.Name = "btnAddone";
            this.btnAddone.Size = new System.Drawing.Size(187, 42);
            this.btnAddone.TabIndex = 16;
            this.btnAddone.Text = "ADD";
            this.btnAddone.Click += new System.EventHandler(this.btnAddone_Click);
            // 
            // txtaddress
            // 
            this.txtaddress.Location = new System.Drawing.Point(122, 309);
            this.txtaddress.Multiline = true;
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Size = new System.Drawing.Size(212, 34);
            this.txtaddress.TabIndex = 15;
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(551, 309);
            this.txtnum.Multiline = true;
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(212, 34);
            this.txtnum.TabIndex = 14;
            // 
            // txtlev
            // 
            this.txtlev.BackColor = System.Drawing.Color.Transparent;
            this.txtlev.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.txtlev.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.txtlev.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlev.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtlev.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtlev.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.txtlev.ItemHeight = 30;
            this.txtlev.Items.AddRange(new object[] {
            "سنة اولى",
            "سنة تانية",
            "سنة تالتة",
            "سنة رابعة و خامسة"});
            this.txtlev.Location = new System.Drawing.Point(122, 132);
            this.txtlev.Name = "txtlev";
            this.txtlev.Size = new System.Drawing.Size(212, 36);
            this.txtlev.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.txtlev.TabIndex = 13;
            this.txtlev.SelectedIndexChanged += new System.EventHandler(this.txtCatg_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(201, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 21);
            this.label3.TabIndex = 12;
            this.label3.Text = "العنوان";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(640, 276);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 21);
            this.label2.TabIndex = 11;
            this.label2.Text = "الرقم";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(640, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "الأسم";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Add_new_one
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 551);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.btnAddone);
            this.Controls.Add(this.txtaddress);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.txtlev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Add_new_one";
            this.Text = "Add_new_one";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label5;
        private TextBox txtname;
        private Guna.UI2.WinForms.Guna2Button btnAddone;
        private TextBox txtaddress;
        private TextBox txtnum;
        private Guna.UI2.WinForms.Guna2ComboBox txtlev;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}