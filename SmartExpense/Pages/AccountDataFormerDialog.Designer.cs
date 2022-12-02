using System.ComponentModel;

namespace SmartExpense.Pages
{
    partial class AccountDataFormerDialog
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PnlDataReciver = new System.Windows.Forms.Panel();
            this.TbBalance = new System.Windows.Forms.TextBox();
            this.TbDescription = new System.Windows.Forms.TextBox();
            this.TbTitle = new System.Windows.Forms.TextBox();
            this.CbTypes = new System.Windows.Forms.ComboBox();
            this.LblBalance = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnConfirm = new System.Windows.Forms.Button();
            this.PnlDataReciver.SuspendLayout();
            this.SuspendLayout();
            // 
            // PnlDataReciver
            // 
            this.PnlDataReciver.Controls.Add(this.TbBalance);
            this.PnlDataReciver.Controls.Add(this.TbDescription);
            this.PnlDataReciver.Controls.Add(this.TbTitle);
            this.PnlDataReciver.Controls.Add(this.CbTypes);
            this.PnlDataReciver.Controls.Add(this.LblBalance);
            this.PnlDataReciver.Controls.Add(this.LblDescription);
            this.PnlDataReciver.Controls.Add(this.LblType);
            this.PnlDataReciver.Controls.Add(this.LblTitle);
            this.PnlDataReciver.Controls.Add(this.BtnConfirm);
            this.PnlDataReciver.Location = new System.Drawing.Point(24, 24);
            this.PnlDataReciver.Margin = new System.Windows.Forms.Padding(15);
            this.PnlDataReciver.Name = "PnlDataReciver";
            this.PnlDataReciver.Size = new System.Drawing.Size(317, 237);
            this.PnlDataReciver.TabIndex = 0;
            // 
            // TbBalance
            // 
            this.TbBalance.Location = new System.Drawing.Point(130, 139);
            this.TbBalance.Margin = new System.Windows.Forms.Padding(10);
            this.TbBalance.Name = "TbBalance";
            this.TbBalance.Size = new System.Drawing.Size(177, 23);
            this.TbBalance.TabIndex = 8;
            // 
            // TbDescription
            // 
            this.TbDescription.Location = new System.Drawing.Point(130, 95);
            this.TbDescription.Margin = new System.Windows.Forms.Padding(10);
            this.TbDescription.Name = "TbDescription";
            this.TbDescription.Size = new System.Drawing.Size(177, 23);
            this.TbDescription.TabIndex = 7;
            // 
            // TbTitle
            // 
            this.TbTitle.Location = new System.Drawing.Point(130, 7);
            this.TbTitle.Margin = new System.Windows.Forms.Padding(10);
            this.TbTitle.Name = "TbTitle";
            this.TbTitle.Size = new System.Drawing.Size(177, 23);
            this.TbTitle.TabIndex = 6;
            // 
            // CbTypes
            // 
            this.CbTypes.FormattingEnabled = true;
            this.CbTypes.Items.AddRange(new object[] { "Money", "Card" });
            this.CbTypes.Location = new System.Drawing.Point(130, 51);
            this.CbTypes.Margin = new System.Windows.Forms.Padding(10);
            this.CbTypes.Name = "CbTypes";
            this.CbTypes.Size = new System.Drawing.Size(177, 24);
            this.CbTypes.TabIndex = 5;
            // 
            // LblBalance
            // 
            this.LblBalance.Location = new System.Drawing.Point(10, 142);
            this.LblBalance.Margin = new System.Windows.Forms.Padding(10);
            this.LblBalance.Name = "LblBalance";
            this.LblBalance.Size = new System.Drawing.Size(100, 24);
            this.LblBalance.TabIndex = 4;
            this.LblBalance.Text = "Balance";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(10, 98);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(10);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(100, 24);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "Description";
            // 
            // LblType
            // 
            this.LblType.Location = new System.Drawing.Point(10, 54);
            this.LblType.Margin = new System.Windows.Forms.Padding(10);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(100, 24);
            this.LblType.TabIndex = 2;
            this.LblType.Text = "Type";
            // 
            // LblTitle
            // 
            this.LblTitle.Location = new System.Drawing.Point(10, 10);
            this.LblTitle.Margin = new System.Windows.Forms.Padding(10);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(100, 24);
            this.LblTitle.TabIndex = 1;
            this.LblTitle.Text = "Title";
            // 
            // BtnConfirm
            // 
            this.BtnConfirm.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnConfirm.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnConfirm.Location = new System.Drawing.Point(0, 204);
            this.BtnConfirm.Margin = new System.Windows.Forms.Padding(10);
            this.BtnConfirm.Name = "BtnConfirm";
            this.BtnConfirm.Size = new System.Drawing.Size(317, 33);
            this.BtnConfirm.TabIndex = 0;
            this.BtnConfirm.Text = "Confirm";
            this.BtnConfirm.UseVisualStyleBackColor = true;
            this.BtnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // AccountDataFormerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(365, 285);
            this.Controls.Add(this.PnlDataReciver);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "AccountDataFormerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Account Data";
            this.PnlDataReciver.ResumeLayout(false);
            this.PnlDataReciver.PerformLayout();
            this.ResumeLayout(false);
        }

        internal System.Windows.Forms.TextBox TbTitle;
        internal System.Windows.Forms.TextBox TbDescription;
        internal System.Windows.Forms.TextBox TbBalance;

        internal System.Windows.Forms.ComboBox CbTypes;

        private System.Windows.Forms.Label LblBalance;

        private System.Windows.Forms.Label LblTitle;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblDescription;

        private System.Windows.Forms.Panel PnlDataReciver;
        private System.Windows.Forms.Button BtnConfirm;

        #endregion
    }
}