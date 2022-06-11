namespace Confidante.Forms
{
    partial class SimulateLogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SimulateLogIn));
            this.Simulation = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.UserName = new System.Windows.Forms.Label();
            this.Pass = new System.Windows.Forms.Label();
            this.FillUser = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.FillPass = new System.Windows.Forms.TextBox();
            this.Submit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Simulation
            // 
            this.Simulation.AutoSize = true;
            this.Simulation.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simulation.ForeColor = System.Drawing.SystemColors.Control;
            this.Simulation.Location = new System.Drawing.Point(13, 33);
            this.Simulation.Name = "Simulation";
            this.Simulation.Size = new System.Drawing.Size(506, 29);
            this.Simulation.TabIndex = 0;
            this.Simulation.Text = "Let\'s validate your data by simulating a log in into a chosen website ! ^_^";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Location = new System.Drawing.Point(10, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(509, 1);
            this.panel1.TabIndex = 1;
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.UserName.Image = ((System.Drawing.Image)(resources.GetObject("UserName.Image")));
            this.UserName.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UserName.Location = new System.Drawing.Point(53, 107);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(214, 26);
            this.UserName.TabIndex = 2;
            this.UserName.Text = "             Input Website\'s UserName:";
            // 
            // Pass
            // 
            this.Pass.AutoSize = true;
            this.Pass.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pass.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Pass.Image = ((System.Drawing.Image)(resources.GetObject("Pass.Image")));
            this.Pass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pass.Location = new System.Drawing.Point(53, 162);
            this.Pass.Name = "Pass";
            this.Pass.Size = new System.Drawing.Size(207, 26);
            this.Pass.TabIndex = 3;
            this.Pass.Text = "             Input Website\'s Password:";
            this.Pass.Click += new System.EventHandler(this.Pass_Click);
            // 
            // FillUser
            // 
            this.FillUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.FillUser.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FillUser.Location = new System.Drawing.Point(273, 108);
            this.FillUser.Name = "FillUser";
            this.FillUser.Size = new System.Drawing.Size(200, 22);
            this.FillUser.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(273, 136);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 1);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Location = new System.Drawing.Point(273, 194);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 1);
            this.panel3.TabIndex = 7;
            // 
            // FillPass
            // 
            this.FillPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.FillPass.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FillPass.Location = new System.Drawing.Point(273, 166);
            this.FillPass.Name = "FillPass";
            this.FillPass.Size = new System.Drawing.Size(200, 22);
            this.FillPass.TabIndex = 6;
            // 
            // Submit
            // 
            this.Submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Submit.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Submit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Submit.Location = new System.Drawing.Point(428, 222);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(108, 56);
            this.Submit.TabIndex = 8;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // SimulateLogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(566, 307);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.FillPass);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.FillUser);
            this.Controls.Add(this.Pass);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Simulation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SimulateLogIn";
            this.Text = "SimulateLogIn";
            this.Load += new System.EventHandler(this.SimulateLogIn_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Simulation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label Pass;
        private System.Windows.Forms.TextBox FillUser;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox FillPass;
        private System.Windows.Forms.Button Submit;
    }
}