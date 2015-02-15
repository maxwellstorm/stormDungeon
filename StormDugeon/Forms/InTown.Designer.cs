namespace StormDugeon.Forms
{
    partial class InTown
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InTown));
            this.Barracks = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Barracks)).BeginInit();
            this.SuspendLayout();
            // 
            // Barracks
            // 
            this.Barracks.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.Barracks.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Barracks.Image = global::StormDugeon.Properties.Resources.barracks;
            this.Barracks.InitialImage = ((System.Drawing.Image)(resources.GetObject("Barracks.InitialImage")));
            this.Barracks.Location = new System.Drawing.Point(121, 317);
            this.Barracks.Name = "Barracks";
            this.Barracks.Size = new System.Drawing.Size(450, 228);
            this.Barracks.TabIndex = 0;
            this.Barracks.TabStop = false;
            this.Barracks.MouseEnter += new System.EventHandler(this.Barracks_MouseEnter);
            this.Barracks.MouseLeave += new System.EventHandler(this.Barracks_MouseLeave);
            // 
            // InTown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1131, 576);
            this.Controls.Add(this.Barracks);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InTown";
            this.Text = "InTown";
            ((System.ComponentModel.ISupportInitialize)(this.Barracks)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Barracks;
    }
}