using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using Excel = Microsoft.Office.Interop.Excel;
using System.Threading;

namespace RelatedShareholder
{
    public partial class ShowShareholder : Form
    {
       // SqlConnection conn = new SqlConnection("Server=192.168.4.4;Database=PST_SUBDATA;User Id=sa;Password=p@ssw0rd;MultipleActiveResultSets=True");
        SqlConnection conn = new SqlConnection("Server=" + MyGlobal.GlobalServer + ";Database=" + MyGlobal.GlobalDataBase + ";User Id= '" + MyGlobal.GlobalDataBaseUserID + "';Password= '" + MyGlobal.GlobalDataBasePassword + "';MultipleActiveResultSets=True");

        public ShowShareholder()
        {
            InitializeComponent();
        }

        private void ShowShareholder_Load(object sender, EventArgs e)
        {
            conn.Open();
            try
            {
                Thread progressThread = new Thread(delegate ()
                {
                    ProgressForm progress = new ProgressForm();
                    progress.ShowDialog();
                });
                progressThread.Start();
                Showdata();
                progressThread.Abort();
            }
            catch { Showdata(); }     
        }

        private void Showdata()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 8;

            
            dataGridView1.Columns[varindex].Name = "รหัสผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "รหัสผู้บุคคลผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อบุคคลผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ความสัมพันธ์";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "บริษัทที่เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ตำแหน่ง";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Status";
            dataGridView1.Columns[varindex].Width = 90;

            
            int varCount = 0;
            string sql = "";
            if (txtRelationName.Text == "")
            {
                //sql = "Select * from (IR_Shareholder inner join IR_RelationPerson on IR_Shareholder.ShareholderID = IR_RelationPerson.ShareholderID) inner join IR_RelationData on IR_RelationPerson.RelatedID = IR_RelationData.RelatedID where IR_Shareholder.Inactive <> 'Y'";
                sql = "Select * from (IR_Shareholder inner join IR_RelationPerson on IR_Shareholder.ShareholderID = IR_RelationPerson.ShareholderID) inner join IR_RelationData on IR_RelationPerson.RelatedID = IR_RelationData.RelatedID where IR_Shareholder.Inactive <> 'Y' order by IR_RelationPerson.RelatedID ";
            }
            else
            {
                sql = "Select * from (IR_Shareholder inner join IR_RelationPerson on IR_Shareholder.ShareholderID = IR_RelationPerson.ShareholderID) inner join IR_RelationData on IR_RelationPerson.RelatedID = IR_RelationData.RelatedID where IR_RelationPerson.RelatedPerson like '%' + '" + txtRelationName.Text + "' + '%'  order by IR_RelationPerson.RelatedPerson";
            }
     
            
            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string varStatus = "";
                string varShareholdername = "";
                string varShareholderID = dr["RelatedID"].ToString().Substring(0,6);
                string sql1 = "Select * from IR_Shareholder where ShareholderID = '" + varShareholderID + "' ";
                SqlCommand com1 = new SqlCommand(sql1, conn);
                SqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    varShareholdername = dr1["ShareholderName"].ToString();

                }

                dr1.Close();

                if(dr["Status"].ToString() == "N")
                {
                    varStatus = "ยกเลิกปี61";
                }

                dataGridView1.Rows.Add(varShareholderID, varShareholdername, dr["RelatedID"].ToString(), dr["RelatedPerson"].ToString(), dr["RelatedStatus"].ToString(), dr["RelatedCompany"].ToString(), dr["RelatedType"].ToString(), varStatus);

                if (dr["Status"].ToString() == "N")
                        dataGridView1.Rows[varCount].DefaultCellStyle.BackColor = Color.Gray;
                   varCount = varCount + 1;
            }

           
            dr.Close();
          
        }

        private void Showdata2()
        {
            int varindex = 0;

            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = 8;


            dataGridView1.Columns[varindex].Name = "รหัสผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อผู้ถือหุ้น";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "รหัสผู้บุคคลผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ชื่อบุคคลผู้เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ความสัมพันธ์";
            dataGridView1.Columns[varindex].Width = 100;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "บริษัทที่เกี่ยวข้อง";
            dataGridView1.Columns[varindex].Width = 200;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "ตำแหน่ง";
            dataGridView1.Columns[varindex].Width = 150;

            varindex = varindex + 1;
            dataGridView1.Columns[varindex].Name = "Status";
            dataGridView1.Columns[varindex].Width = 90;

            int varCount = 0;
            string sql = "";
            if (txtSearchCompany.Text == "")
            {
                sql = "Select * from IR_RelationPerson inner join IR_RelationData on IR_RelationPerson.RelatedID = IR_RelationData.RelatedID order by IR_RelationPerson.RelatedID";
            }
            else
            {
                sql = "Select * from IR_RelationPerson inner join IR_RelationData on IR_RelationPerson.RelatedID = IR_RelationData.RelatedID where IR_RelationData.RelatedCompany like '%' + '" + txtSearchCompany.Text + "' + '%' ";
            }



            SqlCommand com = new SqlCommand(sql, conn);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                string varStatus2 = "";
                string varShareholdername = "";
                string varShareholderID = dr["RelatedID"].ToString().Substring(0, 6);
                string sql1 = "Select * from IR_Shareholder where ShareholderID = '" + varShareholderID + "' ";
                SqlCommand com1 = new SqlCommand(sql1, conn);
                SqlDataReader dr1 = com1.ExecuteReader();
                while (dr1.Read())
                {
                    varShareholdername = dr1["ShareholderName"].ToString();

                }

                dr1.Close();

                if (dr["Status"].ToString() == "N")
                {
                    varStatus2 = "ยกเลิกปี61";
                }

                dataGridView1.Rows.Add(varShareholderID, varShareholdername, dr["RelatedID"].ToString(), dr["RelatedPerson"].ToString(), dr["RelatedStatus"].ToString(), dr["RelatedCompany"].ToString(), dr["RelatedType"].ToString(),varStatus2);
                if (dr["Status"].ToString() == "N")
                    dataGridView1.Rows[varCount].DefaultCellStyle.BackColor = Color.Gray;
                varCount = varCount + 1;
            }
            dr.Close();
        }

        private void bttSearchCompany_Click(object sender, EventArgs e)
        {         
          
            Showdata2();

        }

        private void bttExcel_Click(object sender, EventArgs e)
        {
            Thread progressThread = new Thread(delegate ()
            {
                ProgressForm progress = new ProgressForm();
                progress.ShowDialog();
            });
            progressThread.Start();

            Excel.Application xlApp;
            Excel.Workbook xlWorkBook;
            Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;

            xlApp = new Excel.Application();
            xlWorkBook = xlApp.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);

            try
            {
                Excel.Range formatRange;
                formatRange = xlWorkSheet.get_Range("H2", "H99999");
                formatRange.NumberFormat = "#,###,###";
            }
            catch { }

            int i = 0;
            int j = 0;
            int ix = 1;

            for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
            {
                xlWorkSheet.Cells[i + 1, j + 1] = dataGridView1.Columns[j].Name;
            }

            for (i = 0; i <= dataGridView1.RowCount - 1; i++)
            {
                for (j = 0; j <= dataGridView1.ColumnCount - 1; j++)
                {
                    DataGridViewCell cell = dataGridView1[j, i];
                    xlWorkSheet.Cells[ix + 1, j + 1] = cell.Value;
                }
                ix = ix + 1;
            }

            if (System.IO.File.Exists(@"c:\Shareholder.xls"))
            {
                try
                {
                    System.IO.File.Delete(@"c:\Shareholder.xls");
                }
                catch { }
            }
            if (System.IO.File.Exists(@"D:\Shareholder.xls"))
            {
                try
                {
                    System.IO.File.Delete(@"D:\Shareholder.xls");
                }
                catch { }

            }

            try
            {
                xlWorkBook.SaveAs(@"c:\Shareholder.xls");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbooks books = excelApp.Workbooks;
                Excel.Workbook Sheet = books.Open(@"c:\Shareholder.xls");
            }
            catch
            {
                xlWorkBook.SaveAs(@"D:\Shareholder.xls");
                xlWorkBook.Close(true, misValue, misValue);
                xlApp.Quit();
                var excelApp = new Excel.Application();
                excelApp.Visible = true;
                Excel.Workbooks books = excelApp.Workbooks;
                Excel.Workbook Sheet = books.Open(@"D:\Shareholder.xls");
            }

            progressThread.Abort();
        }

        private void bttRelationName_Click(object sender, EventArgs e)
        {          
            Showdata();
        }

        private void bttPrinReport_Click(object sender, EventArgs e)
        {
            PrinReport WinD3 = new PrinReport();
            WinD3.Show();
        }

    

    }
}
