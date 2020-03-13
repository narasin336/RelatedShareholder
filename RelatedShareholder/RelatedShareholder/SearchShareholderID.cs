using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace RelatedShareholder
{
    public partial class SearchShareholderID : Form
    {
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");
        public SearchShareholderID()
        {
            InitializeComponent();
        }

        private void SearchShareholderID_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 2;

            dataGridView1.Columns[varindex].Name = "รหัสผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 170;

            string sql = "Select * from IR_Shareholder order by IR_Shareholder.ShareholderID";
            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["ShareholderID"].ToString(), dr["ShareholderName"].ToString());
            }
            dr.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MyGlobal.GlobalShareholderID = dataGridView1.Rows[e.RowIndex].Cells["รหัสผู้ถือหุ้น"].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}
