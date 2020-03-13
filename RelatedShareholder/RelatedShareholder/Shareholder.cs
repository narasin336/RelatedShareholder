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
    public partial class Shareholder : Form
    {
        int valErr = 0;
        string varInactive = "";

        //  SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        // SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");
        private OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source = |DataDirectory|\\Database.accdb");

        public Shareholder()
        {
            InitializeComponent();
        }

        private void Shareholder_Load(object sender, EventArgs e)
        {
            conn.Open();
          
            Showdata();

            
        

            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;
            bttRelationPerson.Enabled = false;


            ClearData();
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 20;

            dataGridView1.Columns[varindex].Name = "รหัสผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อเดิมผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ที่อยู่ที่ลงทะเบียน";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ที่อยู่ปัจจุบัน";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "เบอร์โทรศัพท์";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "เบอร์โทรศัพท์มือถือ";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "อีเมล์";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "บริษัทที่ทำงาน";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ตำแหน่ง";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "วันเกิด";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "การศึกษา1";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "การศึกษา2";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "การศึกษา3";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "การศึกษา4";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "การศึกษา5";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "จำนวนหุ้น";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ความสัมพันธ์กับPST";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Inactive";
            dataGridView1.Columns[varindex].Width = 5;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Date";
            dataGridView1.Columns[varindex].Width = 100;

            int varCount = 0;
            string sql = "";
            if (txtSearchName.Text == "")
            {
                sql = "Select * from IR_Shareholder order by IR_Shareholder.ShareholderID";

            }
            else
            {              
                sql = "Select * from IR_Shareholder where IR_Shareholder.ShareholderName like '%' + '" + txtSearchName.Text + "' + '%'  order by IR_Shareholder.ShareholderName";             
            }


            OleDbCommand com = new OleDbCommand(sql, conn);
            OleDbDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                dataGridView1.Rows.Add(dr["ShareholderID"].ToString(), dr["ShareholderName"].ToString(), dr["OriginalName"].ToString(), dr["RegisterAddress"].ToString(), dr["PresentAddress"].ToString(), dr["Telephone1"].ToString(), dr["Telephone2"].ToString(), dr["Email"].ToString(), dr["WorkingCompany"].ToString(), dr["Positions"].ToString(), dr["DateofBirth"].ToString(), dr["Education1"].ToString(), dr["Education2"].ToString(), dr["Education3"].ToString(), dr["Education4"].ToString(), dr["Education5"].ToString(), dr["ShareQty"].ToString(), dr["RelatedPST"].ToString(), dr["Inactive"].ToString(), dr["Inactive_Date"].ToString());

                if (dr["Inactive"].ToString() == "Y") 
                dataGridView1.Rows[varCount].DefaultCellStyle.BackColor = Color.Gray;
                varCount = varCount + 1;             
            }
            dr.Close();
            
        }

        private void CheckError()
        {
            valErr = 0;
            if (txtShareholderID.Text.Trim() == "")
            {
                MessageBox.Show("กรุณาใส่: รหัสผู้ถือหุ้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return;
            }     
            else if (txtShareholderID.TextLength != 6) { MessageBox.Show("กรุณาใส่: เลขที่ 6 หลัก", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtShareholderName.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: ชื่อผู้ถือหุ้น", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtRegisterAddress.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: ที่อยู่ที่ลงทะเบียน", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtPresentAddress.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: ที่อยู่ปัจจุบัน ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtTelePhone2.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: เบอร์โทรศัพท์มือถือ ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtEmail.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: อีเมล์ ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtWorkingCompany.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: บริษัทที่ทำงาน ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtPosition.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: ตำแหน่ง ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtDateofBrith.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: วันเกิด ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtEducation1.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: การศึกษา1 ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
            else if (txtRelatedPST.Text.Trim() == "") { MessageBox.Show("กรุณาใส่: ความสัมพันธ์บริษัท PST ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); valErr = +1; return; }
        }

        private void ClearData()
        {
            txtShareholderID.Text = "";
            txtShareholderName.Text = "";
            txtOrigianlName.Text = "";
            txtRegisterAddress.Text = "";
            txtPresentAddress.Text = "";
            txtTelePhone1.Text = "";
            txtTelePhone2.Text = "";
            txtWorkingCompany.Text = "";
            txtPosition.Text = "";
            txtEmail.Text = "";
            txtDateofBrith.Text = "";
            txtEducation1.Text = "";
            txtEducation2.Text = "";
            txtEducation3.Text = "";
            txtEducation4.Text = "";
            txtEducation5.Text = "";
            txtShareQty.Text = "";
            txtRelatedPST.Text = "";

            checkBox1.Checked = false;
            txtShareholderID.Enabled = true;
            bttAdd.Enabled = true;
            bttDelete.Enabled = false;
            bttUpdate.Enabled = false;
            bttRelationPerson.Enabled = false;
            txtDateInactive.Visible = false;
            dateTimePicker2.Visible = false;
            bttClearDateInactive.Visible = false;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        { 

            CheckError();
            if (valErr == 0)
            {

                varInactive = "";

                if (checkBox1.Checked == true) { varInactive = "Y"; }
                else if (checkBox1.Checked == false) { varInactive = ""; }

                String sql = @"INSERT INTO IR_Shareholder (ShareholderID,ShareholderName,OriginalName,RegisterAddress,PresentAddress,Telephone1,Telephone2,Email,WorkingCompany,Positions,DateofBirth,Education1,Education2,Education3,Education4,Education5,ShareQty,RelatedPST,Inactive)VALUES ('" + txtShareholderID.Text + "','" + txtShareholderName.Text + "','" + txtOrigianlName.Text + "','" + txtRegisterAddress.Text + "','" + txtPresentAddress.Text + "','" + txtTelePhone1.Text + "','" + txtTelePhone2.Text + "','" + txtEmail.Text + "','" + txtWorkingCompany.Text + "','" + txtPosition.Text + "','" + txtDateofBrith.Text + "','" + txtEducation1.Text + "','" + txtEducation2.Text + "','" + txtEducation3.Text + "','" + txtEducation4.Text + "','" + txtEducation5.Text + "','" + txtShareQty.Text + "','" + txtRelatedPST.Text + "','" + varInactive + "')";
                
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();
                MessageBox.Show("Add completed");

                Showdata();
                ClearData();
            }
        }

        private void dateTimePicker1_CloseUp(object sender, EventArgs e)
        {
            txtDateofBrith.Text = dateTimePicker1.Value.Year.ToString("0000") + "/" + dateTimePicker1.Value.Month.ToString("00") + "/" + dateTimePicker1.Value.Day.ToString("00");
        }

        private void bttClear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                txtShareholderID.Text = dataGridView1.Rows[e.RowIndex].Cells["รหัสผู้ถือหุ้น"].Value.ToString();
                txtShareholderName.Text = dataGridView1.Rows[e.RowIndex].Cells["ชื่อผู้ถือหุ้น"].Value.ToString();
                txtOrigianlName.Text = dataGridView1.Rows[e.RowIndex].Cells["ชื่อเดิมผู้ถือหุ้น"].Value.ToString();
                txtRegisterAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["ที่อยู่ที่ลงทะเบียน"].Value.ToString();
                txtPresentAddress.Text = dataGridView1.Rows[e.RowIndex].Cells["ที่อยู่ปัจจุบัน"].Value.ToString();
                txtTelePhone1.Text = dataGridView1.Rows[e.RowIndex].Cells["เบอร์โทรศัพท์"].Value.ToString();
                txtTelePhone2.Text = dataGridView1.Rows[e.RowIndex].Cells["เบอร์โทรศัพท์มือถือ"].Value.ToString();
                txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells["อีเมล์"].Value.ToString();
                txtWorkingCompany.Text = dataGridView1.Rows[e.RowIndex].Cells["บริษัทที่ทำงาน"].Value.ToString();
                txtPosition.Text = dataGridView1.Rows[e.RowIndex].Cells["ตำแหน่ง"].Value.ToString();
                txtDateofBrith.Text = dataGridView1.Rows[e.RowIndex].Cells["วันเกิด"].Value.ToString();
                txtEducation1.Text = dataGridView1.Rows[e.RowIndex].Cells["การศึกษา1"].Value.ToString();
                txtEducation2.Text = dataGridView1.Rows[e.RowIndex].Cells["การศึกษา2"].Value.ToString();
                txtEducation3.Text = dataGridView1.Rows[e.RowIndex].Cells["การศึกษา3"].Value.ToString();
                txtEducation4.Text = dataGridView1.Rows[e.RowIndex].Cells["การศึกษา4"].Value.ToString();
                txtEducation5.Text = dataGridView1.Rows[e.RowIndex].Cells["การศึกษา5"].Value.ToString();
                txtShareQty.Text = dataGridView1.Rows[e.RowIndex].Cells["จำนวนหุ้น"].Value.ToString();
                MyGlobal.GlobalShareholderName = dataGridView1.Rows[e.RowIndex].Cells["รหัสผู้ถือหุ้น"].Value.ToString();
                txtRelatedPST.Text = dataGridView1.Rows[e.RowIndex].Cells["ความสัมพันธ์กับPST"].Value.ToString();
                if (dataGridView1.Rows[e.RowIndex].Cells["Inactive"].Value.ToString() == "Y") { checkBox1.Checked = true; }
                else if (dataGridView1.Rows[e.RowIndex].Cells["Inactive"].Value.ToString() == "") { checkBox1.Checked = false; }
                txtDateInactive.Text = dataGridView1.Rows[e.RowIndex].Cells["Date"].Value.ToString();

            }
            catch { }

            txtShareholderID.Enabled = false;
            bttAdd.Enabled = false;
            bttDelete.Enabled = true;
            bttRelationPerson.Enabled = true;
            bttUpdate.Enabled = true;
        }

        private void bttUpdate_Click(object sender, EventArgs e)
        {
            CheckError();
            if (valErr != 0) { return; }
            if (txtShareholderID.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
            }

            if (MessageBox.Show("Do you want to Update the data ? " + txtShareholderID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                varInactive = "";

                if (checkBox1.Checked == true) { varInactive = "Y"; }
                else if (checkBox1.Checked == false) { varInactive = ""; }

                String sql = "Update IR_Shareholder SET ShareholderName = '" + txtShareholderName.Text + "', OriginalName = '" + txtOrigianlName.Text + "', RegisterAddress = '" + txtRegisterAddress.Text + "' , PresentAddress = '" + txtPresentAddress.Text + "', Telephone1 = '" + txtTelePhone1.Text + "', Telephone2 = '" + txtTelePhone2.Text + "', Email = '" + txtEmail.Text + "', WorkingCompany = '" + txtWorkingCompany.Text + "', Positions = '" + txtPosition.Text + "', DateofBirth = '" + txtDateofBrith.Text + "', Education1 = '" + txtEducation1.Text + "', Education2 = '" + txtEducation2.Text + "', Education3 = '" + txtEducation3.Text + "', Education4 = '" + txtEducation4.Text + "', Education5 = '" + txtEducation5.Text + "', ShareQty = '" + txtShareQty.Text + "', RelatedPST = '" + txtRelatedPST.Text + "', Inactive = '" + varInactive + "', Inactive_Date = '" + txtDateInactive.Text + "' where ShareholderID = '" + txtShareholderID.Text + "'";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Update completed");
                Showdata();
                ClearData();
            }
        }

        private void bttDelete_Click(object sender, EventArgs e)
        {
            if (txtShareholderID.Text.Trim() == "")
            { MessageBox.Show("Please Select Data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return; }

            string sql1 = "";


            sql1 = "Select * from IR_RelationPerson where ShareholderID = '" + txtShareholderID.Text + "' ";


            OleDbCommand com1 = new OleDbCommand(sql1, conn);
            OleDbDataReader dr1 = com1.ExecuteReader();
            while (dr1.Read())
            {
                MessageBox.Show("ไม่สามารถลบได้เพราะมีข้อมูลอยู่", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1); return;
            }
            dr1.Close();


            if (MessageBox.Show("Do you want to delete the data ? " + txtShareholderID.Text, "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
            {
                String sql = "Delete from IR_Shareholder where ShareholderID ='" + txtShareholderID.Text + "' ";
                OleDbCommand com = new OleDbCommand(sql, conn);
                com.ExecuteNonQuery();

                MessageBox.Show("Delete completed");
                Showdata();
                ClearData();
            }
        }

        private void bttRelationPerson_Click(object sender, EventArgs e)
        {
           
            RelationPerson WinD3 = new RelationPerson();
            WinD3.ShowDialog();
        }

        private void bttClearDate_Click(object sender, EventArgs e)
        {
            txtDateofBrith.Text = "";
        }

        private void bttRelationData_Click(object sender, EventArgs e)
        {
            RelationData WinD3 = new RelationData();
            WinD3.ShowDialog();
        }

        private void bttShowShareholder_Click(object sender, EventArgs e)
        {
            ShowShareholder WinD3 = new ShowShareholder();
            WinD3.ShowDialog();
        }

        private void bttShowName_Click(object sender, EventArgs e)
        {
            Showdata();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtDateInactive.Visible = true;
            bttClearDateInactive.Visible = true;
            dateTimePicker2.Visible = true;
        }

        private void dateTimePicker2_CloseUp(object sender, EventArgs e)
        {
            txtDateInactive.Text = dateTimePicker2.Value.Year.ToString("0000") + "/" + dateTimePicker2.Value.Month.ToString("00") + "/" + dateTimePicker2.Value.Day.ToString("00");
        }

        private void bttClearDateInactive_Click(object sender, EventArgs e)
        {
            txtDateInactive.Text = "";
        }
    }
}
