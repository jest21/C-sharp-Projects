namespace atm1
{
    partial class withdraw
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
            this.wbal = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.currentbal = new System.Windows.Forms.TextBox();
            this.txtwithdraw = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(277, 247);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(107, 32);
            this.cancel.TabIndex = 17;
            this.cancel.Text = "Cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // wbal
            // 
            this.wbal.Location = new System.Drawing.Point(277, 124);
            this.wbal.Name = "wbal";
            this.wbal.Size = new System.Drawing.Size(107, 30);
            this.wbal.TabIndex = 16;
            this.wbal.Text = "OK";
            this.wbal.UseVisualStyleBackColor = true;
            this.wbal.Click += new System.EventHandler(this.wbal_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 198);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Your current balance is ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // currentbal
            // 
            this.currentbal.Enabled = false;
            this.currentbal.Location = new System.Drawing.Point(277, 198);
            this.currentbal.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.currentbal.Name = "currentbal";
            this.currentbal.Size = new System.Drawing.Size(107, 20);
            this.currentbal.TabIndex = 14;
            this.currentbal.TextChanged += new System.EventHandler(this.currentbal_TextChanged);
            // 
            // txtwithdraw
            // 
            this.txtwithdraw.Location = new System.Drawing.Point(277, 68);
            this.txtwithdraw.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtwithdraw.Name = "txtwithdraw";
            this.txtwithdraw.Size = new System.Drawing.Size(107, 20);
            this.txtwithdraw.TabIndex = 13;
            this.txtwithdraw.TextChanged += new System.EventHandler(this.txtwithdraw_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Enter the amount to be withdrawn";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // withdraw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 346);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.wbal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.currentbal);
            this.Controls.Add(this.txtwithdraw);
            this.Controls.Add(this.label1);
            this.Name = "withdraw";
            this.Text = "withdraw";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Button wbal;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox currentbal;
        private System.Windows.Forms.TextBox txtwithdraw;
        private System.Windows.Forms.Label label1;
    }
}