using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Business_Layer;

namespace Code_Generator_Data_Access_and_Business_Layer_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
  
        }


        static GenerateDataAccessLayer.TableColumnInfo PrimaryColumn = new GenerateDataAccessLayer.TableColumnInfo();

        static List<GenerateDataAccessLayer.TableColumnInfo> ListTableContact = new List<GenerateDataAccessLayer.TableColumnInfo>();

        static string ConnectionString = "Server = .; Database = ContactsDB; User ID = sa ; Password = sa123456";


        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable TableInfo = GenerateDataAccessLayer.GetTableInformations(txtConnectionString.Text, txtDataBaseName.Text,txtTableName.Text );
            GenerateDataAccessLayer.LoadListWithTableInfo(TableInfo, ref ListTableContact, ref PrimaryColumn);

            //foreach(GenerateDataAccessLayer.TableColumnInfo columnInfo in ListTableContact)
            //{
            //    Text1.Text += $"Column Name: {columnInfo.ColumnName}, Data Type: {columnInfo.DataType}, Allows Null: {columnInfo.AllowNull}, Is Primary Key: {columnInfo.IsPrimaryKey}\n";
            //}

            Text1.Text = GenerateBusinessLayer.BusinessLayer_FindContactByColumnName(ListTableContact, GenerateDataAccessLayer.FindColumn(ListTableContact, "CountryName"),GenerateDataAccessLayer.ConstructFunctionParameter(ListTableContact, true),GenerateDataAccessLayer.ConstructFunctionParameter(ListTableContact) ,txtClassName.Text);

        }


    }
}
