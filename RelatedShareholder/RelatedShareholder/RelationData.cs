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
    public partial class RelationData : Form
    {
        int valErr = 0;

    //    SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");

        public RelationData()
        {
            InitializeComponent();
        }

        private void RelationData_Load(object sender, EventArgs e)
        {
            conn.Open();
            txtRelatedID.Text = MyGlobal.GlobalRelatedIDA;
            txtRelationPerson.Text = MyGlobal.GlobalRelatedPerson;

            Showdata();
            txtDate.Text = DateTime.Now.ToString("yyyy-MM-dd");
            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;
        }

        private void CheckError()
        {
            valErr = 0;
            if (txtRelatedID.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาใส่: รหัสบุคคลผู้เกี่ยวข้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return;
            }
            else if (txtRelationPerson.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: รหัสบุคคนผู้เกี่ยวข้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtRelatedType.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: RelatedType ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtRelatedCompany.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: บริษัทที่เกี่ยวข้อง ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
        }

        private void ClearData()
        {
            txtID.Text = "";
            txtRelatedID.Text = "";
            txtRelationPerson.Text = "";
            txtRelatedType.Text = "";
            txtRelatedCompany.Text = "";

            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 6;

            dataGridView1.Columns[varindex].Name = "ID";
            dataGridView1.Columns[varindex].Width = 50;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "รหัสบุคคลผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "บุคคลผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 170;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "บริษัทที่เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 170;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "RelatedType";
            dataGridView1.Columns[varindex].Width = 170;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "วันที่";
            dataGridView1.Columns[varindex].Width = 100;

            string sql = "Select * from IR_RelationData where RelatedId = '" + txtRelatedID.Text + "' order by IR_RelationData.RelatedID  ";
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["ID"].ToString(), dr["RelatedID"].ToString(), dr["RelatedPerson"].ToString(), dr["RelatedCompany"].ToString(), dr["RelatedType"].ToString(), dr["InputDate"].ToString());
            }
            dr.Close();
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            CheckError();
            if (valErr == 0)
            {
                String sql = "INSERT INTO IR_RelationData (RelatedID,RelatedPerson,RelatedCompany,RelatedType,InputDate)VALUES ('" + txtRelatedID.Text + "','" + txtRelationPerson.Text + "','" + txtRelatedCompany.Text + "','" + txtRelatedType.Text + "','" + txtDate.Text + "')";

                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("Add completed");

                Showdata();
                ClearData();
            }
        }

        //private void bttSearchRelatedID_Click(object sender, EventArgs e)
        //{
            //SearchRelatedID WinD3 = new SearchRelatedID();
            //WinD3.ShowDialog();

            //txtRelatedID.Text = MyGlobal.GlobalRelatedID;
            //txtRelationPerson.Text = MyGlobal.GlobalRelatedPerson;
            //Showdata();
       // }

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            CheckError();
            if (valErr != 0) { return; }
            if (txtID.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
            }

            if (MessageBox.Show("Do you want to Update the data ? " + txtID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Update IR_RelationData SET RelatedID = '" + txtRelatedID.Text + "', RelatedPerson = '" + txtRelationPerson.Text + "', RelatedCompany = '" + txtRelatedCompany.Text + "' , RelatedType = '" + txtRelatedType.Text + "' , InputDate = '" + txtDate.Text + "'where ID = '" + txtID.Text + "'";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Update completed");
                Showdata();
                ClearData();
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtID.Text = dataGridView1.Rows[e.RowIndex].Cells["ID"].Value.ToString();
                txtRelatedID.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสบุคคลผู้เกี่ยวข้อง"].Value.ToString();
                txtRelationPerson.Text = dataGridView1.Rows[e.RowIndex].Cells["บุคคลผู้เกี่ยวข้อง"].Value.ToString();
                txtRelatedCompany.Text = dataGridView1.Rows[e.RowIndex].Cells["บริษัทที่เกี่ยวข้อง"].Value.ToString();
                txtRelatedType.Text = dataGridView1.Rows[e.RowIndex].Cells["RelatedType"].Value.ToString();
                txtDate.Text = dataGridView1.Rows[e.RowIndex].Cells["วันที่"].Value.ToString();
            }
            catch { }

            bttAdd.Enabled = false;
            bttDelete.Enabled = true;

            bttUpdate.Enabled = true;
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Trim() == "")
            { MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }

            if (MessageBox.Show("Do you want to delete the data ? " + txtID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Delete from IR_RelationData where ID ='" + txtID.Text + "' ";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Delete completed");
                Showdata();
                ClearData();
            }
        }

        private void bttShowRelationType_Click(object sender, EventArgs e)
        {
            ShowRelationName WinD3 = new ShowRelationName();
            WinD3.ShowDialog();
            txtRelatedType.Text = MyGlobal.GlobalRelationType;
        }

    }
}
