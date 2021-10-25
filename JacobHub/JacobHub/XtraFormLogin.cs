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
    public partial class XtraFormLogin : DevExpress.XtraEditors.XtraForm
    {

        Datahelper data = new Datahelper();

        public XtraFormLogin()
        {
            InitializeComponent();
        }

        private void XtraFormLogin_Load(object sender, EventArgs e)
        {
            cmbOperatore.Properties.DataSource = data.getOperatori().Tables[0];
            pwdTxb.PasswordChar = '*';
        }

        //login
        private void LogBtn_Click(object sender, EventArgs e)
        {
            controllouser();
        }

        private void pwdTxb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                controllouser();
            }
        }

        private void controllouser()
        {
            string operatore = cmbOperatore.Text;
            if (operatore == "Lucca" && pwdTxb.Text == "Lucca123!")
            {
                Form1 form1 = new Form1(operatore);
                form1.Show();
                //this.Hide();
            }
            else
            {
                if (operatore == "Empoli" && pwdTxb.Text == "Empoli123!")
                {
                    Form1 form1 = new Form1(operatore);
                    form1.Show();
                    //this.Hide();
                }
                else
                {
                    if (operatore == "Pontedera" && pwdTxb.Text == "Pontedera123!")
                    {
                        Form1 form1 = new Form1(operatore);
                        form1.Show();
                        //this.Hide();
                    }
                    else
                    {
                        if (operatore == "Tonfano" && pwdTxb.Text == "Tonfano123!")
                        {
                            Form1 form1 = new Form1(operatore);
                            form1.Show();
                            //this.Hide();
                        }
                        else
                        {
                            if (operatore == "Admin" && pwdTxb.Text == "Admin123!")
                            {
                                Form1 form1 = new Form1(operatore);
                                form1.Show();
                                //this.Hide();
                            }
                            else
                            {
                                if (operatore == "WTonfano" && pwdTxb.Text == "WTonfano123!")
                                {
                                    Form1 form1 = new Form1(operatore);
                                    form1.Show();
                                    //this.Hide();
                                }
                                else
                                {
                                    if (operatore == "Palermo" && pwdTxb.Text == "Palermo123!")
                                    {
                                        Form1 form1 = new Form1(operatore);
                                        form1.Show();
                                        //this.Hide();
                                    }
                                    else
                                    {
                                        DialogResult dialogResult = MessageBox.Show("Errore Di Accesso, Perfavore Riprovare", "JacobHub", MessageBoxButtons.OK);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

    }
}