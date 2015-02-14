namespace StormDugeon.Forms.UserControls
{
    partial class NewLoadControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox = new System.Windows.Forms.TextBox();
            this.start = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextBox
            // 
            this.TextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.TextBox.Location = new System.Drawing.Point(13, 16);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(220, 20);
            this.TextBox.TabIndex = 3;
            // 
            // start
            // 
            this.start.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.start.Location = new System.Drawing.Point(254, 13);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(86, 23);
            this.start.TabIndex = 2;
            this.start.Text = "start new";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.start_Click);
            // 
            // NewLoadControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.start);
            this.Name = "NewLoadControl";
            this.Size = new System.Drawing.Size(356, 49);
            this.Load += new System.EventHandler(this.NewLoadControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button start;
    }
}
