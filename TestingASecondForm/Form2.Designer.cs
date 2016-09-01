namespace TestingASecondForm
{
    partial class RegistrationForm
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
            this.EmailLabel = new System.Windows.Forms.Label();
            this.RegisterButton = new System.Windows.Forms.Button();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ConfirmationLabel = new System.Windows.Forms.Label();
            this.EmailTxtBox = new System.Windows.Forms.TextBox();
            this.PasswordTxtBox = new System.Windows.Forms.TextBox();
            this.ConfirmationTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.Location = new System.Drawing.Point(12, 31);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(85, 13);
            this.EmailLabel.TabIndex = 0;
            this.EmailLabel.Text = "Enter your email:";
            this.EmailLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(76, 133);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(109, 32);
            this.RegisterButton.TabIndex = 1;
            this.RegisterButton.Text = "Register";
            this.RegisterButton.UseVisualStyleBackColor = true;
            this.RegisterButton.Click += new System.EventHandler(this.RegisterButton_Click);
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(12, 71);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(92, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Enter a password:";
            // 
            // ConfirmationLabel
            // 
            this.ConfirmationLabel.AutoSize = true;
            this.ConfirmationLabel.Location = new System.Drawing.Point(12, 93);
            this.ConfirmationLabel.Name = "ConfirmationLabel";
            this.ConfirmationLabel.Size = new System.Drawing.Size(116, 13);
            this.ConfirmationLabel.TabIndex = 3;
            this.ConfirmationLabel.Text = "Confirm your password:";
            // 
            // EmailTxtBox
            // 
            this.EmailTxtBox.Location = new System.Drawing.Point(103, 28);
            this.EmailTxtBox.Name = "EmailTxtBox";
            this.EmailTxtBox.Size = new System.Drawing.Size(125, 20);
            this.EmailTxtBox.TabIndex = 4;
            // 
            // PasswordTxtBox
            // 
            this.PasswordTxtBox.Location = new System.Drawing.Point(131, 68);
            this.PasswordTxtBox.Name = "PasswordTxtBox";
            this.PasswordTxtBox.Size = new System.Drawing.Size(125, 20);
            this.PasswordTxtBox.TabIndex = 5;
            // 
            // ConfirmationTxtBox
            // 
            this.ConfirmationTxtBox.Location = new System.Drawing.Point(131, 90);
            this.ConfirmationTxtBox.Name = "ConfirmationTxtBox";
            this.ConfirmationTxtBox.Size = new System.Drawing.Size(125, 20);
            this.ConfirmationTxtBox.TabIndex = 6;
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 172);
            this.Controls.Add(this.ConfirmationTxtBox);
            this.Controls.Add(this.PasswordTxtBox);
            this.Controls.Add(this.EmailTxtBox);
            this.Controls.Add(this.ConfirmationLabel);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.EmailLabel);
            this.Name = "RegistrationForm";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLabel;
        private System.Windows.Forms.Button RegisterButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.Label ConfirmationLabel;
        private System.Windows.Forms.TextBox EmailTxtBox;
        private System.Windows.Forms.TextBox PasswordTxtBox;
        private System.Windows.Forms.TextBox ConfirmationTxtBox;
    }
}