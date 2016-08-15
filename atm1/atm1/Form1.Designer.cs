namespace atm1
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
            this.okbtn = new System.Windows.Forms.Button();
            this.pin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.quitrad = new System.Windows.Forms.RadioButton();
            this.depositrad = new System.Windows.Forms.RadioButton();
            this.withdrawrad = new System.Windows.Forms.RadioButton();
            this.balrad = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // okbtn
            // 
            this.okbtn.Location = new System.Drawing.Point(339, 399);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(118, 31);
            this.okbtn.TabIndex = 27;
            this.okbtn.Text = "OK";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // pin
            // 
            this.pin.Location = new System.Drawing.Point(339, 100);
            this.pin.Name = "pin";
            this.pin.Size = new System.Drawing.Size(100, 20);
            this.pin.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(117, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 25;
            this.label3.Text = "Enter your pin number";
            // 
            // quitrad
            // 
            this.quitrad.AutoSize = true;
            this.quitrad.Location = new System.Drawing.Point(140, 349);
            this.quitrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.quitrad.Name = "quitrad";
            this.quitrad.Size = new System.Drawing.Size(56, 17);
            this.quitrad.TabIndex = 24;
            this.quitrad.TabStop = true;
            this.quitrad.Text = "4. Quit";
            this.quitrad.UseVisualStyleBackColor = true;
            // 
            // depositrad
            // 
            this.depositrad.AutoSize = true;
            this.depositrad.Location = new System.Drawing.Point(140, 313);
            this.depositrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.depositrad.Name = "depositrad";
            this.depositrad.Size = new System.Drawing.Size(100, 17);
            this.depositrad.TabIndex = 23;
            this.depositrad.TabStop = true;
            this.depositrad.Text = "3. Deposit Cash";
            this.depositrad.UseVisualStyleBackColor = true;
            // 
            // withdrawrad
            // 
            this.withdrawrad.AutoSize = true;
            this.withdrawrad.Location = new System.Drawing.Point(140, 278);
            this.withdrawrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.withdrawrad.Name = "withdrawrad";
            this.withdrawrad.Size = new System.Drawing.Size(109, 17);
            this.withdrawrad.TabIndex = 22;
            this.withdrawrad.TabStop = true;
            this.withdrawrad.Text = "2. Withdraw Cash";
            this.withdrawrad.UseVisualStyleBackColor = true;
            // 
            // balrad
            // 
            this.balrad.AutoSize = true;
            this.balrad.Location = new System.Drawing.Point(140, 242);
            this.balrad.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.balrad.Name = "balrad";
            this.balrad.Size = new System.Drawing.Size(110, 17);
            this.balrad.TabIndex = 21;
            this.balrad.Text = "1. Check Balance";
            this.balrad.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(132, 199);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "Enter your choice";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(474, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "********Welcome to ATM Service**************";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 449);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.pin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.quitrad);
            this.Controls.Add(this.depositrad);
            this.Controls.Add(this.withdrawrad);
            this.Controls.Add(this.balrad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.TextBox pin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton quitrad;
        private System.Windows.Forms.RadioButton depositrad;
        private System.Windows.Forms.RadioButton withdrawrad;
        private System.Windows.Forms.RadioButton balrad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

