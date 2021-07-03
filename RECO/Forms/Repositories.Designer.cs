
namespace RECO.Forms
{
    partial class Repositories
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BtnAddRepo = new FontAwesome.Sharp.IconButton();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(16)))), ((int)(((byte)(30)))));
            this.flowLayoutPanel1.Location = new System.Drawing.Point(38, 31);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(724, 285);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // BtnAddRepo
            // 
            this.BtnAddRepo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddRepo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(76)))));
            this.BtnAddRepo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddRepo.FlatAppearance.BorderSize = 0;
            this.BtnAddRepo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddRepo.ForeColor = System.Drawing.Color.White;
            this.BtnAddRepo.IconChar = FontAwesome.Sharp.IconChar.FolderPlus;
            this.BtnAddRepo.IconColor = System.Drawing.Color.White;
            this.BtnAddRepo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.BtnAddRepo.IconSize = 45;
            this.BtnAddRepo.Location = new System.Drawing.Point(634, 368);
            this.BtnAddRepo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.BtnAddRepo.Name = "BtnAddRepo";
            this.BtnAddRepo.Size = new System.Drawing.Size(130, 50);
            this.BtnAddRepo.TabIndex = 0;
            this.BtnAddRepo.Text = "Add New ";
            this.BtnAddRepo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAddRepo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAddRepo.UseVisualStyleBackColor = false;
            this.BtnAddRepo.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel2.AutoScroll = true;
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(255)))), ((int)(((byte)(202)))));
            this.flowLayoutPanel2.Location = new System.Drawing.Point(338, 31);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(426, 300);
            this.flowLayoutPanel2.TabIndex = 1;
            this.flowLayoutPanel2.Visible = false;
            // 
            // Repositories
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(16)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.BtnAddRepo);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Repositories";
            this.Text = "Repositories";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Repositories_FormClosed_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private FontAwesome.Sharp.IconButton BtnAddRepo;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
    }
}