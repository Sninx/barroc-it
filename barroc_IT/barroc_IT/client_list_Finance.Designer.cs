﻿namespace barroc_IT
{
    partial class client_list_Finance
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
            this.components = new System.ComponentModel.Container();
            this.btn_Add_Client_Clientlist_Dev = new System.Windows.Forms.Button();
            this.dg_Client_list_Finance1 = new System.Windows.Forms.DataGridView();
            this.database1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.database1DataSet = new barroc_IT.Database1DataSet();
            this.btn_Logout_Clientlist_Finance = new System.Windows.Forms.Button();
            this.dg_Client_list_Finance2 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Finance1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Finance2)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Add_Client_Clientlist_Dev
            // 
            this.btn_Add_Client_Clientlist_Dev.Location = new System.Drawing.Point(13, 13);
            this.btn_Add_Client_Clientlist_Dev.Name = "btn_Add_Client_Clientlist_Dev";
            this.btn_Add_Client_Clientlist_Dev.Size = new System.Drawing.Size(108, 24);
            this.btn_Add_Client_Clientlist_Dev.TabIndex = 0;
            this.btn_Add_Client_Clientlist_Dev.Text = "Add Client";
            this.btn_Add_Client_Clientlist_Dev.UseVisualStyleBackColor = true;
            // 
            // dg_Client_list_Finance1
            // 
            this.dg_Client_list_Finance1.AutoGenerateColumns = false;
            this.dg_Client_list_Finance1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Client_list_Finance1.DataSource = this.database1DataSetBindingSource;
            this.dg_Client_list_Finance1.Location = new System.Drawing.Point(13, 43);
            this.dg_Client_list_Finance1.Name = "dg_Client_list_Finance1";
            this.dg_Client_list_Finance1.RowTemplate.Height = 24;
            this.dg_Client_list_Finance1.Size = new System.Drawing.Size(478, 591);
            this.dg_Client_list_Finance1.TabIndex = 1;
            // 
            // database1DataSetBindingSource
            // 
            this.database1DataSetBindingSource.DataSource = this.database1DataSet;
            this.database1DataSetBindingSource.Position = 0;
            // 
            // database1DataSet
            // 
            this.database1DataSet.DataSetName = "Database1DataSet";
            this.database1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btn_Logout_Clientlist_Finance
            // 
            this.btn_Logout_Clientlist_Finance.Location = new System.Drawing.Point(825, 640);
            this.btn_Logout_Clientlist_Finance.Name = "btn_Logout_Clientlist_Finance";
            this.btn_Logout_Clientlist_Finance.Size = new System.Drawing.Size(160, 30);
            this.btn_Logout_Clientlist_Finance.TabIndex = 10;
            this.btn_Logout_Clientlist_Finance.Text = "Log out";
            this.btn_Logout_Clientlist_Finance.UseVisualStyleBackColor = true;
            // 
            // dg_Client_list_Finance2
            // 
            this.dg_Client_list_Finance2.AutoGenerateColumns = false;
            this.dg_Client_list_Finance2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dg_Client_list_Finance2.DataSource = this.database1DataSetBindingSource;
            this.dg_Client_list_Finance2.Location = new System.Drawing.Point(513, 43);
            this.dg_Client_list_Finance2.Name = "dg_Client_list_Finance2";
            this.dg_Client_list_Finance2.RowTemplate.Height = 24;
            this.dg_Client_list_Finance2.Size = new System.Drawing.Size(478, 591);
            this.dg_Client_list_Finance2.TabIndex = 11;
            // 
            // client_list_Finance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 673);
            this.Controls.Add(this.dg_Client_list_Finance2);
            this.Controls.Add(this.btn_Logout_Clientlist_Finance);
            this.Controls.Add(this.dg_Client_list_Finance1);
            this.Controls.Add(this.btn_Add_Client_Clientlist_Dev);
            this.Name = "client_list_Finance";
            this.Text = "Client list Finance";
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Finance1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.database1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dg_Client_list_Finance2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Add_Client_Clientlist_Dev;
        private System.Windows.Forms.DataGridView dg_Client_list_Finance1;
        private System.Windows.Forms.BindingSource database1DataSetBindingSource;
        private Database1DataSet database1DataSet;
        private System.Windows.Forms.Button btn_Logout_Clientlist_Finance;
        private System.Windows.Forms.DataGridView dg_Client_list_Finance2;
    }
}