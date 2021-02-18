namespace WindowsFormsApp3
{
    partial class frmAddSupplier
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
            this.button_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_fax = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_title = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_contName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1_country = new System.Windows.Forms.TextBox();
            this.textBox2_city = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(207, 297);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 28);
            this.button_add.TabIndex = 20;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 235);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Fax:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 161);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "City:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 198);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Phone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 124);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Country:";
            // 
            // textBox_fax
            // 
            this.textBox_fax.Location = new System.Drawing.Point(132, 235);
            this.textBox_fax.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_fax.Name = "textBox_fax";
            this.textBox_fax.Size = new System.Drawing.Size(191, 22);
            this.textBox_fax.TabIndex = 12;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(132, 198);
            this.textBox_phone.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(191, 22);
            this.textBox_phone.TabIndex = 13;
            // 
            // textBox_title
            // 
            this.textBox_title.Location = new System.Drawing.Point(132, 87);
            this.textBox_title.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_title.Name = "textBox_title";
            this.textBox_title.Size = new System.Drawing.Size(324, 22);
            this.textBox_title.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 87);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Contact Title:";
            // 
            // textBox_contName
            // 
            this.textBox_contName.Location = new System.Drawing.Point(132, 50);
            this.textBox_contName.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_contName.Name = "textBox_contName";
            this.textBox_contName.Size = new System.Drawing.Size(324, 22);
            this.textBox_contName.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contact Name:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(132, 13);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(324, 22);
            this.textBox_name.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 11;
            this.label1.Text = "Company Name:";
            // 
            // textBox1_country
            // 
            this.textBox1_country.Location = new System.Drawing.Point(132, 124);
            this.textBox1_country.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1_country.Name = "textBox1_country";
            this.textBox1_country.Size = new System.Drawing.Size(324, 22);
            this.textBox1_country.TabIndex = 21;
            // 
            // textBox2_city
            // 
            this.textBox2_city.Location = new System.Drawing.Point(132, 161);
            this.textBox2_city.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2_city.Name = "textBox2_city";
            this.textBox2_city.Size = new System.Drawing.Size(324, 22);
            this.textBox2_city.TabIndex = 22;
            // 
            // frmAddSupplier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 374);
            this.Controls.Add(this.textBox2_city);
            this.Controls.Add(this.textBox1_country);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_fax);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_title);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_contName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "frmAddSupplier";
            this.Text = "frmAddSupplier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_fax;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_title;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_contName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1_country;
        private System.Windows.Forms.TextBox textBox2_city;
    }
}