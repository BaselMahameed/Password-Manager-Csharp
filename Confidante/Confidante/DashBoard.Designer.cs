namespace Confidante
{
    partial class DashBoard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashBoard));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.EditPass = new System.Windows.Forms.Button();
            this.AddPass = new System.Windows.Forms.Button();
            this.Logo = new System.Windows.Forms.Panel();
            this.Confidante = new System.Windows.Forms.Label();
            this.Entrance = new System.Windows.Forms.Panel();
            this.Default = new System.Windows.Forms.Button();
            this.Welcome = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Delete = new System.Windows.Forms.Button();
            this.HideData = new System.Windows.Forms.Button();
            this.ShowData = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Simulate = new System.Windows.Forms.Button();
            this.DataTable = new System.Windows.Forms.DataGridView();
            this.Website = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.PanelMenu.SuspendLayout();
            this.Logo.SuspendLayout();
            this.Entrance.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.PanelMenu.Controls.Add(this.About);
            this.PanelMenu.Controls.Add(this.EditPass);
            this.PanelMenu.Controls.Add(this.AddPass);
            this.PanelMenu.Controls.Add(this.Logo);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(220, 649);
            this.PanelMenu.TabIndex = 0;
            // 
            // About
            // 
            this.About.Dock = System.Windows.Forms.DockStyle.Top;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.About.Image = ((System.Drawing.Image)(resources.GetObject("About.Image")));
            this.About.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.About.Location = new System.Drawing.Point(0, 215);
            this.About.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(220, 63);
            this.About.TabIndex = 3;
            this.About.Text = "About Confidante <3";
            this.About.UseVisualStyleBackColor = true;
            this.About.Click += new System.EventHandler(this.About_Click);
            // 
            // EditPass
            // 
            this.EditPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.EditPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EditPass.Image = ((System.Drawing.Image)(resources.GetObject("EditPass.Image")));
            this.EditPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.EditPass.Location = new System.Drawing.Point(0, 152);
            this.EditPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.EditPass.Name = "EditPass";
            this.EditPass.Size = new System.Drawing.Size(220, 63);
            this.EditPass.TabIndex = 2;
            this.EditPass.Text = "Edit Passwords.";
            this.EditPass.UseVisualStyleBackColor = true;
            this.EditPass.Click += new System.EventHandler(this.EditPass_Click);
            // 
            // AddPass
            // 
            this.AddPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.AddPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AddPass.Image = ((System.Drawing.Image)(resources.GetObject("AddPass.Image")));
            this.AddPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPass.Location = new System.Drawing.Point(0, 89);
            this.AddPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AddPass.Name = "AddPass";
            this.AddPass.Size = new System.Drawing.Size(220, 63);
            this.AddPass.TabIndex = 1;
            this.AddPass.Text = "Add A Password.";
            this.AddPass.UseVisualStyleBackColor = true;
            this.AddPass.Click += new System.EventHandler(this.AddPass_Click);
            // 
            // Logo
            // 
            this.Logo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(51)))), ((int)(((byte)(84)))));
            this.Logo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Logo.BackgroundImage")));
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Logo.Controls.Add(this.Confidante);
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(220, 89);
            this.Logo.TabIndex = 0;
            this.Logo.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Confidante
            // 
            this.Confidante.AutoSize = true;
            this.Confidante.Font = new System.Drawing.Font("Microsoft Uighur", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Confidante.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Confidante.Location = new System.Drawing.Point(137, 59);
            this.Confidante.Name = "Confidante";
            this.Confidante.Size = new System.Drawing.Size(80, 27);
            this.Confidante.TabIndex = 0;
            this.Confidante.Text = "Confidante!";
            // 
            // Entrance
            // 
            this.Entrance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(70)))), ((int)(((byte)(107)))));
            this.Entrance.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Entrance.Controls.Add(this.Default);
            this.Entrance.Controls.Add(this.Welcome);
            this.Entrance.Dock = System.Windows.Forms.DockStyle.Top;
            this.Entrance.Location = new System.Drawing.Point(220, 0);
            this.Entrance.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Entrance.Name = "Entrance";
            this.Entrance.Size = new System.Drawing.Size(697, 89);
            this.Entrance.TabIndex = 1;
            this.Entrance.Paint += new System.Windows.Forms.PaintEventHandler(this.Entrance_Paint);
            // 
            // Default
            // 
            this.Default.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Default.BackgroundImage")));
            this.Default.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Default.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Default.Location = new System.Drawing.Point(-3, -2);
            this.Default.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Default.Name = "Default";
            this.Default.Size = new System.Drawing.Size(85, 79);
            this.Default.TabIndex = 1;
            this.Default.UseVisualStyleBackColor = true;
            this.Default.Click += new System.EventHandler(this.Default_Click);
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Microsoft Uighur", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.Welcome.Location = new System.Drawing.Point(244, 16);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(275, 41);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "Welcome To Confidante!";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.DarkGray;
            this.MainPanel.Controls.Add(this.panel1);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(220, 89);
            this.MainPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(697, 560);
            this.MainPanel.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.DataTable);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 560);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.Delete);
            this.panel2.Controls.Add(this.HideData);
            this.panel2.Controls.Add(this.ShowData);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.Simulate);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 495);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(697, 65);
            this.panel2.TabIndex = 1;
            // 
            // Delete
            // 
            this.Delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Delete.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.Location = new System.Drawing.Point(268, 14);
            this.Delete.Margin = new System.Windows.Forms.Padding(4);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(119, 47);
            this.Delete.TabIndex = 4;
            this.Delete.Text = "Delete Data!";
            this.Delete.UseVisualStyleBackColor = true;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // HideData
            // 
            this.HideData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.HideData.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HideData.Location = new System.Drawing.Point(132, 14);
            this.HideData.Margin = new System.Windows.Forms.Padding(4);
            this.HideData.Name = "HideData";
            this.HideData.Size = new System.Drawing.Size(119, 47);
            this.HideData.TabIndex = 3;
            this.HideData.Text = "Hide Data.";
            this.HideData.UseVisualStyleBackColor = true;
            this.HideData.Click += new System.EventHandler(this.HideData_Click);
            // 
            // ShowData
            // 
            this.ShowData.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowData.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ShowData.Location = new System.Drawing.Point(5, 14);
            this.ShowData.Margin = new System.Windows.Forms.Padding(4);
            this.ShowData.Name = "ShowData";
            this.ShowData.Size = new System.Drawing.Size(119, 47);
            this.ShowData.TabIndex = 2;
            this.ShowData.Text = "Show Data.";
            this.ShowData.UseVisualStyleBackColor = true;
            this.ShowData.Click += new System.EventHandler(this.ShowData_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(448, 15);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(119, 47);
            this.button3.TabIndex = 1;
            this.button3.Text = "Visit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Simulate
            // 
            this.Simulate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Simulate.Font = new System.Drawing.Font("Microsoft Uighur", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Simulate.Location = new System.Drawing.Point(574, 15);
            this.Simulate.Margin = new System.Windows.Forms.Padding(4);
            this.Simulate.Name = "Simulate";
            this.Simulate.Size = new System.Drawing.Size(119, 47);
            this.Simulate.TabIndex = 0;
            this.Simulate.Text = "Simulate";
            this.Simulate.UseVisualStyleBackColor = true;
            this.Simulate.Click += new System.EventHandler(this.Simulate_Click_2);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToResizeColumns = false;
            this.DataTable.AllowUserToResizeRows = false;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.ColumnHeadersHeight = 29;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Website,
            this.Username,
            this.Email,
            this.Password,
            this.Time});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.Location = new System.Drawing.Point(0, 0);
            this.DataTable.Margin = new System.Windows.Forms.Padding(4);
            this.DataTable.MultiSelect = false;
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.RowHeadersWidth = 51;
            this.DataTable.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.DataTable.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DataTable.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSteelBlue;
            this.DataTable.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(697, 560);
            this.DataTable.TabIndex = 0;
            this.DataTable.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataTable_CellContentClick_1);
            // 
            // Website
            // 
            this.Website.HeaderText = "Website";
            this.Website.MinimumWidth = 6;
            this.Website.Name = "Website";
            this.Website.ReadOnly = true;
            this.Website.Width = 150;
            // 
            // Username
            // 
            this.Username.HeaderText = "Username";
            this.Username.MinimumWidth = 6;
            this.Username.Name = "Username";
            this.Username.ReadOnly = true;
            this.Username.Width = 120;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            this.Email.Width = 150;
            // 
            // Password
            // 
            this.Password.HeaderText = "Password";
            this.Password.MinimumWidth = 6;
            this.Password.Name = "Password";
            this.Password.ReadOnly = true;
            this.Password.Width = 150;
            // 
            // Time
            // 
            this.Time.HeaderText = "Time";
            this.Time.MinimumWidth = 6;
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            this.Time.Width = 125;
            // 
            // DashBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(917, 649);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.Entrance);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "DashBoard";
            this.Text = "Welcome Friend!";
            this.Load += new System.EventHandler(this.DashBoard_Load);
            this.PanelMenu.ResumeLayout(false);
            this.Logo.ResumeLayout(false);
            this.Logo.PerformLayout();
            this.Entrance.ResumeLayout(false);
            this.Entrance.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.Panel Logo;
        private System.Windows.Forms.Button EditPass;
        private System.Windows.Forms.Button AddPass;
        private System.Windows.Forms.Panel Entrance;
        private System.Windows.Forms.Label Confidante;
        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button Default;
        private System.Windows.Forms.Button About;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Simulate;
        private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Website;
        private System.Windows.Forms.DataGridViewTextBoxColumn Username;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Password;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.Button ShowData;
        private System.Windows.Forms.Button HideData;
        private System.Windows.Forms.Button Delete;
    }
}