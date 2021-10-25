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
    public partial class StampaDDT : DevExpress.XtraEditors.XtraForm
    {

        Datahelper data = new Datahelper();
        string sezionale;
        string azienda = "";

        public StampaDDT()
        {
            InitializeComponent();
        }

        public StampaDDT(string negozio, string a)
        {
            InitializeComponent();
            azienda = a;
            if (negozio.Equals("Lucca"))
            {
                sezionale = "10";
            }
            else
            {
                if (negozio.Equals("Pontedera"))
                {
                    sezionale = "18";
                }
                else
                {
                    if (negozio.Equals("Empoli"))
                    {
                        sezionale = "16";
                    }
                    else
                    {
                        if (negozio.Equals("WTonfano"))
                        {
                            sezionale = "16";
                        }
                        else
                        {
                            if (negozio.Equals("Palermo"))
                            {
                                sezionale = "4";
                            }
                            else
                            {
                                sezionale = "1";
                            }
                        }
                    }
                }
            }
        }

        private void StampaDDT_Load(object sender, EventArgs e)
        {
            if (sezionale == "1")
            {
                Ddtcmb.Properties.DataSource = data.getddtAttilia(sezionale).Tables[0];
            }
            else
            {
                if (sezionale == "4")
                {
                    Ddtcmb.Properties.DataSource = data.getFatture(sezionale).Tables[0];
                }
                else
                {
                    Ddtcmb.Properties.DataSource = data.getddt(sezionale).Tables[0];
                }
            }
        }

        private void aggiornaGriglia(string ddt)
        {
            string cod = "";
            int et1 = 0;
            int et2 = 0;
            int et3 = 0;
            string descr = "";
            decimal prezzo;
            decimal sc1;
            decimal sc2;
            string barcode = "";
            if (sezionale == "1")
            {
                ddtgw.DataSource = data.getArticolifrommovmagAttilia(ddt).Tables[0];
                for (int i = 0; i < gridView1.RowCount; i++)
                {
                    DataRow row = gridView1.GetDataRow(i);
                    cod = row["mm_codart"].ToString();
                    et1 = int.Parse(row["et1"].ToString());
                    et2 = int.Parse(row["et2"].ToString());
                    et3 = int.Parse(row["et3"].ToString());
                    descr = row["mm_descr"].ToString();
                    barcode = row["Barcode"].ToString();
                    prezzo = decimal.Parse(row["prezzo"].ToString());
                    sc1 = decimal.Parse(row["sc1"].ToString());
                    sc2 = decimal.Parse(row["sc2"].ToString());
                    data.inserisciArticoAttilia(cod, descr, barcode, prezzo, sc1, sc2);

                }

            }
            else
            {
                if (sezionale == "4")
                {
                    ddtgw.DataSource = data.getArticolifrommovmagfatt(ddt).Tables[0];
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        cod = row["mm_codart"].ToString();
                        et1 = int.Parse(row["et1"].ToString());
                        et2 = int.Parse(row["et2"].ToString());
                        et3 = int.Parse(row["et3"].ToString());
                        descr = row["mm_descr"].ToString();
                        barcode = row["Barcode"].ToString();
                        prezzo = decimal.Parse(row["prezzo"].ToString());
                        sc1 = decimal.Parse(row["sc1"].ToString());
                        sc2 = decimal.Parse(row["sc2"].ToString());
                        data.inserisciArtico(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                }
                else
                {
                    ddtgw.DataSource = data.getArticolifrommovmag(ddt).Tables[0];
                    for (int i = 0; i < gridView1.RowCount; i++)
                    {
                        DataRow row = gridView1.GetDataRow(i);
                        cod = row["mm_codart"].ToString();
                        et1 = int.Parse(row["et1"].ToString());
                        et2 = int.Parse(row["et2"].ToString());
                        et3 = int.Parse(row["et3"].ToString());
                        descr = row["mm_descr"].ToString();
                        barcode = row["Barcode"].ToString();
                        prezzo = decimal.Parse(row["prezzo"].ToString());
                        sc1 = decimal.Parse(row["sc1"].ToString());
                        sc2 = decimal.Parse(row["sc2"].ToString());
                        data.inserisciArtico(cod, descr, barcode, prezzo, sc1, sc2);
                    }
                }
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            string ddt = Ddtcmb.Text.ToString();
            if (sezionale == "1")
            {
                data.removeallfromtmpAttilia();
            }
            else
            {
                data.removeallfromtmp();
            }
            aggiornaGriglia(ddt);
        }

        private void gridView1_RowUpdated(object sender, DevExpress.XtraGrid.Views.Base.RowObjectEventArgs e)
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
                cod = row["mm_codart"].ToString();
                et1 = int.Parse(row["et1"].ToString());
                et2 = int.Parse(row["et2"].ToString());
                et3 = int.Parse(row["et3"].ToString());
                et4 = int.Parse(row["et4"].ToString());
                descr = row["mm_descr"].ToString();
                barcode = row["Barcode"].ToString();
                prezzo = decimal.Parse(row["prezzo"].ToString());
                sc1 = decimal.Parse(row["sc1"].ToString());
                sc2 = decimal.Parse(row["sc2"].ToString());
                if (sezionale == "1")
                {
                    data.UpdateTmpArticoAttilia(cod, descr, barcode, prezzo, sc1, sc2, et1, et2, et3, et4);
                    //ddtgw.DataSource = data.getTmpArticoAttilia().Tables[0];
                    //ddtgw.Refresh();
                }
                else
                {
                    data.UpdateTmpArtico(cod, descr, barcode, prezzo, sc1, sc2, et1, et2, et3, et4);
                    //ddtgw.DataSource = data.getTmpArtico().Tables[0];
                    //ddtgw.Refresh();
                }
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
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

            for (int i = 0; i < gridView1.RowCount; i++)
            {
                DataRow row = gridView1.GetDataRow(i);
                cod = row["mm_codart"].ToString();
                et1 = int.Parse(row["et1"].ToString());
                et2 = int.Parse(row["et2"].ToString());
                et3 = int.Parse(row["et3"].ToString());
                et4 = int.Parse(row["et4"].ToString());
                descr = row["mm_descr"].ToString();
                barcode = row["Barcode"].ToString();
                prezzo = decimal.Parse(row["prezzo"].ToString());
                sc1 = decimal.Parse(row["sc1"].ToString());
                sc2 = decimal.Parse(row["sc2"].ToString());

                if (sezionale == "1")
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

        private void Ddtcmb_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void ddtgw_Click(object sender, EventArgs e)
        {

        }
    }
}