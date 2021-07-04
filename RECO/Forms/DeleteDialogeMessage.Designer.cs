
namespace RECO.Forms
{
    partial class DeleteDialogeMessage
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
            this.Yes = new FontAwesome.Sharp.IconButton();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cancel = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Yes
            // 
            this.Yes.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.Yes.FlatAppearance.BorderSize = 0;
            this.Yes.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Yes.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Yes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Yes.IconChar = FontAwesome.Sharp.IconChar.Check;
            this.Yes.IconColor = System.Drawing.Color.White;
            this.Yes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Yes.IconSize = 45;
            this.Yes.Location = new System.Drawing.Point(232, 103);
            this.Yes.Name = "Yes";
            this.Yes.Size = new System.Drawing.Size(53, 44);
            this.Yes.TabIndex = 1;
            this.Yes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Yes.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Yes.UseVisualStyleBackColor = true;
            this.Yes.Click += new System.EventHandler(this.Yes_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.InfoCircle;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 72;
            this.iconPictureBox1.Location = new System.Drawing.Point(386, 12);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(72, 75);
            this.iconPictureBox1.TabIndex = 4;
            this.iconPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(112, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Do You Want To Delete ?";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Cancel
            // 
            this.Cancel.AutoSize = true;
            this.Cancel.FlatAppearance.BorderSize = 0;
            this.Cancel.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.Control;
            this.Cancel.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.Cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Cancel.IconChar = FontAwesome.Sharp.IconChar.TimesCircle;
            this.Cancel.IconColor = System.Drawing.Color.White;
            this.Cancel.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cancel.IconSize = 45;
            this.Cancel.Location = new System.Drawing.Point(144, 100);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(51, 51);
            this.Cancel.TabIndex = 2;
            this.Cancel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Cancel.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // DeleteDialogeMessage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(481, 167);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Yes);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DeleteDialogeMessage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteDialogeMessage";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label1;
        public FontAwesome.Sharp.IconButton Yes;
        public FontAwesome.Sharp.IconButton Cancel;
    }
}