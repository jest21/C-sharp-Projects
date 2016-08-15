namespace employee_sal
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtsal = new System.Windows.Forms.TextBox();
            this.chkda = new System.Windows.Forms.CheckBox();
            this.chkhr = new System.Windows.Forms.CheckBox();
            this.chkins = new System.Windows.Forms.CheckBox();
            this.chkea = new System.Windows.Forms.CheckBox();
            this.btncalc = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter employee id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Enter employee name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Basic Salary";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(178, 40);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 4;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(178, 94);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(100, 20);
            this.txtname.TabIndex = 5;
            // 
            // txtsal
            // 
            this.txtsal.Location = new System.Drawing.Point(178, 140);
            this.txtsal.Name = "txtsal";
            this.txtsal.Size = new System.Drawing.Size(100, 20);
            this.txtsal.TabIndex = 6;
            this.txtsal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // chkda
            // 
            this.chkda.AutoSize = true;
            this.chkda.Location = new System.Drawing.Point(13, 19);
            this.chkda.Name = "chkda";
            this.chkda.Size = new System.Drawing.Size(123, 17);
            this.chkda.TabIndex = 7;
            this.chkda.Text = "Dearness Allowance";
            this.chkda.UseVisualStyleBackColor = true;
            // 
            // chkhr
            // 
            this.chkhr.AutoSize = true;
            this.chkhr.Location = new System.Drawing.Point(140, 22);
            this.chkhr.Name = "chkhr";
            this.chkhr.Size = new System.Drawing.Size(94, 17);
            this.chkhr.TabIndex = 8;
            this.chkhr.Text = "HR Allowance";
            this.chkhr.UseVisualStyleBackColor = true;
            // 
            // chkins
            // 
            this.chkins.AutoSize = true;
            this.chkins.Location = new System.Drawing.Point(253, 22);
            this.chkins.Name = "chkins";
            this.chkins.Size = new System.Drawing.Size(73, 17);
            this.chkins.TabIndex = 9;
            this.chkins.Text = "Insurence";
            this.chkins.UseVisualStyleBackColor = true;
            // 
            // chkea
            // 
            this.chkea.AutoSize = true;
            this.chkea.Location = new System.Drawing.Point(349, 22);
            this.chkea.Name = "chkea";
            this.chkea.Size = new System.Drawing.Size(134, 17);
            this.chkea.TabIndex = 10;
            this.chkea.Text = "Educational Allowance";
            this.chkea.UseVisualStyleBackColor = true;
            // 
            // btncalc
            // 
            this.btncalc.Location = new System.Drawing.Point(37, 278);
            this.btncalc.Name = "btncalc";
            this.btncalc.Size = new System.Drawing.Size(75, 23);
            this.btncalc.TabIndex = 11;
            this.btncalc.Text = "Calculate";
            this.btncalc.UseVisualStyleBackColor = true;
            this.btncalc.Click += new System.EventHandler(this.btncalc_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(185, 278);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(75, 23);
            this.btnclear.TabIndex = 12;
            this.btnclear.Text = "Clear";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(338, 278);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(75, 23);
            this.btnexit.TabIndex = 13;
            this.btnexit.Text = "Exit";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 360);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Net Salary";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(178, 353);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(100, 20);
            this.txttotal.TabIndex = 15;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkda);
            this.groupBox1.Controls.Add(this.chkhr);
            this.groupBox1.Controls.Add(this.chkins);
            this.groupBox1.Controls.Add(this.chkea);
            this.groupBox1.Location = new System.Drawing.Point(12, 190);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(533, 68);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Allowances";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(571, 441);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btncalc);
            this.Controls.Add(this.txtsal);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.TextBox txtsal;
        private System.Windows.Forms.CheckBox chkda;
        private System.Windows.Forms.CheckBox chkhr;
        private System.Windows.Forms.CheckBox chkins;
        private System.Windows.Forms.CheckBox chkea;
        private System.Windows.Forms.Button btncalc;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

