namespace Confidante.Forms
{
    partial class EditPasswords
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditPasswords));
            this.BackGround = new System.Windows.Forms.Panel();
            this.ShowHide = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Generate = new System.Windows.Forms.Button();
            this.FillWebName = new System.Windows.Forms.TextBox();
            this.FillURL = new System.Windows.Forms.TextBox();
            this.FillPass = new System.Windows.Forms.TextBox();
            this.FillEmail = new System.Windows.Forms.TextBox();
            this.FillUser = new System.Windows.Forms.TextBox();
            this.AddWebName = new System.Windows.Forms.Label();
            this.AddEmail = new System.Windows.Forms.Label();
            this.AddPass = new System.Windows.Forms.Label();
            this.URL = new System.Windows.Forms.Label();
            this.AddUserName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SelectData = new System.Windows.Forms.Button();
            this.BackGround.SuspendLayout();
            this.SuspendLayout();
            // 
            // BackGround
            // 
            this.BackGround.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BackGround.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.BackGround.Controls.Add(this.SelectData);
            this.BackGround.Controls.Add(this.panel4);
            this.BackGround.Controls.Add(this.panel3);
            this.BackGround.Controls.Add(this.panel5);
            this.BackGround.Controls.Add(this.panel2);
            this.BackGround.Controls.Add(this.panel1);
            this.BackGround.Controls.Add(this.ShowHide);
            this.BackGround.Controls.Add(this.Save);
            this.BackGround.Controls.Add(this.Generate);
            this.BackGround.Controls.Add(this.FillWebName);
            this.BackGround.Controls.Add(this.FillURL);
            this.BackGround.Controls.Add(this.FillPass);
            this.BackGround.Controls.Add(this.FillEmail);
            this.BackGround.Controls.Add(this.FillUser);
            this.BackGround.Controls.Add(this.AddWebName);
            this.BackGround.Controls.Add(this.AddEmail);
            this.BackGround.Controls.Add(this.AddPass);
            this.BackGround.Controls.Add(this.URL);
            this.BackGround.Controls.Add(this.AddUserName);
            this.BackGround.Location = new System.Drawing.Point(0, 0);
            this.BackGround.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.BackGround.Name = "BackGround";
            this.BackGround.Size = new System.Drawing.Size(392, 366);
            this.BackGround.TabIndex = 2;
            this.BackGround.Paint += new System.Windows.Forms.PaintEventHandler(this.BackGround_Paint);
            // 
            // ShowHide
            // 
            this.ShowHide.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ShowHide.BackgroundImage")));
            this.ShowHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowHide.Location = new System.Drawing.Point(331, 121);
            this.ShowHide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ShowHide.Name = "ShowHide";
            this.ShowHide.Size = new System.Drawing.Size(18, 20);
            this.ShowHide.TabIndex = 12;
            this.ShowHide.UseVisualStyleBackColor = true;
            this.ShowHide.Click += new System.EventHandler(this.ShowHide_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Gainsboro;
            this.Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.Save.Location = new System.Drawing.Point(265, 320);
            this.Save.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(116, 25);
            this.Save.TabIndex = 11;
            this.Save.Text = "Save Edit :D";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Generate
            // 
            this.Generate.BackColor = System.Drawing.Color.Gainsboro;
            this.Generate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.Generate.Location = new System.Drawing.Point(19, 166);
            this.Generate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Generate.Name = "Generate";
            this.Generate.Size = new System.Drawing.Size(108, 25);
            this.Generate.TabIndex = 10;
            this.Generate.Text = "Generate Password!";
            this.Generate.UseVisualStyleBackColor = false;
            this.Generate.Click += new System.EventHandler(this.Generate_Click);
            // 
            // FillWebName
            // 
            this.FillWebName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.FillWebName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillWebName.ForeColor = System.Drawing.SystemColors.Window;
            this.FillWebName.Location = new System.Drawing.Point(149, 267);
            this.FillWebName.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillWebName.Name = "FillWebName";
            this.FillWebName.Size = new System.Drawing.Size(196, 13);
            this.FillWebName.TabIndex = 9;
            // 
            // FillURL
            // 
            this.FillURL.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.FillURL.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillURL.ForeColor = System.Drawing.SystemColors.Window;
            this.FillURL.Location = new System.Drawing.Point(86, 221);
            this.FillURL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillURL.Name = "FillURL";
            this.FillURL.Size = new System.Drawing.Size(259, 13);
            this.FillURL.TabIndex = 8;
            // 
            // FillPass
            // 
            this.FillPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.FillPass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillPass.ForeColor = System.Drawing.SystemColors.Window;
            this.FillPass.Location = new System.Drawing.Point(108, 125);
            this.FillPass.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillPass.Name = "FillPass";
            this.FillPass.PasswordChar = '*';
            this.FillPass.Size = new System.Drawing.Size(219, 13);
            this.FillPass.TabIndex = 7;
            // 
            // FillEmail
            // 
            this.FillEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.FillEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillEmail.ForeColor = System.Drawing.SystemColors.Window;
            this.FillEmail.Location = new System.Drawing.Point(86, 78);
            this.FillEmail.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillEmail.Name = "FillEmail";
            this.FillEmail.Size = new System.Drawing.Size(251, 13);
            this.FillEmail.TabIndex = 6;
            // 
            // FillUser
            // 
            this.FillUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.FillUser.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FillUser.ForeColor = System.Drawing.SystemColors.Window;
            this.FillUser.Location = new System.Drawing.Point(110, 30);
            this.FillUser.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.FillUser.Name = "FillUser";
            this.FillUser.Size = new System.Drawing.Size(235, 13);
            this.FillUser.TabIndex = 5;
            // 
            // AddWebName
            // 
            this.AddWebName.AutoSize = true;
            this.AddWebName.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddWebName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddWebName.Image = ((System.Drawing.Image)(resources.GetObject("AddWebName.Image")));
            this.AddWebName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddWebName.Location = new System.Drawing.Point(14, 257);
            this.AddWebName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddWebName.Name = "AddWebName";
            this.AddWebName.Size = new System.Drawing.Size(131, 25);
            this.AddWebName.TabIndex = 4;
            this.AddWebName.Text = "         Website\'s Name:";
            this.AddWebName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddEmail
            // 
            this.AddEmail.AutoSize = true;
            this.AddEmail.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddEmail.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddEmail.Image = ((System.Drawing.Image)(resources.GetObject("AddEmail.Image")));
            this.AddEmail.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddEmail.Location = new System.Drawing.Point(9, 68);
            this.AddEmail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddEmail.Name = "AddEmail";
            this.AddEmail.Size = new System.Drawing.Size(75, 25);
            this.AddEmail.TabIndex = 3;
            this.AddEmail.Text = "         Email:";
            this.AddEmail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddPass
            // 
            this.AddPass.AutoSize = true;
            this.AddPass.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddPass.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddPass.Image = ((System.Drawing.Image)(resources.GetObject("AddPass.Image")));
            this.AddPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPass.Location = new System.Drawing.Point(9, 115);
            this.AddPass.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddPass.Name = "AddPass";
            this.AddPass.Size = new System.Drawing.Size(95, 25);
            this.AddPass.TabIndex = 2;
            this.AddPass.Text = "         Password:";
            this.AddPass.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // URL
            // 
            this.URL.AutoSize = true;
            this.URL.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.URL.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.URL.Image = ((System.Drawing.Image)(resources.GetObject("URL.Image")));
            this.URL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.URL.Location = new System.Drawing.Point(14, 211);
            this.URL.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.URL.Name = "URL";
            this.URL.Size = new System.Drawing.Size(68, 25);
            this.URL.TabIndex = 1;
            this.URL.Text = "         URL:";
            this.URL.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddUserName
            // 
            this.AddUserName.AutoSize = true;
            this.AddUserName.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddUserName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.AddUserName.Image = ((System.Drawing.Image)(resources.GetObject("AddUserName.Image")));
            this.AddUserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddUserName.Location = new System.Drawing.Point(9, 25);
            this.AddUserName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.AddUserName.Name = "AddUserName";
            this.AddUserName.Size = new System.Drawing.Size(101, 25);
            this.AddUserName.TabIndex = 0;
            this.AddUserName.Text = "         UserName:";
            this.AddUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(19, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(330, 1);
            this.panel1.TabIndex = 17;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(19, 92);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 1);
            this.panel2.TabIndex = 18;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.White;
            this.panel5.Location = new System.Drawing.Point(19, 142);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 1);
            this.panel5.TabIndex = 18;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(19, 238);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 1);
            this.panel3.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Location = new System.Drawing.Point(19, 284);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 1);
            this.panel4.TabIndex = 18;
            // 
            // SelectData
            // 
            this.SelectData.BackColor = System.Drawing.Color.Gainsboro;
            this.SelectData.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.SelectData.Location = new System.Drawing.Point(140, 320);
            this.SelectData.Margin = new System.Windows.Forms.Padding(2);
            this.SelectData.Name = "SelectData";
            this.SelectData.Size = new System.Drawing.Size(116, 25);
            this.SelectData.TabIndex = 19;
            this.SelectData.Text = "Import Data";
            this.SelectData.UseVisualStyleBackColor = false;
            this.SelectData.Click += new System.EventHandler(this.SelectData_Click);
            // 
            // EditPasswords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 366);
            this.Controls.Add(this.BackGround);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "EditPasswords";
            this.Text = "EditPasswords";
            this.Load += new System.EventHandler(this.EditPasswords_Load);
            this.BackGround.ResumeLayout(false);
            this.BackGround.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel BackGround;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Generate;
        private System.Windows.Forms.TextBox FillWebName;
        private System.Windows.Forms.TextBox FillURL;
        private System.Windows.Forms.TextBox FillPass;
        private System.Windows.Forms.TextBox FillEmail;
        private System.Windows.Forms.TextBox FillUser;
        private System.Windows.Forms.Label AddWebName;
        private System.Windows.Forms.Label AddEmail;
        private System.Windows.Forms.Label AddPass;
        private System.Windows.Forms.Label URL;
        private System.Windows.Forms.Label AddUserName;
        private System.Windows.Forms.Button ShowHide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button SelectData;
    }
}