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
            this.DgvAccountsTable = new System.Windows.Forms.DataGridView();
            this.PnlDgvAccountsTable = new System.Windows.Forms.Panel();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.PnlManageTools = new System.Windows.Forms.Panel();
            this.TbSearch = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balabce = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountsTable)).BeginInit();
            this.PnlDgvAccountsTable.SuspendLayout();
            this.PnlManageTools.SuspendLayout();
            this.SuspendLayout();
            // 
            // DgvAccountsTable
            // 
            this.DgvAccountsTable.AllowUserToAddRows = false;
            this.DgvAccountsTable.AllowUserToDeleteRows = false;
            this.DgvAccountsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.DgvAccountsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DgvAccountsTable.BackgroundColor = System.Drawing.Color.LightGray;
            this.DgvAccountsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DgvAccountsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAccountsTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] { this.Title, this.Type, this.Description, this.Balabce });
            this.DgvAccountsTable.Location = new System.Drawing.Point(15, 15);
            this.DgvAccountsTable.Margin = new System.Windows.Forms.Padding(15);
            this.DgvAccountsTable.Name = "DgvAccountsTable";
            this.DgvAccountsTable.ReadOnly = true;
            this.DgvAccountsTable.RowTemplate.Height = 24;
            this.DgvAccountsTable.Size = new System.Drawing.Size(619, 332);
            this.DgvAccountsTable.TabIndex = 0;
            // 
            // PnlDgvAccountsTable
            // 
            this.PnlDgvAccountsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlDgvAccountsTable.BackColor = System.Drawing.Color.LightGray;
            this.PnlDgvAccountsTable.Controls.Add(this.DgvAccountsTable);
            this.PnlDgvAccountsTable.Location = new System.Drawing.Point(15, 88);
            this.PnlDgvAccountsTable.Margin = new System.Windows.Forms.Padding(15);
            this.PnlDgvAccountsTable.Name = "PnlDgvAccountsTable";
            this.PnlDgvAccountsTable.Size = new System.Drawing.Size(649, 362);
            this.PnlDgvAccountsTable.TabIndex = 1;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAdd.FlatAppearance.BorderSize = 0;
            this.BtnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdd.Location = new System.Drawing.Point(570, 0);
            this.BtnAdd.Margin = new System.Windows.Forms.Padding(5, 0, 15, 0);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(64, 64);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            this.BtnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnDelete.FlatAppearance.BorderSize = 0;
            this.BtnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDelete.Location = new System.Drawing.Point(496, 0);
            this.BtnDelete.Margin = new System.Windows.Forms.Padding(15, 0, 5, 0);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(64, 64);
            this.BtnDelete.TabIndex = 2;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // PnlManageTools
            // 
            this.PnlManageTools.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.PnlManageTools.BackColor = System.Drawing.Color.LightGray;
            this.PnlManageTools.Controls.Add(this.TbSearch);
            this.PnlManageTools.Controls.Add(this.BtnDelete);
            this.PnlManageTools.Controls.Add(this.BtnAdd);
            this.PnlManageTools.Location = new System.Drawing.Point(15, 15);
            this.PnlManageTools.Margin = new System.Windows.Forms.Padding(15);
            this.PnlManageTools.Name = "PnlManageTools";
            this.PnlManageTools.Size = new System.Drawing.Size(649, 64);
            this.PnlManageTools.TabIndex = 2;
            // 
            // TbSearch
            // 
            this.TbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.TbSearch.Location = new System.Drawing.Point(15, 21);
            this.TbSearch.Margin = new System.Windows.Forms.Padding(15);
            this.TbSearch.Name = "TbSearch";
            this.TbSearch.Size = new System.Drawing.Size(451, 23);
            this.TbSearch.TabIndex = 3;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.ReadOnly = true;
            this.Type.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Description
            // 
            this.Description.HeaderText = "Description";
            this.Description.Name = "Description";
            this.Description.ReadOnly = true;
            // 
            // Balabce
            // 
            this.Balabce.HeaderText = "Balance";
            this.Balabce.Name = "Balabce";
            this.Balabce.ReadOnly = true;
            // 
            // AccountPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.Controls.Add(this.PnlManageTools);
            this.Controls.Add(this.PnlDgvAccountsTable);
            this.Font = new System.Drawing.Font("Lucida Fax", 7.8F);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "AccountPage";
            this.Size = new System.Drawing.Size(679, 465);
            this.Load += new System.EventHandler(this.AccountPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAccountsTable)).EndInit();
            this.PnlDgvAccountsTable.ResumeLayout(false);
            this.PnlManageTools.ResumeLayout(false);
            this.PnlManageTools.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TextBox TbSearch;

        private System.Windows.Forms.Panel PnlManageTools;

        private System.Windows.Forms.Button BtnDelete;

        private System.Windows.Forms.DataGridViewTextBoxColumn Description;
        private System.Windows.Forms.Button BtnAdd;

        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balabce;

        private System.Windows.Forms.Panel PnlDgvAccountsTable;

        private System.Windows.Forms.DataGridView DgvAccountsTable;

        #endregion
    }
}