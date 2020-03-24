using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace RelatedShareholder
{
    public partial class PrinReport : Form
    {
        public PrinReport()
        {
            InitializeComponent();
        }

        private void PrinReport_Load(object sender, EventArgs e)
        {
        }

        private void bttShow_Click(object sender, EventArgs e)
        {
            TableLogOnInfos crtableLogoninfos = new TableLogOnInfos();
            TableLogOnInfo crtableLogoninfo = new TableLogOnInfo();
            ConnectionInfo crConnectionInfo = new ConnectionInfo();
            Tables CrTables;

            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(@"D:\MyProject\RelatedShareholder\RelatedShareholder\bin\Debug\Shareholder.rpt");
            crConnectionInfo.ServerName = MyGlobal.GlobalServer;
            crConnectionInfo.DatabaseName = MyGlobal.GlobalDataBase;
            crConnectionInfo.UserID = MyGlobal.GlobalDataBaseUserID;
            crConnectionInfo.Password = MyGlobal.GlobalDataBasePassword;

            CrTables = cryRpt.Database.Tables;
            foreach (CrystalDecisions.CrystalReports.Engine.Table CrTable in CrTables)
            {
                crtableLogoninfo = CrTable.LogOnInfo;
                crtableLogoninfo.ConnectionInfo = crConnectionInfo;
                CrTable.ApplyLogOnInfo(crtableLogoninfo);
            }

            ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            crParameterDiscreteValue.Value = txtShareholderID.Text;
            cryRpt.DataDefinition.ParameterFields["PShareholderID"].CurrentValues.Clear();
            cryRpt.DataDefinition.ParameterFields["PShareholderID"].CurrentValues.Add(crParameterDiscreteValue);
            cryRpt.DataDefinition.ParameterFields["PShareholderID"].ApplyCurrentValues(cryRpt.DataDefinition.ParameterFields["PShareholderID"].CurrentValues);

            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }

        private void bttShowRelationType_Click(object sender, EventArgs e)
        {
            SearchShareholderID WinD3 = new SearchShareholderID();
            WinD3.ShowDialog();
            txtShareholderID.Text = MyGlobal.GlobalShareholderID;
        }
    }
}
