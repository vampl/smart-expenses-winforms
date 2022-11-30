using System.ComponentModel;

namespace SmartExpense.Pages
{
    partial class AccountPage
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.LblComingSoon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblComingSoon
            // 
            this.LblComingSoon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.LblComingSoon.Location = new System.Drawing.Point(175, 218);
            this.LblComingSoon.Margin = new System.Windows.Forms.Padding(175, 218, 175, 218);
            this.LblComingSoon.Name = "LblComingSoon";
            this.LblComingSoon.Size = new System.Drawing.Size(229, 29);
            this.LblComingSoon.TabIndex = 1;
            this.LblComingSoon.Text = "Account page - Coming Soon!";
            this.LblComingSoon.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.LblComingSoon);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AccountPage";
            this.Size = new System.Drawing.Size(579, 465);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label LblComingSoon;

        #endregion
    }
}