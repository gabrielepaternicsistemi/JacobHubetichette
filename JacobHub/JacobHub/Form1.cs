using DevExpress.XtraBars.Ribbon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JacobHub
{
    public partial class Form1 : DevExpress.XtraBars.Ribbon.RibbonForm
    {

        Datahelper data = new Datahelper();
        string negozio;
        string operat;
        string azienda;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(string operatore)
        {
            InitializeComponent();
            data.removeallfromtmp();
            if (operatore.Equals("Tonfano"))
            {
                azienda = "ATTILIA";
            }
            else
            {
                azienda = "JACOB";
            }
            negozio = operatore;
            operat = operatore;
            if (operatore == "Lucca")
            {
                WBSPC.Visible = false;
                WBSEC.Visible = false;
                BECTC.Visible = false;
                WBSTC.Visible = false;
                WBSPAC.Visible = false;
            }
            else
            {
                if (operatore == "Empoli")
                {
                    WBSPAC.Visible = false;
                    WBSPC.Visible = false;
                    WBSLC.Visible = false;
                    BECTC.Visible = false;
                    WBSTC.Visible = false;
                }
                else
                {
                    if (operatore == "Pontedera")
                    {
                        WBSEC.Visible = false;
                        WBSLC.Visible = false;
                        BECTC.Visible = false;
                        WBSTC.Visible = false;
                        WBSPAC.Visible = false;
                    }
                    else
                    {
                        if (operatore == "Tonfano")
                        {
                            WBSEC.Visible = false;
                            WBSLC.Visible = false;
                            WBSPC.Visible = false;
                            WBSTC.Visible = false;
                            WBSPAC.Visible = false;
                        }
                        else
                        {
                            if (operatore == "Palermo")
                            {
                                WBSEC.Visible = false;
                                WBSLC.Visible = false;
                                WBSPC.Visible = false;
                                WBSTC.Visible = false;
                                BECTC.Visible = false;
                            }
                            else
                            {
                                if (operatore == "Admin")
                                {
                                    WBSPC.Visible = true;
                                    WBSEC.Visible = true;
                                    BECTC.Visible = true;
                                    WBSTC.Visible = true;
                                    WBSPAC.Visible = true;
                                    WBSLC.Visible = true;

                                }
                                else
                                {
                                WBSPAC.Visible = false;
                                WBSEC.Visible = false;
                                WBSLC.Visible = false;
                                WBSPC.Visible = false;
                                BECTC.Visible = false;
                                }

                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //DialogResult dialogResult = MessageBox.Show("Confermi la chiusura", "JacobHub", MessageBoxButtons.YesNo);
            //if (dialogResult == DialogResult.Yes)
            //{
            //    e.Cancel = true;
            //}
            //else
            //{
            //    this.Close();
            //}
        }

        private void ddtbtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            StampaDDT form = new StampaDDT(negozio, azienda);
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void stampabtn_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            ListaArticoli form = new ListaArticoli(negozio, azienda);
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmEtichette frmEticehtte = new FrmEtichette(negozio, azienda);
            frmEticehtte.MdiParent = this;
            frmEticehtte.WindowState = FormWindowState.Maximized;
            frmEticehtte.Show();
        }

        private string setcheckedribbonage(string ribbon)
        {
            string selected;
            if (ribbon.Equals("Best & Cheap Tonfano"))
            {
                return selected = "Tonfano";
            }
            else
            {
                if (ribbon.Equals("Willy Be Smart Lucca"))
                {
                    return selected = "Lucca";
                }
                else
                {
                    if (ribbon.Equals("Willy Be Smart Pontedera"))
                    {
                        return selected = "Pontedera";
                    }
                    else
                    {
                        if (ribbon.Equals("Willy Be Smart Tonfano"))
                        {
                            return selected = "WTonfano";
                        }
                        else
                        {
                            if (ribbon.Equals("Willy Be Smart Palermo"))
                            {
                                return selected = "Palermo";
                            }
                            else
                            {
                            return selected = "Empoli";
                            }
                        }
                    }
                }
            }
        }

        private void barButtonItem12_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmInventario frmInventario = new FrmInventario(negozio, azienda);
            frmInventario.MdiParent = this;
            frmInventario.WindowState = FormWindowState.Maximized;
            frmInventario.Show();
        }

        private void barButtonItem13_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmInventario frmInventario = new FrmInventario(negozio, azienda);
            frmInventario.MdiParent = this;
            frmInventario.WindowState = FormWindowState.Maximized;
            frmInventario.Show();
        }

        private void barButtonItem14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmInventario frmInventario = new FrmInventario(negozio, azienda);
            frmInventario.MdiParent = this;
            frmInventario.WindowState = FormWindowState.Maximized;
            frmInventario.Show();
        }

        private void barButtonItem15_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmInventario frmInventario = new FrmInventario(negozio, azienda);
            frmInventario.MdiParent = this;
            frmInventario.WindowState = FormWindowState.Maximized;
            frmInventario.Show();
        }

        private void barButtonItem16_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            ListaArticoli form = new ListaArticoli(negozio, azienda);
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem17_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            StampaDDT form = new StampaDDT(negozio, azienda);
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void barButtonItem19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmInventario frmInventario = new FrmInventario(negozio, azienda);
            frmInventario.MdiParent = this;
            frmInventario.WindowState = FormWindowState.Maximized;
            frmInventario.Show();
        }

        private void barButtonItem18_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RibbonPage c = Ribbon.SelectedPage;
            string op = c.Text;
            negozio = setcheckedribbonage(op);
            FrmEtichetteAtt frmEticehtte = new FrmEtichetteAtt(negozio, azienda);
            frmEticehtte.MdiParent = this;
            frmEticehtte.WindowState = FormWindowState.Maximized;
            frmEticehtte.Show();
        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
