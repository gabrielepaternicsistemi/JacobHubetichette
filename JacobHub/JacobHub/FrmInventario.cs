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
using DevExpress.XtraPrinting;

namespace JacobHub
{
    public partial class FrmInventario : DevExpress.XtraEditors.XtraForm
    {
        string negozio = "";
        string azienda = "";
        Datahelper helper = new Datahelper();

        public FrmInventario()
        {
            InitializeComponent();
        }

        public FrmInventario(string n, string a)
        {
            InitializeComponent();
            negozio = n;
            azienda = a;
            Cmbtype.Properties.DataSource = helper.getEtichette().Tables[0];
        }

        private void FrmInventario_Load(object sender, EventArgs e)
        {

        }
        
        //carica file .csv e converte i tab in ; 
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (negozio.Equals("Tonfano"))
            {
                helper.svuotaTempAttilia();
                helper.removeallfromtmpAttilia();
            }
            else
            {
                helper.svuotaTemp();
                helper.removeallfromtmp();
            }    
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 1;
                openFileDialog.RestoreDirectory = true;
                string result = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;
                    label1.Text = filePath;
                    label1.Refresh();           
                    if (negozio.Equals("Tonfano"))
                    {
                        result= helper.importDataFromCSVAttilia(label1.Text);
                        caricatigw.DataSource = helper.getArticoliFileAttilia().Tables[0];
                        caricatigw.Refresh();
                    }
                    else
                    {
                        result = helper.importDataFromCSV(label1.Text);
                        caricatigw.DataSource = helper.getArticoliFile().Tables[0];
                        caricatigw.Refresh();
                    }                 
                    if (result.Equals(String.Empty))
                    {
                        MessageBox.Show("Carico Terminato ! ", "JacobHUB", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Loadbtn.Enabled = true;
                        
                    }
                    else
                    {
                        MessageBox.Show("Errore:  " + result, "JacobHUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Loadbtn.Enabled = false;
                        label1.Text = "";
                        return;
                    }
                }
            }
        }

        private void Loadbtn_Click(object sender, EventArgs e)
        {
            string cod = "";
            string descr = "";
            string barcode = "";
            decimal prezzo = 0;
            decimal sc1 = 0;
            decimal sc2 = 0;
            int qta = 0;
            string et = Cmbtype.Text;
            if (et.Equals("Et. Gancio Pistola"))
            {
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    cod = row["ar_codart"].ToString();
                    descr = row["ar_descr"].ToString();
                    barcode = row["bc_code"].ToString();
                    prezzo = decimal.Parse(row["prezzo"].ToString());
                    sc1 = decimal.Parse(row["sconto1"].ToString());
                    sc2 = decimal.Parse(row["sconto2"].ToString());
                    qta = int.Parse(row["qta"].ToString());
                    for (int j = 0; j < qta; j++)
                    {
                        helper.Inserttmpet1(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                }
            }
            else
            {
                if (et.Equals("Et. Scaffale Pistola"))
                {
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        cod = row["ar_codart"].ToString();
                        descr = row["ar_descr"].ToString();
                        barcode = row["bc_code"].ToString();
                        prezzo = decimal.Parse(row["prezzo"].ToString());
                        sc1 = decimal.Parse(row["sconto1"].ToString());
                        sc2 = decimal.Parse(row["sconto2"].ToString());
                        qta = int.Parse(row["qta"].ToString());
                        for (int j = 0; j < qta; j++)
                        {
                            helper.Inserttmpet2(cod, descr, barcode, prezzo, sc1, sc2);
                        }
                    }
                }
                else
                {
                    if (et.Equals("Et. Zebra Pistola"))
                    {
                        for (int i = 0; i < gridView1.RowCount; i++)
                        {
                            DataRow row = gridView1.GetDataRow(i);
                            cod = row["ar_codart"].ToString();
                            descr = row["ar_descr"].ToString();
                            barcode = row["bc_code"].ToString();
                            prezzo = decimal.Parse(row["prezzo"].ToString());
                            sc1 = decimal.Parse(row["sconto1"].ToString());
                            sc2 = decimal.Parse(row["sconto2"].ToString());
                            qta = int.Parse(row["qta"].ToString());
                            for (int j = 0; j < qta; j++)
                            {
                                helper.Inserttmpet3(cod, descr, barcode, prezzo, sc1, sc2);
                            }
                        }
                    }
                    else
                    {
                        if (et.Equals("Et. Zebra2 Pistola"))
                        {
                            for (int i = 0; i < gridView1.RowCount; i++)
                            {
                                DataRow row = gridView1.GetDataRow(i);
                                cod = row["ar_codart"].ToString();
                                descr = row["ar_descr"].ToString();
                                barcode = row["bc_code"].ToString();
                                prezzo = decimal.Parse(row["prezzo"].ToString());
                                sc1 = decimal.Parse(row["sconto1"].ToString());
                                sc2 = decimal.Parse(row["sconto2"].ToString());
                                qta = int.Parse(row["qta"].ToString());
                                for (int j = 0; j < qta; j++)
                                {
                                    helper.Inserttmpet4(cod, descr, barcode, prezzo, sc1, sc2);
                                }
                            }
                        }
                        else
                        {
                            MessageBox.Show(" Selezionare un opzione ", "JacobHUB", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            MessageBox.Show("Carico Terminato ! E' possibile stampare le etichette dall'apposita sezione", "JacobHUB", MessageBoxButtons.OK, MessageBoxIcon.Information);
            simpleButton2.Enabled = true;
            Loadbtn.Enabled = false;
        }

        private void Cmbtype_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            string path = "EXPORT.xlsx";

            gridView1.OptionsPrint.ExpandAllDetails = true;
            gridView1.OptionsPrint.PrintDetails = true;

            XlsxExportOptionsEx o = new XlsxExportOptionsEx();
            o.ExportType = DevExpress.Export.ExportType.WYSIWYG;
            //o.CustomizeCell += o_CustomizeCell;
            //DevExpress.XtraPrinting.XlsxExportOptions oXlsExportOptions = new DevExpress.XtraPrinting.XlsxExportOptions { TextExportMode = DevExpress.XtraPrinting.TextExportMode.Value };
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "Excel Documents (*.xls)|*.xls";
            saveFileDialog1.Title = "Save";
            saveFileDialog1.ShowDialog();
            if (!String.IsNullOrEmpty(saveFileDialog1.FileName))
            {
                path = saveFileDialog1.FileName;
            }
            gridView1.ExportToXlsx(path, o);
        }
    }
}