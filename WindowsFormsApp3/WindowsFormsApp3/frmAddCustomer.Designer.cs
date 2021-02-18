namespace WindowsFormsApp3
{
    partial class frmAddCustomer
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
            this.txtBox_fn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBox_ln = new System.Windows.Forms.TextBox();
            this.txtBox_ct = new System.Windows.Forms.TextBox();
            this.txtBox_ph = new System.Windows.Forms.TextBox();
            this.txtBox_cntry = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firstname";
            // 
            // txtBox_fn
            // 
            this.txtBox_fn.Location = new System.Drawing.Point(88, 21);
            this.txtBox_fn.Name = "txtBox_fn";
            this.txtBox_fn.Size = new System.Drawing.Size(194, 22);
            this.txtBox_fn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Lastname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "City";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Country";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 137);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Phone";
            // 
            // txtBox_ln
            // 
            this.txtBox_ln.Location = new System.Drawing.Point(88, 50);
            this.txtBox_ln.Name = "txtBox_ln";
            this.txtBox_ln.Size = new System.Drawing.Size(194, 22);
            this.txtBox_ln.TabIndex = 6;
            // 
            // txtBox_ct
            // 
            this.txtBox_ct.Location = new System.Drawing.Point(88, 79);
            this.txtBox_ct.Name = "txtBox_ct";
            this.txtBox_ct.Size = new System.Drawing.Size(194, 22);
            this.txtBox_ct.TabIndex = 7;
            // 
            // txtBox_ph
            // 
            this.txtBox_ph.Location = new System.Drawing.Point(88, 137);
            this.txtBox_ph.Name = "txtBox_ph";
            this.txtBox_ph.Size = new System.Drawing.Size(194, 22);
            this.txtBox_ph.TabIndex = 8;
            // 
            // txtBox_cntry
            // 
            this.txtBox_cntry.Location = new System.Drawing.Point(88, 108);
            this.txtBox_cntry.Name = "txtBox_cntry";
            this.txtBox_cntry.Size = new System.Drawing.Size(194, 22);
            this.txtBox_cntry.TabIndex = 9;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(137, 176);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 10;
            this.btn_save.Text = "Add";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmAddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 247);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txtBox_cntry);
            this.Controls.Add(this.txtBox_ph);
            this.Controls.Add(this.txtBox_ct);
            this.Controls.Add(this.txtBox_ln);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBox_fn);
            this.Controls.Add(this.label1);
            this.Name = "frmAddCustomer";
            this.Text = "frmAdd";
            //this.Load += new System.EventHandler(this.frmAddCustomer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBox_fn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBox_ln;
        private System.Windows.Forms.TextBox txtBox_ct;
        private System.Windows.Forms.TextBox txtBox_ph;
        private System.Windows.Forms.TextBox txtBox_cntry;
        private System.Windows.Forms.Button btn_save;
    }
}