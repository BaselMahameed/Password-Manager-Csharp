namespace Confidante.Forms
{
    partial class Validation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Validation));
            this.MasterPassword = new System.Windows.Forms.Label();
            this.FillPass = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.UserName = new System.Windows.Forms.Label();
            this.FillUser = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Valid = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // MasterPassword
            // 
            this.MasterPassword.AutoSize = true;
            this.MasterPassword.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasterPassword.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MasterPassword.Location = new System.Drawing.Point(20, 151);
            this.MasterPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MasterPassword.Name = "MasterPassword";
            this.MasterPassword.Size = new System.Drawing.Size(174, 43);
            this.MasterPassword.TabIndex = 0;
            this.MasterPassword.Text = "Master Password";
            // 
            // FillPass
            // 
            this.FillPass.Location = new System.Drawing.Point(202, 153);
            this.FillPass.Margin = new System.Windows.Forms.Padding(4);
            this.FillPass.Name = "FillPass";
            this.FillPass.PasswordChar = '*';
            this.FillPass.Size = new System.Drawing.Size(255, 22);
            this.FillPass.TabIndex = 1;
            // 
            // Submit
            // 
            this.Submit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Submit.Location = new System.Drawing.Point(398, 203);
            this.Submit.Margin = new System.Windows.Forms.Padding(4);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(115, 36);
            this.Submit.TabIndex = 2;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Uighur", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.UserName.Location = new System.Drawing.Point(13, 98);
            this.UserName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(183, 43);
            this.UserName.TabIndex = 3;
            this.UserName.Text = "Master Username";
            // 
            // FillUser
            // 
            this.FillUser.Location = new System.Drawing.Point(202, 108);
            this.FillUser.Margin = new System.Windows.Forms.Padding(4);
            this.FillUser.Name = "FillUser";
            this.FillUser.Size = new System.Drawing.Size(255, 22);
            this.FillUser.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(465, 153);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 27);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Valid
            // 
            this.Valid.AutoSize = true;
            this.Valid.Font = new System.Drawing.Font("Microsoft Uighur", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Valid.Location = new System.Drawing.Point(107, 36);
            this.Valid.Name = "Valid";
            this.Valid.Size = new System.Drawing.Size(320, 34);
            this.Valid.TabIndex = 20;
            this.Valid.Text = "Just Making Sure It\'s Really You ^_^";
            // 
            // Validation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.ClientSize = new System.Drawing.Size(569, 273);
            this.Controls.Add(this.Valid);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FillUser);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.FillPass);
            this.Controls.Add(this.MasterPassword);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Validation";
            this.Text = "Validation";
            this.Load += new System.EventHandler(this.Validation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label MasterPassword;
        private System.Windows.Forms.TextBox FillPass;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.TextBox FillUser;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Valid;
    }
}