namespace Code_Generator_Data_Access_and_Business_Layer_
{
    partial class Form1
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
            this.txtDataBaseName = new System.Windows.Forms.TextBox();
            this.txtTableName = new System.Windows.Forms.TextBox();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.btnFile = new System.Windows.Forms.Button();
            this.cbDataBases = new System.Windows.Forms.ComboBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.listViewColumns = new System.Windows.Forms.ListView();
            this.columnDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAllowNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIsPrimary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerateDataAccessLayer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtDataBaseName
            // 
            this.txtDataBaseName.Location = new System.Drawing.Point(73, 32);
            this.txtDataBaseName.Multiline = true;
            this.txtDataBaseName.Name = "txtDataBaseName";
            this.txtDataBaseName.Size = new System.Drawing.Size(198, 38);
            this.txtDataBaseName.TabIndex = 0;
            this.txtDataBaseName.Text = "ContactsDB";
            // 
            // txtTableName
            // 
            this.txtTableName.Location = new System.Drawing.Point(73, 95);
            this.txtTableName.Multiline = true;
            this.txtTableName.Name = "txtTableName";
            this.txtTableName.Size = new System.Drawing.Size(198, 38);
            this.txtTableName.TabIndex = 1;
            this.txtTableName.Text = "Countries";
            // 
            // Text1
            // 
            this.Text1.Location = new System.Drawing.Point(12, 456);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.Size = new System.Drawing.Size(1065, 443);
            this.Text1.TabIndex = 2;
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(73, 161);
            this.txtConnectionString.Multiline = true;
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(198, 38);
            this.txtConnectionString.TabIndex = 3;
            this.txtConnectionString.Text = "Server = .; Database = ContactsDB; User ID = sa ; Password = sa123456";
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(301, 30);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(129, 40);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "button1";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(73, 225);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(198, 38);
            this.txtClassName.TabIndex = 5;
            this.txtClassName.Text = "Country";
            // 
            // btnFile
            // 
            this.btnFile.Location = new System.Drawing.Point(301, 86);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(129, 40);
            this.btnFile.TabIndex = 6;
            this.btnFile.Text = "button1";
            this.btnFile.UseVisualStyleBackColor = true;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // cbDataBases
            // 
            this.cbDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBases.FormattingEnabled = true;
            this.cbDataBases.Location = new System.Drawing.Point(599, 23);
            this.cbDataBases.Name = "cbDataBases";
            this.cbDataBases.Size = new System.Drawing.Size(189, 24);
            this.cbDataBases.TabIndex = 7;
            this.cbDataBases.SelectedIndexChanged += new System.EventHandler(this.cbDataBases_SelectedIndexChanged);
            // 
            // cbTables
            // 
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(599, 63);
            this.cbTables.Name = "cbTables";
            this.cbTables.Size = new System.Drawing.Size(189, 24);
            this.cbTables.TabIndex = 8;
            this.cbTables.SelectedIndexChanged += new System.EventHandler(this.cbTables_SelectedIndexChanged);
            // 
            // listViewColumns
            // 
            this.listViewColumns.AllowColumnReorder = true;
            this.listViewColumns.AutoArrange = false;
            this.listViewColumns.CheckBoxes = true;
            this.listViewColumns.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnDataType,
            this.columnName,
            this.columnAllowNull,
            this.columnIsPrimary});
            this.listViewColumns.GridLines = true;
            this.listViewColumns.HideSelection = false;
            this.listViewColumns.HoverSelection = true;
            this.listViewColumns.Location = new System.Drawing.Point(325, 161);
            this.listViewColumns.Name = "listViewColumns";
            this.listViewColumns.Size = new System.Drawing.Size(373, 271);
            this.listViewColumns.TabIndex = 9;
            this.listViewColumns.UseCompatibleStateImageBehavior = false;
            this.listViewColumns.View = System.Windows.Forms.View.Details;
            this.listViewColumns.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.listViewColumns_ItemCheck);
            // 
            // columnDataType
            // 
            this.columnDataType.Text = "Data Type";
            this.columnDataType.Width = 80;
            // 
            // columnName
            // 
            this.columnName.Text = "Column Name";
            this.columnName.Width = 115;
            // 
            // columnAllowNull
            // 
            this.columnAllowNull.Text = "Allow Null";
            this.columnAllowNull.Width = 80;
            // 
            // columnIsPrimary
            // 
            this.columnIsPrimary.Text = "Is Primary Key";
            this.columnIsPrimary.Width = 100;
            // 
            // btnGenerateDataAccessLayer
            // 
            this.btnGenerateDataAccessLayer.Location = new System.Drawing.Point(455, 86);
            this.btnGenerateDataAccessLayer.Name = "btnGenerateDataAccessLayer";
            this.btnGenerateDataAccessLayer.Size = new System.Drawing.Size(129, 40);
            this.btnGenerateDataAccessLayer.TabIndex = 10;
            this.btnGenerateDataAccessLayer.Text = "Generate Data Access Layer";
            this.btnGenerateDataAccessLayer.UseVisualStyleBackColor = true;
            this.btnGenerateDataAccessLayer.Click += new System.EventHandler(this.btnGenerateDataAccessLayer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 911);
            this.Controls.Add(this.btnGenerateDataAccessLayer);
            this.Controls.Add(this.listViewColumns);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.cbDataBases);
            this.Controls.Add(this.btnFile);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.Text1);
            this.Controls.Add(this.txtTableName);
            this.Controls.Add(this.txtDataBaseName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDataBaseName;
        private System.Windows.Forms.TextBox txtTableName;
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.Button btnFile;
        private System.Windows.Forms.ComboBox cbDataBases;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ListView listViewColumns;
        private System.Windows.Forms.ColumnHeader columnDataType;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAllowNull;
        private System.Windows.Forms.ColumnHeader columnIsPrimary;
        private System.Windows.Forms.Button btnGenerateDataAccessLayer;
    }
}

