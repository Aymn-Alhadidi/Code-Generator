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
            this.components = new System.ComponentModel.Container();
            this.Text1 = new System.Windows.Forms.TextBox();
            this.btnLoad = new System.Windows.Forms.Button();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.cbDataBases = new System.Windows.Forms.ComboBox();
            this.cbTables = new System.Windows.Forms.ComboBox();
            this.listViewColumns = new System.Windows.Forms.ListView();
            this.columnDataType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnAllowNull = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnIsPrimary = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnGenerateDataAccessLayer = new System.Windows.Forms.Button();
            this.btnCopyDataAccessResult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCopyBusinessLayer = new System.Windows.Forms.Button();
            this.txtBusinessLayer = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSetDataBaseConnection = new System.Windows.Forms.Button();
            this.txtclsDataAccessSetting = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnCopyclsConnectionString = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Text1
            // 
            this.Text1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.Text1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(203)))), ((int)(((byte)(7)))));
            this.Text1.Location = new System.Drawing.Point(537, 81);
            this.Text1.Multiline = true;
            this.Text1.Name = "Text1";
            this.Text1.ReadOnly = true;
            this.Text1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Text1.Size = new System.Drawing.Size(612, 379);
            this.Text1.TabIndex = 2;
            // 
            // btnLoad
            // 
            this.btnLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoad.Location = new System.Drawing.Point(237, 108);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(168, 34);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Load DataBases";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(26, 252);
            this.txtClassName.Multiline = true;
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(189, 26);
            this.txtClassName.TabIndex = 5;
            // 
            // cbDataBases
            // 
            this.cbDataBases.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDataBases.FormattingEnabled = true;
            this.cbDataBases.Location = new System.Drawing.Point(26, 118);
            this.cbDataBases.Name = "cbDataBases";
            this.cbDataBases.Size = new System.Drawing.Size(189, 24);
            this.cbDataBases.TabIndex = 7;
            this.cbDataBases.SelectedIndexChanged += new System.EventHandler(this.cbDataBases_SelectedIndexChanged);
            // 
            // cbTables
            // 
            this.cbTables.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTables.FormattingEnabled = true;
            this.cbTables.Location = new System.Drawing.Point(26, 185);
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
            this.listViewColumns.Location = new System.Drawing.Point(26, 354);
            this.listViewColumns.Name = "listViewColumns";
            this.listViewColumns.Size = new System.Drawing.Size(373, 271);
            this.listViewColumns.TabIndex = 9;
            this.listViewColumns.UseCompatibleStateImageBehavior = false;
            this.listViewColumns.View = System.Windows.Forms.View.Details;
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
            this.btnGenerateDataAccessLayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateDataAccessLayer.Location = new System.Drawing.Point(237, 172);
            this.btnGenerateDataAccessLayer.Name = "btnGenerateDataAccessLayer";
            this.btnGenerateDataAccessLayer.Size = new System.Drawing.Size(168, 37);
            this.btnGenerateDataAccessLayer.TabIndex = 10;
            this.btnGenerateDataAccessLayer.Text = "Generate Data";
            this.btnGenerateDataAccessLayer.UseVisualStyleBackColor = true;
            this.btnGenerateDataAccessLayer.Click += new System.EventHandler(this.btnGenerateDataAccessLayer_Click);
            // 
            // btnCopyDataAccessResult
            // 
            this.btnCopyDataAccessResult.Location = new System.Drawing.Point(1074, 41);
            this.btnCopyDataAccessResult.Name = "btnCopyDataAccessResult";
            this.btnCopyDataAccessResult.Size = new System.Drawing.Size(75, 34);
            this.btnCopyDataAccessResult.TabIndex = 11;
            this.btnCopyDataAccessResult.Text = "Copy";
            this.btnCopyDataAccessResult.UseVisualStyleBackColor = true;
            this.btnCopyDataAccessResult.Click += new System.EventHandler(this.btnCopyDataAccessResult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(476, 29);
            this.label1.TabIndex = 12;
            this.label1.Text = "Data Access And Business Layer Generator";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Data Bases";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tables";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(23, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Table Single Name";
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Location = new System.Drawing.Point(237, 241);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(168, 37);
            this.btnReset.TabIndex = 16;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(533, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(153, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Data Access Layer";
            // 
            // btnCopyBusinessLayer
            // 
            this.btnCopyBusinessLayer.Location = new System.Drawing.Point(1074, 486);
            this.btnCopyBusinessLayer.Name = "btnCopyBusinessLayer";
            this.btnCopyBusinessLayer.Size = new System.Drawing.Size(75, 38);
            this.btnCopyBusinessLayer.TabIndex = 18;
            this.btnCopyBusinessLayer.Text = "Copy";
            this.btnCopyBusinessLayer.UseVisualStyleBackColor = true;
            this.btnCopyBusinessLayer.Click += new System.EventHandler(this.btnCopyBusinessLayer_Click);
            // 
            // txtBusinessLayer
            // 
            this.txtBusinessLayer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.txtBusinessLayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(203)))), ((int)(((byte)(7)))));
            this.txtBusinessLayer.Location = new System.Drawing.Point(537, 530);
            this.txtBusinessLayer.Multiline = true;
            this.txtBusinessLayer.Name = "txtBusinessLayer";
            this.txtBusinessLayer.ReadOnly = true;
            this.txtBusinessLayer.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBusinessLayer.Size = new System.Drawing.Size(612, 379);
            this.txtBusinessLayer.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(533, 507);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Business Layer";
            // 
            // btnSetDataBaseConnection
            // 
            this.btnSetDataBaseConnection.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetDataBaseConnection.Location = new System.Drawing.Point(26, 311);
            this.btnSetDataBaseConnection.Name = "btnSetDataBaseConnection";
            this.btnSetDataBaseConnection.Size = new System.Drawing.Size(189, 37);
            this.btnSetDataBaseConnection.TabIndex = 21;
            this.btnSetDataBaseConnection.Text = "Data Base Connection ";
            this.btnSetDataBaseConnection.UseVisualStyleBackColor = true;
            this.btnSetDataBaseConnection.Click += new System.EventHandler(this.btnSetDataBaseConnection_Click);
            // 
            // txtclsDataAccessSetting
            // 
            this.txtclsDataAccessSetting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(39)))), ((int)(((byte)(34)))));
            this.txtclsDataAccessSetting.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(203)))), ((int)(((byte)(7)))));
            this.txtclsDataAccessSetting.Location = new System.Drawing.Point(26, 663);
            this.txtclsDataAccessSetting.Multiline = true;
            this.txtclsDataAccessSetting.Name = "txtclsDataAccessSetting";
            this.txtclsDataAccessSetting.ReadOnly = true;
            this.txtclsDataAccessSetting.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtclsDataAccessSetting.Size = new System.Drawing.Size(373, 246);
            this.txtclsDataAccessSetting.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(22, 640);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 20);
            this.label7.TabIndex = 23;
            this.label7.Text = "clsDataAccessSetting";
            // 
            // btnCopyclsConnectionString
            // 
            this.btnCopyclsConnectionString.Location = new System.Drawing.Point(324, 626);
            this.btnCopyclsConnectionString.Name = "btnCopyclsConnectionString";
            this.btnCopyclsConnectionString.Size = new System.Drawing.Size(75, 34);
            this.btnCopyclsConnectionString.TabIndex = 24;
            this.btnCopyclsConnectionString.Text = "Copy";
            this.btnCopyclsConnectionString.UseVisualStyleBackColor = true;
            this.btnCopyclsConnectionString.Click += new System.EventHandler(this.btnCopyclsConnectionString_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1172, 922);
            this.Controls.Add(this.btnCopyclsConnectionString);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtclsDataAccessSetting);
            this.Controls.Add(this.btnSetDataBaseConnection);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtBusinessLayer);
            this.Controls.Add(this.btnCopyBusinessLayer);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCopyDataAccessResult);
            this.Controls.Add(this.btnGenerateDataAccessLayer);
            this.Controls.Add(this.listViewColumns);
            this.Controls.Add(this.cbTables);
            this.Controls.Add(this.cbDataBases);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.Text1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Text1;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.ComboBox cbDataBases;
        private System.Windows.Forms.ComboBox cbTables;
        private System.Windows.Forms.ListView listViewColumns;
        private System.Windows.Forms.ColumnHeader columnDataType;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnAllowNull;
        private System.Windows.Forms.ColumnHeader columnIsPrimary;
        private System.Windows.Forms.Button btnGenerateDataAccessLayer;
        private System.Windows.Forms.Button btnCopyDataAccessResult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnCopyBusinessLayer;
        private System.Windows.Forms.TextBox txtBusinessLayer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSetDataBaseConnection;
        private System.Windows.Forms.TextBox txtclsDataAccessSetting;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnCopyclsConnectionString;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}

