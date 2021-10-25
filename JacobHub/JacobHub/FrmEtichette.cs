using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

using System.Configuration;
using CrystalDecisions.CrystalReports.Engine;

namespace JacobHub
{
    public partial class FrmEtichette : DevExpress.XtraEditors.XtraForm
    {
        string negozio = "";
        string azienda = "";

        public FrmEtichette()
        {
            InitializeComponent();
        }

        public FrmEtichette(string n, string a)
        {
            InitializeComponent();
            negozio = n;
            azienda = a;

        }

        private void FrmEticehtte_Load(object sender, EventArgs e)
        {
        }
        private void aggiornaCrystalReport(string nomeReport)
        {
            ReportDocument cryRpt = new ReportDocument();
            cryRpt.Load(Application.StartupPath + "\\report\\" + nomeReport + ".rpt");
            string strDatabase = "";
            //ParameterValues crParameterValues = new ParameterValues();
            //ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();
            //ParameterFieldDefinition crParameterFieldDefinition;
            //ParameterFieldDefinitions crParameterFieldDefinitions;
            //crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
            // crParameterFieldDefinition = crParameterFieldDefinitions["codchia"];
            //crParameterDiscreteValue.Value = testa.Op_codchia;
            //  crParameterValues = crParameterFieldDefinition.CurrentValues;
            //crParameterValues.Clear();
            //crParameterValues.Add(crParameterDiscreteValue);
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            string strServer = ConfigurationManager.AppSettings["ServerName"].ToString();
            strDatabase = ConfigurationManager.AppSettings["DataBaseName"].ToString();
            string strUserID = ConfigurationManager.AppSettings["UserId"].ToString();
            string strPwd = ConfigurationManager.AppSettings["Password"].ToString();
            //crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);
            cryRpt.SetDatabaseLogon(strUserID, strPwd, strServer, strDatabase);
            crystalReportViewer1.ReportSource = cryRpt;
            crystalReportViewer1.Refresh();
        }
        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        }
        private void rbEt1_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string nomeReport = "";
           if (rbEt1.Checked)
            {
                nomeReport = "et1_Willyrptgrd";
            }
            if (rbEt2.Checked)
            {
                nomeReport = "et2_Willyrptgrd";
            }
            if (rbEt3.Checked)
            {
                nomeReport = "et3_Willy";
            }
            if (rbEt4.Checked)
            {
                nomeReport = "et1_Willyrptgrd_p";
            }
            if (rbEt5.Checked)
            {
                nomeReport = "et2_Willyrptgrd_p";
            }
            if (rbEt6.Checked)
            {
                nomeReport = "et3_Willy_p";
            }
            if (rbet7.Checked)
            {
                nomeReport = "et4_Willy";
            }
            if (rbet8.Checked)
            {
                nomeReport = "et4_Willy_p";
            }
            aggiornaCrystalReport(nomeReport);
        }

        private void rbet7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}