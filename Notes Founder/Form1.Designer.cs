
namespace Notes_Founder
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EmailTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ReasonTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.VerificationCB = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ActionTB = new System.Windows.Forms.TextBox();
            this.ResolutionTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.ExpectationTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.AInfoTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ClearButton = new System.Windows.Forms.Button();
            this.CopyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(214, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Foundever Notes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email:";
            // 
            // EmailTB
            // 
            this.EmailTB.Location = new System.Drawing.Point(16, 79);
            this.EmailTB.Name = "EmailTB";
            this.EmailTB.Size = new System.Drawing.Size(251, 22);
            this.EmailTB.TabIndex = 2;
            this.EmailTB.TextChanged += new System.EventHandler(this.EmailTB_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Verification Method:";
            // 
            // ReasonTB
            // 
            this.ReasonTB.Location = new System.Drawing.Point(16, 205);
            this.ReasonTB.Name = "ReasonTB";
            this.ReasonTB.Size = new System.Drawing.Size(418, 22);
            this.ReasonTB.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Call Reason:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // VerificationCB
            // 
            this.VerificationCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VerificationCB.FormattingEnabled = true;
            this.VerificationCB.Items.AddRange(new object[] {
            "SSBAPPCAM / SSSLFCAM",
            "SSBAPP",
            "New Customer",
            "Suspended / Expired / Cancelled Accounts",
            "SSEDSM2 / SSSAPP"});
            this.VerificationCB.Location = new System.Drawing.Point(16, 140);
            this.VerificationCB.Name = "VerificationCB";
            this.VerificationCB.Size = new System.Drawing.Size(251, 24);
            this.VerificationCB.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(5, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(458, 29);
            this.label5.TabIndex = 7;
            this.label5.Text = "*******RESOLUTION DETAILS********";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 277);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 8;
            this.label6.Text = "Action Taken:";
            // 
            // ActionTB
            // 
            this.ActionTB.Location = new System.Drawing.Point(16, 298);
            this.ActionTB.Multiline = true;
            this.ActionTB.Name = "ActionTB";
            this.ActionTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ActionTB.Size = new System.Drawing.Size(417, 64);
            this.ActionTB.TabIndex = 9;
            // 
            // ResolutionTB
            // 
            this.ResolutionTB.Location = new System.Drawing.Point(13, 399);
            this.ResolutionTB.Multiline = true;
            this.ResolutionTB.Name = "ResolutionTB";
            this.ResolutionTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ResolutionTB.Size = new System.Drawing.Size(417, 64);
            this.ResolutionTB.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 18);
            this.label7.TabIndex = 10;
            this.label7.Text = "Resolution:";
            // 
            // ExpectationTB
            // 
            this.ExpectationTB.Location = new System.Drawing.Point(13, 500);
            this.ExpectationTB.Multiline = true;
            this.ExpectationTB.Name = "ExpectationTB";
            this.ExpectationTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.ExpectationTB.Size = new System.Drawing.Size(417, 64);
            this.ExpectationTB.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 479);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 18);
            this.label8.TabIndex = 12;
            this.label8.Text = "Set Expectation:";
            // 
            // AInfoTB
            // 
            this.AInfoTB.Location = new System.Drawing.Point(12, 594);
            this.AInfoTB.Multiline = true;
            this.AInfoTB.Name = "AInfoTB";
            this.AInfoTB.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.AInfoTB.Size = new System.Drawing.Size(417, 44);
            this.AInfoTB.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(12, 573);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(103, 18);
            this.label9.TabIndex = 14;
            this.label9.Text = "Additional Info:";
            // 
            // ClearButton
            // 
            this.ClearButton.BackColor = System.Drawing.Color.White;
            this.ClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearButton.ForeColor = System.Drawing.Color.Black;
            this.ClearButton.Location = new System.Drawing.Point(64, 681);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(81, 40);
            this.ClearButton.TabIndex = 16;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = false;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // CopyButton
            // 
            this.CopyButton.BackColor = System.Drawing.Color.White;
            this.CopyButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyButton.ForeColor = System.Drawing.Color.Black;
            this.CopyButton.Location = new System.Drawing.Point(301, 681);
            this.CopyButton.Name = "CopyButton";
            this.CopyButton.Size = new System.Drawing.Size(81, 40);
            this.CopyButton.TabIndex = 17;
            this.CopyButton.Text = "Copy";
            this.CopyButton.UseVisualStyleBackColor = false;
            this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(466, 733);
            this.Controls.Add(this.CopyButton);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.AInfoTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ExpectationTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ResolutionTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ActionTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.VerificationCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ReasonTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.EmailTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Foundever Notes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EmailTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ReasonTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox VerificationCB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox ActionTB;
        private System.Windows.Forms.TextBox ResolutionTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ExpectationTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox AInfoTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Button CopyButton;
    }
}

