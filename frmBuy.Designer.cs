﻿namespace 進銷存管理系統
{
    partial class frmBuy
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
            this.lblToday = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.cboProductName = new System.Windows.Forms.ComboBox();
            this.btnAddBuy = new System.Windows.Forms.Button();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtBuyPrice = new System.Windows.Forms.TextBox();
            this.lblS2 = new System.Windows.Forms.Label();
            this.lblS1 = new System.Windows.Forms.Label();
            this.cboVendorName = new System.Windows.Forms.ComboBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.dataSetDB1 = new 進銷存管理系統.DataSetDB1();
            this.供應商BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.供應商TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.供應商TableAdapter();
            this.庫存主檔BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.庫存主檔TableAdapter = new 進銷存管理系統.DataSetDB1TableAdapters.庫存主檔TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblToday
            // 
            this.lblToday.AutoSize = true;
            this.lblToday.Location = new System.Drawing.Point(120, 315);
            this.lblToday.Name = "lblToday";
            this.lblToday.Size = new System.Drawing.Size(58, 15);
            this.lblToday.TabIndex = 46;
            this.lblToday.Text = "lblToday";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Location = new System.Drawing.Point(31, 315);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(71, 15);
            this.Label8.TabIndex = 47;
            this.Label8.Text = "進貨日期:";
            // 
            // cboProductName
            // 
            this.cboProductName.DataSource = this.庫存主檔BindingSource;
            this.cboProductName.DisplayMember = "品名";
            this.cboProductName.FormattingEnabled = true;
            this.cboProductName.Location = new System.Drawing.Point(123, 68);
            this.cboProductName.Name = "cboProductName";
            this.cboProductName.Size = new System.Drawing.Size(252, 23);
            this.cboProductName.TabIndex = 45;
            this.cboProductName.ValueMember = "品名代號";
            // 
            // btnAddBuy
            // 
            this.btnAddBuy.Location = new System.Drawing.Point(34, 356);
            this.btnAddBuy.Name = "btnAddBuy";
            this.btnAddBuy.Size = new System.Drawing.Size(75, 23);
            this.btnAddBuy.TabIndex = 44;
            this.btnAddBuy.Text = "新增進貨";
            this.btnAddBuy.UseVisualStyleBackColor = true;
            this.btnAddBuy.Click += new System.EventHandler(this.btnAddBuy_Click);
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(123, 273);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(252, 25);
            this.txtNote.TabIndex = 41;
            // 
            // txtQty
            // 
            this.txtQty.Location = new System.Drawing.Point(123, 229);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(100, 25);
            this.txtQty.TabIndex = 42;
            // 
            // txtBuyPrice
            // 
            this.txtBuyPrice.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "進價", true));
            this.txtBuyPrice.Location = new System.Drawing.Point(123, 188);
            this.txtBuyPrice.Name = "txtBuyPrice";
            this.txtBuyPrice.Size = new System.Drawing.Size(100, 25);
            this.txtBuyPrice.TabIndex = 43;
            // 
            // lblS2
            // 
            this.lblS2.AutoSize = true;
            this.lblS2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "規格", true));
            this.lblS2.Location = new System.Drawing.Point(120, 151);
            this.lblS2.Name = "lblS2";
            this.lblS2.Size = new System.Drawing.Size(37, 15);
            this.lblS2.TabIndex = 40;
            this.lblS2.Text = "lblS2";
            // 
            // lblS1
            // 
            this.lblS1.AutoSize = true;
            this.lblS1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.庫存主檔BindingSource, "單位", true));
            this.lblS1.Location = new System.Drawing.Point(120, 110);
            this.lblS1.Name = "lblS1";
            this.lblS1.Size = new System.Drawing.Size(37, 15);
            this.lblS1.TabIndex = 39;
            this.lblS1.Text = "lblS1";
            // 
            // cboVendorName
            // 
            this.cboVendorName.DataSource = this.供應商BindingSource;
            this.cboVendorName.DisplayMember = "公司名稱";
            this.cboVendorName.FormattingEnabled = true;
            this.cboVendorName.Location = new System.Drawing.Point(123, 30);
            this.cboVendorName.Name = "cboVendorName";
            this.cboVendorName.Size = new System.Drawing.Size(252, 23);
            this.cboVendorName.TabIndex = 38;
            this.cboVendorName.ValueMember = "供應商代號";
            this.cboVendorName.SelectedIndexChanged += new System.EventHandler(this.cboVendorName_SelectedIndexChanged);
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Location = new System.Drawing.Point(31, 276);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(41, 15);
            this.Label7.TabIndex = 37;
            this.Label7.Text = "備註:";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Location = new System.Drawing.Point(31, 232);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(41, 15);
            this.Label6.TabIndex = 36;
            this.Label6.Text = "數量:";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Location = new System.Drawing.Point(31, 191);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(41, 15);
            this.Label5.TabIndex = 35;
            this.Label5.Text = "進價:";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Location = new System.Drawing.Point(31, 151);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(41, 15);
            this.Label4.TabIndex = 34;
            this.Label4.Text = "規格:";
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.Location = new System.Drawing.Point(31, 110);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(41, 15);
            this.Label3.TabIndex = 33;
            this.Label3.Text = "單位:";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(31, 71);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(41, 15);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "品名:";
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(31, 33);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(86, 15);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "供應商名稱:";
            // 
            // dataSetDB1
            // 
            this.dataSetDB1.DataSetName = "DataSetDB1";
            this.dataSetDB1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // 供應商BindingSource
            // 
            this.供應商BindingSource.DataMember = "供應商";
            this.供應商BindingSource.DataSource = this.dataSetDB1;
            // 
            // 供應商TableAdapter
            // 
            this.供應商TableAdapter.ClearBeforeFill = true;
            // 
            // 庫存主檔BindingSource
            // 
            this.庫存主檔BindingSource.DataMember = "庫存主檔";
            this.庫存主檔BindingSource.DataSource = this.dataSetDB1;
            // 
            // 庫存主檔TableAdapter
            // 
            this.庫存主檔TableAdapter.ClearBeforeFill = true;
            // 
            // frmBuy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 393);
            this.Controls.Add(this.lblToday);
            this.Controls.Add(this.Label8);
            this.Controls.Add(this.cboProductName);
            this.Controls.Add(this.btnAddBuy);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtBuyPrice);
            this.Controls.Add(this.lblS2);
            this.Controls.Add(this.lblS1);
            this.Controls.Add(this.cboVendorName);
            this.Controls.Add(this.Label7);
            this.Controls.Add(this.Label6);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.Label1);
            this.Name = "frmBuy";
            this.Text = "進貨處理表單";
            this.Load += new System.EventHandler(this.frmBuy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataSetDB1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.供應商BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.庫存主檔BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Label lblToday;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.ComboBox cboProductName;
        internal System.Windows.Forms.Button btnAddBuy;
        internal System.Windows.Forms.TextBox txtNote;
        internal System.Windows.Forms.TextBox txtQty;
        internal System.Windows.Forms.TextBox txtBuyPrice;
        internal System.Windows.Forms.Label lblS2;
        internal System.Windows.Forms.Label lblS1;
        internal System.Windows.Forms.ComboBox cboVendorName;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.Label Label1;
        private DataSetDB1 dataSetDB1;
        private System.Windows.Forms.BindingSource 供應商BindingSource;
        private DataSetDB1TableAdapters.供應商TableAdapter 供應商TableAdapter;
        private System.Windows.Forms.BindingSource 庫存主檔BindingSource;
        private DataSetDB1TableAdapters.庫存主檔TableAdapter 庫存主檔TableAdapter;
    }
}