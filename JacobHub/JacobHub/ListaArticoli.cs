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

namespace JacobHub
{
    public partial class ListaArticoli : DevExpress.XtraEditors.XtraForm
    {
        Datahelper data = new Datahelper();
        string negozio = "";
        string azienda = "";

        public ListaArticoli()
        {
            InitializeComponent();
        }

        public ListaArticoli(string n, string a)
        {
            InitializeComponent();
            negozio = n;
            azienda = a;
        }

        private void ListaArticoli_Load(object sender, EventArgs e)
        {
            if (negozio.Equals("Tonfano"))
            {
                Articolocmb.Properties.DataSource = data.getArticoliAttilia().Tables[0];
                //Codbarrecmb.Properties.DataSource = data.getArticoli().Tables[0];
                Maingw.DataSource = data.getArticoliGrigliaAttilia().Tables[0];
            }
            else
            {
                Articolocmb.Properties.DataSource = data.getArticoli().Tables[0];
                //Codbarrecmb.Properties.DataSource = data.getArticoli().Tables[0];
                Maingw.DataSource = data.getArticoliGriglia().Tables[0];
            }
        }

        private void Filtribtn_Click(object sender, EventArgs e)
        {
            string codart = Articolocmb.EditValue.ToString();
        }

        private void Filtri_Enter(object sender, EventArgs e)
        {

        }


        private void Addbtn_Click(object sender, EventArgs e)
        {
            string codart = gridView3.GetFocusedDataRow()["ar_codart"].ToString();
            string descr = gridView3.GetFocusedDataRow()["ar_descr"].ToString();
            string barcode = gridView3.GetFocusedDataRow()["barcode"].ToString();
            decimal prezzo = decimal.Parse(gridView3.GetFocusedDataRow()["prezzo"].ToString());
            decimal scont1 = decimal.Parse(gridView3.GetFocusedDataRow()["sconto1"].ToString());
            decimal scont2 = decimal.Parse(gridView3.GetFocusedDataRow()["sconto2"].ToString());
            if (negozio.Equals("Tonfano"))
            {
                data.inserisciArticoAttilia(codart, descr, barcode, prezzo, scont1, scont2);
                Articogw.DataSource = data.getTmpArticoAttilia().Tables[0];
                Articogw.Refresh();
            }
            else
            {
                data.inserisciArtico(codart, descr, barcode, prezzo, scont1, scont2);
                Articogw.DataSource = data.getTmpArtico().Tables[0];
                Articogw.Refresh();
            }                 
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string codart = gridView1.GetFocusedDataRow()["xx_codart"].ToString();
            if (negozio.Equals("Tonfano"))
            {
                data.removeArticoAttilia(codart);
                Articogw.DataSource = data.getTmpArticoAttilia().Tables[0];
                Articogw.Refresh();
            }
            else
            {
                data.removeArtico(codart);
                Articogw.DataSource = data.getTmpArtico().Tables[0];
                Articogw.Refresh();
            }                
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
        {
            {
                string cod = "";
                int et1 = 0;
                int et2 = 0;
                int et3 = 0;
                int et4 = 0;
                string descr = "";
                decimal prezzo;
                decimal sc1;
                decimal sc2;
                string barcode = "";

                foreach (int i in gridView1.GetSelectedRows())
                {
                    DataRow row = gridView1.GetDataRow(i);
                    cod = row["xx_codart"].ToString();
                    et1 = int.Parse(row["xx_et1"].ToString());
                    et2 = int.Parse(row["xx_et2"].ToString());
                    et3 = int.Parse(row["xx_et3"].ToString());
                    et4 = int.Parse(row["xx_et4"].ToString());
                    descr = row["xx_descr"].ToString();
                    barcode = row["xx_barcode"].ToString();
                    prezzo = decimal.Parse(row["xx_prezzo"].ToString());
                    sc1 = decimal.Parse(row["xx_sconto1"].ToString());
                    sc2 = decimal.Parse(row["xx_sconto2"].ToString());
                    if (negozio.Equals("Tonfano"))
                    {
                        data.UpdateTmpArticoAttilia(cod, descr, barcode, prezzo, sc1, sc2, et1, et2, et3, et4);
                        Articogw.DataSource = data.getTmpArticoAttilia().Tables[0];
                        Articogw.Refresh();
                    }
                    else
                    {
                        data.UpdateTmpArtico(cod, descr, barcode, prezzo, sc1, sc2, et1, et2, et3,et4);
                        Articogw.DataSource = data.getTmpArtico().Tables[0];
                        Articogw.Refresh();
                    }                    
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            if (negozio.Equals("Tonfano"))
            {
                data.removeallfromtmpAttilia();
                Articogw.DataSource = data.getTmpArticoAttilia().Tables[0];
                Articogw.Refresh();
            }
            else
            {
                data.removeallfromtmp();
                Articogw.DataSource = data.getTmpArtico().Tables[0];
                Articogw.Refresh();
            }            
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string cod = "";
            string descr = "";
            string barcode = "";
            decimal prezzo = 0;
            decimal sc1 = 0;
            decimal sc2 = 0;
            int et1 = 0;
            int et2 = 0;
            int et3 = 0;
            int et4 = 0;

            for (int i= 0; i< gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                cod = row["xx_codart"].ToString();
                descr = row["xx_descr"].ToString();
                barcode = row["xx_barcode"].ToString();
                prezzo = decimal.Parse(row["xx_prezzo"].ToString());
                sc1 = decimal.Parse(row["xx_sconto1"].ToString());
                sc2 = decimal.Parse(row["xx_sconto2"].ToString());
                et1 = int.Parse(row["xx_et1"].ToString());
                et2 = int.Parse(row["xx_et2"].ToString());
                et3 = int.Parse(row["xx_et3"].ToString());
                et4 = int.Parse(row["xx_et4"].ToString());

                if (negozio.Equals("Tonfano"))
                {
                    for (int j = 0; j < et1; j++)
                    {
                        data.Inserttmpet1Attilia(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                    for (int k = 0; k < et2; k++)
                    {
                        data.Inserttmpet2Attilia(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                    for (int h = 0; h < et3; h++)
                    {
                        data.Inserttmpet3Attilia(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                    for (int m = 0; m < et4; m++)
                    {
                        data.Inserttmpet4Attilia(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                }
                else
                {
                    for (int j = 0; j < et1; j++)
                    {
                        data.Inserttmpet1(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                    for (int k = 0; k < et2; k++)
                    {
                        data.Inserttmpet2(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                    for (int h = 0; h < et3; h++)
                    {
                        data.Inserttmpet3(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                    for (int m = 0; m < et4; m++)
                    {
                        data.Inserttmpet4(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                }
                
            }

        }

        private void Filtribtn_Click_1(object sender, EventArgs e)
        {

        }

        private void Articogw_Click(object sender, EventArgs e)
        {

        }
    }
} 