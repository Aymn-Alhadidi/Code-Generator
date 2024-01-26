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
        static List<GenerateDataAccessLayer.TableColumnInfo> ListSelectedRows = new List<GenerateDataAccessLayer.TableColumnInfo>();

        static string ConnectionString = "Server = .; Database = ContactsDB; User ID = sa ; Password = sa123456";



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void _setOneItem(GenerateDataAccessLayer.TableColumnInfo Column)
        {

      
            ListViewItem Item = new ListViewItem(Column.DataType);

            Item.SubItems.Add(Column.ColumnName);
            Item.SubItems.Add(Column.AllowNull.ToString());
            Item.SubItems.Add(Column.IsPrimaryKey.ToString());

            listViewColumns.Items.Add(Item);
        }

        private void _RemoveItemsFromListView()
        {
            while (this.listViewColumns.Items.Count > 0)
            {
                this.listViewColumns.Items[0].Remove();
            }
        }

        private void setTableColumnsInListView()
        {
            _RemoveItemsFromListView();

            foreach (GenerateDataAccessLayer.TableColumnInfo i in ListTableContact)
            {
                _setOneItem(i);
            }

            
        }

        private void FullListWithCheckedItem(ListView.CheckedListViewItemCollection checkedItems)
        {
            string firstSubItemValue = "";
            GenerateDataAccessLayer.TableColumnInfo CheckedItem = new GenerateDataAccessLayer.TableColumnInfo();

            ListSelectedRows.Clear();
            foreach (ListViewItem item in checkedItems)
            {
                
                firstSubItemValue = item.SubItems[1].Text;
                CheckedItem = GenerateDataAccessLayer.FindColumn(ListTableContact, firstSubItemValue);

                if (CheckedItem.IsPrimaryKey)
                    continue;

                ListSelectedRows.Add(CheckedItem);

                
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            DataTable TableInfo = GenerateDataAccessLayer.GetTableInformations(txtConnectionString.Text, txtDataBaseName.Text, txtTableName.Text);
            GenerateDataAccessLayer.LoadListWithTableInfo(TableInfo, ref ListTableContact, ref PrimaryColumn);

            List<string> Hello = clsDataBaseConnection.DisplayDatabases(ConnectionString);

            cbDataBases.Items.Clear();
            foreach (string i in Hello)
            {
                cbDataBases.Items.Add(i);
            }
        }

        private void cbDataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Hello = clsDataBaseConnection.DisplayTables(ConnectionString, cbDataBases.SelectedItem.ToString());

            cbTables.Items.Clear();
            foreach (string i in Hello)
            {
                cbTables.Items.Add(i);
            }

        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListTableContact.Clear();
            DataTable TableInfo = GenerateDataAccessLayer.GetTableInformations(txtConnectionString.Text, cbDataBases.SelectedItem.ToString(), cbTables.SelectedItem.ToString());
            GenerateDataAccessLayer.LoadListWithTableInfo(TableInfo, ref ListTableContact, ref PrimaryColumn);

            setTableColumnsInListView();
        }

        private void listViewColumns_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            
        }

        private void btnFile_Click(object sender, EventArgs e)
        {


        }

        private void btnGenerateDataAccessLayer_Click(object sender, EventArgs e)
        {
            //Load Checked subItem in List
            ListView.CheckedListViewItemCollection checkedItems = listViewColumns.CheckedItems;
            FullListWithCheckedItem(checkedItems);

             Text1.Text = GenerateDataAccessLayer.Generate_DataAccessLayer(ListTableContact, ListSelectedRows, PrimaryColumn, cbTables.SelectedItem.ToString(), txtClassName.Text);

            //Text1.Text = GenerateBusinessLayer.BusinessLayer_GetAllIsContactExist(ListSelectedRows, txtClassName.Text);

            //Text1.Text = GenerateBusinessLayer.Generate_BusinessLayer(ListTableContact,ListSelectedRows,PrimaryColumn,cbTables.Text.ToString(),txtClassName.Text);
        }
    }
}
