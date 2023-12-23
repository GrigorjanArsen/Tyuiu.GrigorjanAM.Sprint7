
namespace Tyuiu.GrigorjanAM.Sprint7.Project.V9
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAbout_GAM = new System.Windows.Forms.PictureBox();
            this.labelText_GAM = new System.Windows.Forms.Label();
            this.buttonOK_GAM = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_GAM)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAbout_GAM
            // 
            this.pictureBoxAbout_GAM.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxAbout_GAM.Image")));
            this.pictureBoxAbout_GAM.Location = new System.Drawing.Point(12, 30);
            this.pictureBoxAbout_GAM.Name = "pictureBoxAbout_GAM";
            this.pictureBoxAbout_GAM.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxAbout_GAM.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAbout_GAM.TabIndex = 0;
            this.pictureBoxAbout_GAM.TabStop = false;
            // 
            // labelText_GAM
            // 
            this.labelText_GAM.AutoSize = true;
            this.labelText_GAM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.labelText_GAM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.labelText_GAM.Location = new System.Drawing.Point(218, 30);
            this.labelText_GAM.Name = "labelText_GAM";
            this.labelText_GAM.Size = new System.Drawing.Size(257, 165);
            this.labelText_GAM.TabIndex = 1;
            this.labelText_GAM.Text = resources.GetString("labelText_GAM.Text");
            // 
            // buttonOK_GAM
            // 
            this.buttonOK_GAM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.buttonOK_GAM.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonOK_GAM.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.buttonOK_GAM.Location = new System.Drawing.Point(397, 226);
            this.buttonOK_GAM.Name = "buttonOK_GAM";
            this.buttonOK_GAM.Size = new System.Drawing.Size(75, 23);
            this.buttonOK_GAM.TabIndex = 2;
            this.buttonOK_GAM.Text = "OK";
            this.buttonOK_GAM.UseVisualStyleBackColor = false;
            this.buttonOK_GAM.Click += new System.EventHandler(this.buttonOK_GAM_Click);
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.buttonOK_GAM);
            this.Controls.Add(this.labelText_GAM);
            this.Controls.Add(this.pictureBoxAbout_GAM);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация о разработчике";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAbout_GAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAbout_GAM;
        private System.Windows.Forms.Label labelText_GAM;
        private System.Windows.Forms.Button buttonOK_GAM;
    }
}