using Business_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Code_Generator_Data_Access_and_Business_Layer_
{
    public partial class frmDataBaseConnectionString : Form
    {

        static private string Line = "";

        public frmDataBaseConnectionString()
        {
            InitializeComponent();

        }

        private string _SetDataBaseConnection()
        {
            string DataBaseConnection = $"Server = {txtBoxServer.Text}; Database = {txtBoxDataBase.Text}; User ID = {txtBoxUserID.Text}; Password = " + txtBoxPassword.Text;

            return DataBaseConnection;
            
        }

        private void frmDataBaseConnectionString_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string sDataBaseConnectionString = _SetDataBaseConnection();
            clsDataBaseConnection.WriteToFile(sDataBaseConnectionString, "D:\\mohammed abohdhd\\Code Generator(Data Access and Business Layer)\\DataBaseConnectionString.txt");
        }
    }
}
