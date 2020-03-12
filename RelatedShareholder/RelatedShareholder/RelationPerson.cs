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
    public partial class RelationPerson : Form
    {
        int valErr = 0;

        //SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");

        public RelationPerson()
        {
            InitializeComponent();
        }

        private void RelationPerson_Load(object sender, EventArgs e)
        {
            conn.Open();
            txtShareholderID.Text = MyGlobal.GlobalShareholderName;
            txtRelatedID.Text = MyGlobal.GlobalShareholderName;

            Showdata();
            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;
            bttRelationData.Enabled = false;
        }

        private void CheckError()
        {
            valErr = 0;
            if (txtShareholderID.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาใส่: รหัสผู้ถือหุ้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return;
            }
            else if (txtRelatedID.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: รหัสบุคคนผู้เกี่ยวข้อง", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtReID.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: รหัสผู้เกี่ยวข้อง ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtRelatedPerson.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: บุคคนผู้เกี่ยวข้อง ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtRelatedTypeStatus.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: สถานะความสำพันธ์ ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
        }

        private void ClearData()
        {
            //txtShareholderID.Text = "";
            //txtRelatedID.Text = "";
            txtReID.Text = "";
            txtRelatedPerson.Text = "";
            txtRelatedTypeStatus.Text = "";
            txtRemark.Text = "";

            txtShareholderID.Enabled = true;
            //bttSearchShareholderID.Enabled = true;
            txtReID.Enabled = true;
            txtRelatedID.Enabled = true;
            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 5;

            dataGridView1.Columns[varindex].Name = "รหัสผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "รหัสบุคคนผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "บุคคนผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "สถานะความสำพันธ์";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Remark";
            dataGridView1.Columns[varindex].Width = 200;

            string sql = "";
            if (txtShareholderID.Text == "")
            {
                sql = "Select * from IR_RelationPerson";
            }
            else
            {
                sql = "Select * from IR_RelationPerson where ShareholderID = '" + txtShareholderID.Text + "'  Order by  RelatedID  ";
            }

            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["ShareholderID"].ToString(), dr["RelatedID"].ToString(), dr["RelatedPerson"].ToString(), dr["RelatedStatus"].ToString(), dr["Remark"].ToString());
            }
            dr.Close();
        }

        private void bttSearchStatus_Click(object sender, EventArgs e)
        {
            RelationStatus WinD3 = new RelationStatus();
            WinD3.ShowDialog();
            txtRelatedTypeStatus.Text = MyGlobal.GlobalStatus;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtShareholderID.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสผู้ถือหุ้น"].Value.ToString();
                txtRelatedID.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสบุคคนผู้เกี่ยวข้อง"].Value.ToString().Substring(0,6);
                txtReID.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสบุคคนผู้เกี่ยวข้อง"].Value.ToString().Substring(7,2);
                txtRelatedPerson.Text = dataGridView1.Rows[e.RowIndex].Cells["บุคคนผู้เกี่ยวข้อง"].Value.ToString();
                txtRelatedTypeStatus.Text = dataGridView1.Rows[e.RowIndex].Cells["สถานะความสำพันธ์"].Value.ToString();
                txtRemark.Text = dataGridView1.Rows[e.RowIndex].Cells["Remark"].Value.ToString();
                MyGlobal.GlobalRelatedIDA = dataGridView1.Rows[e.RowIndex].Cells["รหัสบุคคนผู้เกี่ยวข้อง"].Value.ToString();
                MyGlobal.GlobalRelatedPerson = dataGridView1.Rows[e.RowIndex].Cells["บุคคนผู้เกี่ยวข้อง"].Value.ToString();
            }
            catch { }

            
            txtShareholderID.Enabled = false;
            txtRelatedID.Enabled = false;
            //bttSearchShareholderID.Enabled = false;
            txtReID.Enabled = false;
            bttAdd.Enabled = false;
            bttDelete.Enabled = true;
            bttUpdate.Enabled = true;
            bttRelationData.Enabled = true;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            string varRelatedID = txtRelatedID.Text +"-"+ txtReID.Text;
            CheckError();
            if (valErr == 0)
            {
                String sql = "INSERT INTO IR_RelationPerson (ShareholderID,RelatedID,RelatedPerson,RelatedStatus,Remark)VALUES ('" + txtShareholderID.Text + "','" + varRelatedID + "','" + txtRelatedPerson.Text + "','" + txtRelatedTypeStatus.Text + "','" + txtRemark.Text + "')";

                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("Add completed");

                Showdata();
                ClearData();
            }
        }

    

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            CheckError();

            string varRelatedID = txtRelatedID.Text + "-" + txtReID.Text;

            if (valErr != 0) { return; }
            if (varRelatedID.Trim() == "")
            {
                MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
            }

            if (MessageBox.Show("Do you want to Update the data ? " + varRelatedID, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Update IR_RelationPerson SET ShareholderID = '" + txtShareholderID.Text + "', RelatedPerson = '" + txtRelatedPerson.Text + "', RelatedStatus = '" + txtRelatedTypeStatus.Text + "' , Remark = '" + txtRemark.Text + "'where RelatedID = '" + varRelatedID + "'";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Update completed");
                Showdata();
                ClearData();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            string varRelatedID = txtRelatedID.Text + "-" + txtReID.Text;
            if (varRelatedID.Trim() == "")
            { MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }

            string sql1 = "";
           
            
            sql1 = "Select * from IR_RelationData where RelatedID = '" + varRelatedID + "' ";
            

            SqlCommand com1 = new SqlCommand(sql1, conn);
            SqlDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                MessageBox.Show("ไม่สามารถลบได้เพราะมีข้อมูลอยู่", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
            }
            dr1.Close();

            if (MessageBox.Show("Do you want to delete the data ? " + varRelatedID, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Delete from IR_RelationPerson where RelatedID ='" + varRelatedID + "' ";
                SqlCommand com = new SqlCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Delete completed");
                Showdata();
                ClearData();
            }
        }

        private void bttRelationData_Click(object sender, EventArgs e)
        {
            RelationData WinD3 = new RelationData();
            WinD3.ShowDialog();
        }
    }
}
