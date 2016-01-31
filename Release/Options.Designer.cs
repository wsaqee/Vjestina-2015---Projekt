namespace PrinterStats
{
    partial class Options
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
            this.cBoxRunInBackGround = new System.Windows.Forms.CheckBox();
            this.cBoxAutoStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // cBoxRunInBackGround
            // 
            this.cBoxRunInBackGround.AutoSize = true;
            this.cBoxRunInBackGround.Location = new System.Drawing.Point(49, 43);
            this.cBoxRunInBackGround.Name = "cBoxRunInBackGround";
            this.cBoxRunInBackGround.Size = new System.Drawing.Size(118, 17);
            this.cBoxRunInBackGround.TabIndex = 0;
            this.cBoxRunInBackGround.Text = "Run in Background";
            this.cBoxRunInBackGround.UseVisualStyleBackColor = true;
            // 
            // cBoxAutoStart
            // 
            this.cBoxAutoStart.AutoSize = true;
            this.cBoxAutoStart.Location = new System.Drawing.Point(49, 75);
            this.cBoxAutoStart.Name = "cBoxAutoStart";
            this.cBoxAutoStart.Size = new System.Drawing.Size(197, 17);
            this.cBoxAutoStart.TabIndex = 1;
            this.cBoxAutoStart.Text = "Start PrintStats when Windows Start";
            this.cBoxAutoStart.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 143);
            this.Controls.Add(this.cBoxAutoStart);
            this.Controls.Add(this.cBoxRunInBackGround);
            this.Name = "Options";
            this.Text = "Options";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Options_FormClosing);
            this.Load += new System.EventHandler(this.Options_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cBoxRunInBackGround;
        private System.Windows.Forms.CheckBox cBoxAutoStart;
    }
}