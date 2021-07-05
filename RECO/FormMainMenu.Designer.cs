
namespace RECO
{
    partial class formMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnInfo = new FontAwesome.Sharp.IconButton();
            this.btnListen = new FontAwesome.Sharp.IconButton();
            this.btnKey = new FontAwesome.Sharp.IconButton();
            this.btnRepo = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.BtnMinimize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelMenu.Controls.Add(this.btnExit);
            this.panelMenu.Controls.Add(this.btnInfo);
            this.panelMenu.Controls.Add(this.btnListen);
            this.panelMenu.Controls.Add(this.btnKey);
            this.panelMenu.Controls.Add(this.btnRepo);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(250, 591);
            this.panelMenu.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.SignOutAlt;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 32;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(0, 380);
            this.btnExit.Name = "btnExit";
            this.btnExit.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnExit.Size = new System.Drawing.Size(250, 60);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "Exit";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnInfo
            // 
            this.btnInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfo.FlatAppearance.BorderSize = 0;
            this.btnInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnInfo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnInfo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnInfo.IconSize = 32;
            this.btnInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.Location = new System.Drawing.Point(0, 320);
            this.btnInfo.Name = "btnInfo";
            this.btnInfo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnInfo.Size = new System.Drawing.Size(250, 60);
            this.btnInfo.TabIndex = 7;
            this.btnInfo.Text = "Info";
            this.btnInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInfo.UseVisualStyleBackColor = true;
            this.btnInfo.Click += new System.EventHandler(this.btnInfo_Click);
            // 
            // btnListen
            // 
            this.btnListen.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListen.FlatAppearance.BorderSize = 0;
            this.btnListen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListen.IconChar = FontAwesome.Sharp.IconChar.AssistiveListeningSystems;
            this.btnListen.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListen.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListen.IconSize = 32;
            this.btnListen.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListen.Location = new System.Drawing.Point(0, 260);
            this.btnListen.Name = "btnListen";
            this.btnListen.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnListen.Size = new System.Drawing.Size(250, 60);
            this.btnListen.TabIndex = 6;
            this.btnListen.Text = "Listen";
            this.btnListen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListen.UseVisualStyleBackColor = true;
            this.btnListen.Click += new System.EventHandler(this.btnListen_Click);
            // 
            // btnKey
            // 
            this.btnKey.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnKey.FlatAppearance.BorderSize = 0;
            this.btnKey.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnKey.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.btnKey.IconColor = System.Drawing.Color.Gainsboro;
            this.btnKey.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnKey.IconSize = 32;
            this.btnKey.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKey.Location = new System.Drawing.Point(0, 200);
            this.btnKey.Name = "btnKey";
            this.btnKey.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnKey.Size = new System.Drawing.Size(250, 60);
            this.btnKey.TabIndex = 5;
            this.btnKey.Text = "RunTime";
            this.btnKey.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKey.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnKey.UseVisualStyleBackColor = true;
            this.btnKey.Click += new System.EventHandler(this.btnKey_Click);
            // 
            // btnRepo
            // 
            this.btnRepo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRepo.FlatAppearance.BorderSize = 0;
            this.btnRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRepo.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRepo.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btnRepo.IconColor = System.Drawing.Color.Gainsboro;
            this.btnRepo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRepo.IconSize = 32;
            this.btnRepo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepo.Location = new System.Drawing.Point(0, 140);
            this.btnRepo.Name = "btnRepo";
            this.btnRepo.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnRepo.Size = new System.Drawing.Size(250, 60);
            this.btnRepo.TabIndex = 4;
            this.btnRepo.Text = "Rebositories";
            this.btnRepo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRepo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRepo.UseVisualStyleBackColor = true;
            this.btnRepo.Click += new System.EventHandler(this.btnRepo_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(250, 140);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(250, 134);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_2);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.panelTitleBar.Controls.Add(this.BtnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(250, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(855, 77);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMinimize.FlatAppearance.BorderSize = 0;
            this.BtnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMinimize.IconChar = FontAwesome.Sharp.IconChar.CompressArrowsAlt;
            this.BtnMinimize.IconColor = System.Drawing.Color.White;
            this.BtnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnMinimize.IconSize = 30;
            this.BtnMinimize.Location = new System.Drawing.Point(798, 18);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.Size = new System.Drawing.Size(36, 30);
            this.BtnMinimize.TabIndex = 3;
            this.BtnMinimize.UseVisualStyleBackColor = true;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(60, 29);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(46, 19);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(7)))), ((int)(((byte)(17)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.MediumPurple;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(22, 25);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PowderBlue;
            this.panel1.Controls.Add(this.panelDesktop);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(250, 77);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(855, 514);
            this.panel1.TabIndex = 2;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(31)))), ((int)(((byte)(46)))));
            this.panelDesktop.Controls.Add(this.pictureBox4);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panelDesktop.Location = new System.Drawing.Point(0, 0);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(855, 514);
            this.panelDesktop.TabIndex = 0;
            this.panelDesktop.Paint += new System.Windows.Forms.PaintEventHandler(this.panelDesktop_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(167, 133);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(517, 211);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1105, 591);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "formMain";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.formMain_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private FontAwesome.Sharp.IconButton btnRepo;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnInfo;
        private FontAwesome.Sharp.IconButton btnListen;
        private FontAwesome.Sharp.IconButton btnKey;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private FontAwesome.Sharp.IconButton BtnMinimize;
    }
}

