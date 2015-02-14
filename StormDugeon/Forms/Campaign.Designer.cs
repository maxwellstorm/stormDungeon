namespace StormDugeon.Forms
{
    partial class Campaign
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.newLoadControl1 = new StormDugeon.Forms.UserControls.NewLoadControl();
            this.newLoadControl2 = new StormDugeon.Forms.UserControls.NewLoadControl();
            this.newLoadControl3 = new StormDugeon.Forms.UserControls.NewLoadControl();
            this.newLoadControl4 = new StormDugeon.Forms.UserControls.NewLoadControl();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CancelBtn.Location = new System.Drawing.Point(338, 363);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(86, 23);
            this.CancelBtn.TabIndex = 8;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // newLoadControl1
            // 
            this.newLoadControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLoadControl1.Location = new System.Drawing.Point(198, 80);
            this.newLoadControl1.Name = "newLoadControl1";
            this.newLoadControl1.Size = new System.Drawing.Size(356, 49);
            this.newLoadControl1.TabIndex = 9;
            // 
            // newLoadControl2
            // 
            this.newLoadControl2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLoadControl2.Location = new System.Drawing.Point(198, 222);
            this.newLoadControl2.Name = "newLoadControl2";
            this.newLoadControl2.Size = new System.Drawing.Size(356, 49);
            this.newLoadControl2.TabIndex = 10;
            // 
            // newLoadControl3
            // 
            this.newLoadControl3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLoadControl3.Location = new System.Drawing.Point(198, 149);
            this.newLoadControl3.Name = "newLoadControl3";
            this.newLoadControl3.Size = new System.Drawing.Size(356, 49);
            this.newLoadControl3.TabIndex = 11;
            // 
            // newLoadControl4
            // 
            this.newLoadControl4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newLoadControl4.Location = new System.Drawing.Point(198, 284);
            this.newLoadControl4.Name = "newLoadControl4";
            this.newLoadControl4.Size = new System.Drawing.Size(356, 49);
            this.newLoadControl4.TabIndex = 12;
            // 
            // Campaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(745, 456);
            this.Controls.Add(this.newLoadControl4);
            this.Controls.Add(this.newLoadControl3);
            this.Controls.Add(this.newLoadControl2);
            this.Controls.Add(this.newLoadControl1);
            this.Controls.Add(this.CancelBtn);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Campaign";
            this.Text = "NewGame";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private UserControls.NewLoadControl newLoadControl1;
        private UserControls.NewLoadControl newLoadControl2;
        private UserControls.NewLoadControl newLoadControl3;
        private UserControls.NewLoadControl newLoadControl4;
    }
}