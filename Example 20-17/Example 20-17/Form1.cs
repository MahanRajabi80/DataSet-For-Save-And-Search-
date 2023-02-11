using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Example_20_17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //--------------------------------------------------------------
        DataSet dataSet1 = new DataSet("dataSet1");
        string pathFile = Application.StartupPath + "\\bank.xml";
        //--------------------------------------------------------------
        private void Form1_Load(object sender, EventArgs e)
        {
            //get data
            if (System.IO.File.Exists(pathFile))//find data
                dataSet1.ReadXml(pathFile);
            else//first time
            {
                DataTable table1 = new DataTable("table1");
                DataColumn column1 = new DataColumn("name");
                DataColumn column2 = new DataColumn("fam");
                DataColumn column3 = new DataColumn("tel");
                table1.Columns.Add(column1);
                table1.Columns.Add(column2);
                table1.Columns.Add(column3);
                dataSet1.Tables.Add(table1);
            }
            dataSet1.Tables["table1"].Columns["tel"].Unique = true;
            dataSet1.Tables["table1"].PrimaryKey = new DataColumn[] { dataSet1.Tables["table1"].Columns["tel"] };            
        }
        //--------------------------------------------------------------
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //save data
            if (dataSet1.Tables["table1"].Rows.Count != 0)//there is data
                dataSet1.WriteXml(pathFile);
        }
        //--------------------------------------------------------------
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("txtName is empty!");
                txtName.Focus();
                return;
            }
            if (txtFam.Text == "")
            {
                MessageBox.Show("txtFam is empty!");
                txtFam.Focus();
                return;
            }
            if (!txtMaskTel.MaskCompleted)
            {
                MessageBox.Show("txtMaskTel is not complete!");
                txtMaskTel.Focus();
                return;
            }
            try
            {
                DataRow row = dataSet1.Tables["table1"].NewRow();
                row["name"] = txtName.Text;
                row["fam"] = txtFam.Text;
                row["tel"] = txtMaskTel.Text;
                dataSet1.Tables["table1"].Rows.Add(row);
                dataSet1.Tables["table1"].AcceptChanges();
                txtName.Text = "";
                txtFam.Text = "";
                txtMaskTel.Text = "";
                txtName.Focus();
            }
            catch
            {
                MessageBox.Show("Telephone is repeat!","",MessageBoxButtons.OK,MessageBoxIcon.Error);
                txtMaskTel.Focus();
            }
        }
        //--------------------------------------------------------------
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            listBoxSearch.Items.Clear();
            string key = txtSearch.Text;
            foreach (DataRow row in dataSet1.Tables["table1"].Rows)
            {
                if (row["fam"].ToString().Contains(key))
                    listBoxSearch.Items.Add(row["fam"].ToString() + " " + row["name"].ToString() + " " + row["tel"].ToString());
            }
        }      
    }
}
