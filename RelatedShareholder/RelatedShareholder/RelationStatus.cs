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
    public partial class RelationStatus : Form
    {
       // SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");

        public RelationStatus()
        {
            InitializeComponent();
        }

        private void RelationStatus_Load(object sender, EventArgs e)
        {
            conn.Open();
            Showdata();
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 1;

            dataGridView1.Columns[varindex].Name = "RelationType";
            dataGridView1.Columns[varindex].Width = 150;

            string sql = "Select * from IR_RelationStatus";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["RelationType"].ToString());
            }
            dr.Close();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                MyGlobal.GlobalStatus = dataGridView1.Rows[e.RowIndex].Cells["RelationType"].Value.ToString();
                this.Close();
            }
            catch { }
        }
    }
}
