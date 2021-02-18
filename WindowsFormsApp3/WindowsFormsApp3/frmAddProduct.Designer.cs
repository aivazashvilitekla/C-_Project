namespace WindowsFormsApp3
{
    partial class frmAddProduct
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
            this.checkBox_discontinued = new System.Windows.Forms.CheckBox();
            this.numericUpDown_price = new System.Windows.Forms.NumericUpDown();
            this.button_add = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.comboBox_supplier = new System.Windows.Forms.ComboBox();
            this.textBox_package = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).BeginInit();
            this.SuspendLayout();
            // 
            // checkBox_discontinued
            // 
            this.checkBox_discontinued.AutoSize = true;
            this.checkBox_discontinued.Location = new System.Drawing.Point(142, 188);
            this.checkBox_discontinued.Margin = new System.Windows.Forms.Padding(4);
            this.checkBox_discontinued.Name = "checkBox_discontinued";
            this.checkBox_discontinued.Size = new System.Drawing.Size(18, 17);
            this.checkBox_discontinued.TabIndex = 24;
            this.checkBox_discontinued.UseVisualStyleBackColor = true;
            // 
            // numericUpDown_price
            // 
            this.numericUpDown_price.DecimalPlaces = 3;
            this.numericUpDown_price.Location = new System.Drawing.Point(142, 111);
            this.numericUpDown_price.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDown_price.Name = "numericUpDown_price";
            this.numericUpDown_price.Size = new System.Drawing.Size(160, 22);
            this.numericUpDown_price.TabIndex = 32;
            // 
            // button_add
            // 
            this.button_add.Location = new System.Drawing.Point(202, 231);
            this.button_add.Margin = new System.Windows.Forms.Padding(4);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(100, 28);
            this.button_add.TabIndex = 31;
            this.button_add.Text = "Add";
            this.button_add.UseVisualStyleBackColor = true;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 184);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 17);
            this.label7.TabIndex = 25;
            this.label7.Text = "Discontinued:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 143);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 17);
            this.label6.TabIndex = 26;
            this.label6.Text = "Package:";
            // 
            // comboBox_supplier
            // 
            this.comboBox_supplier.FormattingEnabled = true;
            this.comboBox_supplier.Location = new System.Drawing.Point(142, 77);
            this.comboBox_supplier.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox_supplier.Name = "comboBox_supplier";
            this.comboBox_supplier.Size = new System.Drawing.Size(324, 24);
            this.comboBox_supplier.TabIndex = 30;
            // 
            // textBox_package
            // 
            this.textBox_package.Location = new System.Drawing.Point(142, 143);
            this.textBox_package.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_package.Name = "textBox_package";
            this.textBox_package.Size = new System.Drawing.Size(191, 22);
            this.textBox_package.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 27;
            this.label3.Text = "Unit Price:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 77);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Supplier:";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(142, 45);
            this.textBox_name.Margin = new System.Windows.Forms.Padding(4);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(324, 22);
            this.textBox_name.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 45);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Product Name:";
            // 
            // frmAddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox_discontinued);
            this.Controls.Add(this.numericUpDown_price);
            this.Controls.Add(this.button_add);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox_supplier);
            this.Controls.Add(this.textBox_package);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label1);
            this.Name = "frmAddProduct";
            this.Text = "frmAddProducts";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_discontinued;
        private System.Windows.Forms.NumericUpDown numericUpDown_price;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox_supplier;
        private System.Windows.Forms.TextBox textBox_package;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label label1;
    }
}