namespace atm1
{
    partial class deposit
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
            this.cancel = new System.Windows.Forms.Button();
            this.depositbtn = new System.Windows.Forms.Button();
            this.curbalance = new System.Windows.Forms.TextBox();
            this.txtdeposit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(284, 259);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(91, 37);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // depositbtn
            // 
            this.depositbtn.Location = new System.Drawing.Point(284, 143);
            this.depositbtn.Name = "depositbtn";
            this.depositbtn.Size = new System.Drawing.Size(91, 34);
            this.depositbtn.TabIndex = 16;
            this.depositbtn.Text = "OK";
            this.depositbtn.UseVisualStyleBackColor = true;
            this.depositbtn.Click += new System.EventHandler(this.depositbtn_Click);
            // 
            // curbalance
            // 
            this.curbalance.Enabled = false;
            this.curbalance.Location = new System.Drawing.Point(284, 213);
            this.curbalance.Name = "curbalance";
            this.curbalance.Size = new System.Drawing.Size(100, 20);
            this.curbalance.TabIndex = 15;
            // 
            // txtdeposit
            // 
            this.txtdeposit.Location = new System.Drawing.Point(284, 95);
            this.txtdeposit.Name = "txtdeposit";
            this.txtdeposit.Size = new System.Drawing.Size(100, 20);
            this.txtdeposit.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Simple Indust Outline", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(84, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 21);
            this.label2.TabIndex = 13;
            this.label2.Text = "Your current balance";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Simple Indust Shaded", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(55, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 21);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the amount to be deposited";
            // 
            // deposit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 391);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.depositbtn);
            this.Controls.Add(this.curbalance);
            this.Controls.Add(this.txtdeposit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "deposit";
            this.Text = "deposit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button depositbtn;
        private System.Windows.Forms.TextBox curbalance;
        private System.Windows.Forms.TextBox txtdeposit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}