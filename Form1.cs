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

        //static public string ConnectionString = "Server = .; Database = ContactsDB; User ID = sa ; Password = sa123456";
        static public string ConnectionString = "";


         private bool _ErrorDataBase()
        {
            if(cbDataBases.SelectedItem == null)
            {
                errorProvider1.SetError(cbDataBases, "Choice Data Base");
                return true;
            }

            return false;
        }

        private bool _ErrorTables()
        {
            if (cbTables.SelectedItem == null)
            {
                errorProvider1.SetError(cbTables, "Choice Table");
                return true;
            }

            return false;
        }

        private bool _ErrorclassName()
        {
            if (string.IsNullOrWhiteSpace(txtClassName.Text))
            {
                errorProvider1.SetError(txtClassName, "Write The Name Of Class");
                return true;
            }

            return false;
        }

        private bool _ErrorDataBaseConnection()
        {
            string DataBaseConnection = clsDataBaseConnection.ReadTextFromFile("D:\\mohammed abohdhd\\Code Generator(Data Access and Business Layer)\\DataBaseConnectionString.txt");
            if (string.IsNullOrWhiteSpace(DataBaseConnection))
            {
                errorProvider1.SetError(btnSetDataBaseConnection, "Set Data Base Connection");
                return true;
            }

            return false;
        }

        private bool _CheckErrors()
        {
            if (_ErrorDataBase() || _ErrorTables() || _ErrorclassName() || _ErrorDataBaseConnection())
                return true;

            return false;
        }
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
            ConnectionString = clsDataBaseConnection.ReadTextFromFile("D:\\mohammed abohdhd\\Code Generator(Data Access and Business Layer)\\DataBaseConnectionString.txt");

            List<string> DataBases = clsDataBaseConnection.DisplayDatabases(ConnectionString);

            cbDataBases.Items.Clear();
            foreach (string i in DataBases)
            {
                cbDataBases.Items.Add(i);
            }
        }

        private void cbDataBases_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> Tables = clsDataBaseConnection.DisplayTables(ConnectionString, cbDataBases.SelectedItem.ToString());

            cbTables.Items.Clear();
            foreach (string i in Tables)
            {
                cbTables.Items.Add(i);
            }

        }

        private void cbTables_SelectedIndexChanged(object sender, EventArgs e)
        {

            ListTableContact.Clear();
            DataTable TableInfo = GenerateDataAccessLayer.GetTableInformations(ConnectionString, cbDataBases.SelectedItem.ToString(), cbTables.SelectedItem.ToString());
            GenerateDataAccessLayer.LoadListWithTableInfo(TableInfo, ref ListTableContact, ref PrimaryColumn);

            txtClassName.Text = GenerateBusinessLayer.PredictClassName(cbTables.SelectedItem.ToString());
            setTableColumnsInListView();
        }


        private void btnGenerateDataAccessLayer_Click(object sender, EventArgs e)
        {

            if (_CheckErrors())
                return;


            Text1.Text = "";
            txtBusinessLayer.Text = "";

            //Load Checked subItem in List
            ListView.CheckedListViewItemCollection checkedItems = listViewColumns.CheckedItems;
            FullListWithCheckedItem(checkedItems);

             Text1.Text = GenerateDataAccessLayer.Generate_DataAccessLayer(ListTableContact, ListSelectedRows, PrimaryColumn, cbTables.SelectedItem.ToString(), txtClassName.Text);

            txtBusinessLayer.Text = GenerateBusinessLayer.Generate_BusinessLayer(ListTableContact,ListSelectedRows,PrimaryColumn,cbTables.Text.ToString(),txtClassName.Text);

            txtclsDataAccessSetting.Text = clsDataBaseConnection.GenerateDataBaseConnectionClass(ConnectionString);
        }

        private void btnCopyDataAccessResult_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(Text1.Text);
        }

        private void btnCopyBusinessLayer_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtBusinessLayer.Text);

        }

        private void btnSetDataBaseConnection_Click(object sender, EventArgs e)
        {
            frmDataBaseConnectionString frmDataBaseConnection = new frmDataBaseConnectionString();
            frmDataBaseConnection.ShowDialog();

        }

        private void btnCopyclsConnectionString_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(txtclsDataAccessSetting.Text);
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            //cbDataBases.SelectedItem = null;
            //cbTables.SelectedItem = null;

            _RemoveItemsFromListView();

            txtBusinessLayer.Text = "";
            txtclsDataAccessSetting.Text = "";
            Text1.Text = "";
        }
    }
}
