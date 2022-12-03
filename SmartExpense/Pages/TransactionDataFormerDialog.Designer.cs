using System.ComponentModel;

namespace SmartExpense.Pages
{
    partial class TransactionDataFormerDialog
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
            this.TbId = new System.Windows.Forms.TextBox();
            this.TbOwnerId = new System.Windows.Forms.TextBox();
            this.TbDesctiption = new System.Windows.Forms.TextBox();
            this.TbAmount = new System.Windows.Forms.TextBox();
            this.CbAccounts = new System.Windows.Forms.ComboBox();
            this.LblAccountTitle = new System.Windows.Forms.Label();
            this.LblDate = new System.Windows.Forms.Label();
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblType = new System.Windows.Forms.Label();
            this.LblAmount = new System.Windows.Forms.Label();
            this.CbType = new System.Windows.Forms.ComboBox();
            this.LblId = new System.Windows.Forms.Label();
            this.LblOwnerId = new System.Windows.Forms.Label();
            this.DtpTransactionDay = new System.Windows.Forms.DateTimePicker();
            this.BtnComfirn = new System.Windows.Forms.Button();
            this.RdbDelete = new System.Windows.Forms.RadioButton();
            this.RdbUpdate = new System.Windows.Forms.RadioButton();
            this.LblMode = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TbId
            // 
            this.TbId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbId.Location = new System.Drawing.Point(294, 202);
            this.TbId.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TbId.Name = "TbId";
            this.TbId.Size = new System.Drawing.Size(67, 23);
            this.TbId.TabIndex = 25;
            this.TbId.Visible = false;
            // 
            // TbOwnerId
            // 
            this.TbOwnerId.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbOwnerId.Location = new System.Drawing.Point(161, 206);
            this.TbOwnerId.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TbOwnerId.Name = "TbOwnerId";
            this.TbOwnerId.Size = new System.Drawing.Size(67, 23);
            this.TbOwnerId.TabIndex = 24;
            this.TbOwnerId.Visible = false;
            // 
            // TbDesctiption
            // 
            this.TbDesctiption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbDesctiption.Location = new System.Drawing.Point(193, 99);
            this.TbDesctiption.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TbDesctiption.Name = "TbDesctiption";
            this.TbDesctiption.Size = new System.Drawing.Size(186, 23);
            this.TbDesctiption.TabIndex = 23;
            // 
            // TbAmount
            // 
            this.TbAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbAmount.Location = new System.Drawing.Point(193, 68);
            this.TbAmount.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.TbAmount.Name = "TbAmount";
            this.TbAmount.Size = new System.Drawing.Size(186, 23);
            this.TbAmount.TabIndex = 22;
            // 
            // CbAccounts
            // 
            this.CbAccounts.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbAccounts.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbAccounts.FormattingEnabled = true;
            this.CbAccounts.Location = new System.Drawing.Point(193, 165);
            this.CbAccounts.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CbAccounts.Name = "CbAccounts";
            this.CbAccounts.Size = new System.Drawing.Size(186, 24);
            this.CbAccounts.TabIndex = 21;
            // 
            // LblAccountTitle
            // 
            this.LblAccountTitle.Location = new System.Drawing.Point(24, 165);
            this.LblAccountTitle.Margin = new System.Windows.Forms.Padding(15, 5, 15, 131);
            this.LblAccountTitle.Name = "LblAccountTitle";
            this.LblAccountTitle.Size = new System.Drawing.Size(139, 24);
            this.LblAccountTitle.TabIndex = 20;
            this.LblAccountTitle.Text = "Account Title";
            // 
            // LblDate
            // 
            this.LblDate.Location = new System.Drawing.Point(24, 131);
            this.LblDate.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(139, 24);
            this.LblDate.TabIndex = 19;
            this.LblDate.Text = "Date";
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(24, 102);
            this.LblDescription.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(139, 24);
            this.LblDescription.TabIndex = 18;
            this.LblDescription.Text = "Description";
            // 
            // LblType
            // 
            this.LblType.Location = new System.Drawing.Point(24, 205);
            this.LblType.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblType.Name = "LblType";
            this.LblType.Size = new System.Drawing.Size(48, 24);
            this.LblType.TabIndex = 17;
            this.LblType.Text = "Type";
            this.LblType.Visible = false;
            // 
            // LblAmount
            // 
            this.LblAmount.Location = new System.Drawing.Point(24, 68);
            this.LblAmount.Margin = new System.Windows.Forms.Padding(15, 15, 15, 5);
            this.LblAmount.Name = "LblAmount";
            this.LblAmount.Size = new System.Drawing.Size(139, 24);
            this.LblAmount.TabIndex = 16;
            this.LblAmount.Text = "Amount";
            // 
            // CbType
            // 
            this.CbType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CbType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CbType.FormattingEnabled = true;
            this.CbType.Items.AddRange(new object[] { "Income", "Expense" });
            this.CbType.Location = new System.Drawing.Point(24, 205);
            this.CbType.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.CbType.Name = "CbType";
            this.CbType.Size = new System.Drawing.Size(67, 24);
            this.CbType.TabIndex = 15;
            this.CbType.Visible = false;
            // 
            // LblId
            // 
            this.LblId.Location = new System.Drawing.Point(326, 208);
            this.LblId.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblId.Name = "LblId";
            this.LblId.Size = new System.Drawing.Size(35, 24);
            this.LblId.TabIndex = 26;
            this.LblId.Text = "Id";
            this.LblId.Visible = false;
            // 
            // LblOwnerId
            // 
            this.LblOwnerId.Location = new System.Drawing.Point(160, 208);
            this.LblOwnerId.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblOwnerId.Name = "LblOwnerId";
            this.LblOwnerId.Size = new System.Drawing.Size(68, 24);
            this.LblOwnerId.TabIndex = 27;
            this.LblOwnerId.Text = "OwnerId";
            this.LblOwnerId.Visible = false;
            // 
            // DtpTransactionDay
            // 
            this.DtpTransactionDay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DtpTransactionDay.CustomFormat = "dd-MM-yyyy";
            this.DtpTransactionDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DtpTransactionDay.Location = new System.Drawing.Point(193, 132);
            this.DtpTransactionDay.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.DtpTransactionDay.Name = "DtpTransactionDay";
            this.DtpTransactionDay.Size = new System.Drawing.Size(186, 23);
            this.DtpTransactionDay.TabIndex = 28;
            // 
            // BtnComfirn
            // 
            this.BtnComfirn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnComfirn.Location = new System.Drawing.Point(24, 199);
            this.BtnComfirn.Margin = new System.Windows.Forms.Padding(15);
            this.BtnComfirn.Name = "BtnComfirn";
            this.BtnComfirn.Size = new System.Drawing.Size(355, 33);
            this.BtnComfirn.TabIndex = 29;
            this.BtnComfirn.Text = "Comfirn";
            this.BtnComfirn.UseVisualStyleBackColor = true;
            // 
            // RdbDelete
            // 
            this.RdbDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdbDelete.Location = new System.Drawing.Point(193, 24);
            this.RdbDelete.Margin = new System.Windows.Forms.Padding(15);
            this.RdbDelete.Name = "RdbDelete";
            this.RdbDelete.Size = new System.Drawing.Size(77, 24);
            this.RdbDelete.TabIndex = 30;
            this.RdbDelete.TabStop = true;
            this.RdbDelete.Text = "Delete";
            this.RdbDelete.UseVisualStyleBackColor = true;
            // 
            // RdbUpdate
            // 
            this.RdbUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RdbUpdate.Location = new System.Drawing.Point(290, 24);
            this.RdbUpdate.Margin = new System.Windows.Forms.Padding(15);
            this.RdbUpdate.Name = "RdbUpdate";
            this.RdbUpdate.Size = new System.Drawing.Size(89, 24);
            this.RdbUpdate.TabIndex = 31;
            this.RdbUpdate.TabStop = true;
            this.RdbUpdate.Text = "Update";
            this.RdbUpdate.UseVisualStyleBackColor = true;
            // 
            // LblMode
            // 
            this.LblMode.Location = new System.Drawing.Point(24, 24);
            this.LblMode.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LblMode.Name = "LblMode";
            this.LblMode.Size = new System.Drawing.Size(139, 24);
            this.LblMode.TabIndex = 32;
            this.LblMode.Text = "Mode";
            // 
            // TransactionDataFormerDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(403, 243);
            this.Controls.Add(this.LblMode);
            this.Controls.Add(this.RdbUpdate);
            this.Controls.Add(this.RdbDelete);
            this.Controls.Add(this.BtnComfirn);
            this.Controls.Add(this.DtpTransactionDay);
            this.Controls.Add(this.LblOwnerId);
            this.Controls.Add(this.LblId);
            this.Controls.Add(this.TbId);
            this.Controls.Add(this.TbOwnerId);
            this.Controls.Add(this.TbDesctiption);
            this.Controls.Add(this.TbAmount);
            this.Controls.Add(this.CbAccounts);
            this.Controls.Add(this.LblAccountTitle);
            this.Controls.Add(this.LblDate);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblType);
            this.Controls.Add(this.LblAmount);
            this.Controls.Add(this.CbType);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "TransactionDataFormerDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Transaction Edit/Delete Form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label LblMode;

        internal System.Windows.Forms.RadioButton RdbDelete;
        internal System.Windows.Forms.RadioButton RdbUpdate;

        private System.Windows.Forms.Button BtnComfirn;

        internal System.Windows.Forms.DateTimePicker DtpTransactionDay;

        private System.Windows.Forms.Label LblId;
        private System.Windows.Forms.Label LblOwnerId;

        internal System.Windows.Forms.TextBox TbId;
        internal System.Windows.Forms.TextBox TbOwnerId;
        internal System.Windows.Forms.TextBox TbDesctiption;
        internal System.Windows.Forms.TextBox TbAmount;
        internal System.Windows.Forms.ComboBox CbAccounts;
        private System.Windows.Forms.Label LblAccountTitle;
        private System.Windows.Forms.Label LblDate;
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblType;
        private System.Windows.Forms.Label LblAmount;
        internal System.Windows.Forms.ComboBox CbType;

        #endregion
    }
}