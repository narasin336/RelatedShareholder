using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace RelatedShareholder
{
    public partial class SearchShareholderID : Form
    {
       // SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");

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
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
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
