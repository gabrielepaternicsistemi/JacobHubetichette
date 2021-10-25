namespace JacobHub
{
    partial class XtraFormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbOperatore = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pwdTxb = new System.Windows.Forms.TextBox();
            this.LogBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperatore.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbOperatore
            // 
            this.cmbOperatore.EditValue = "";
            this.cmbOperatore.Location = new System.Drawing.Point(21, 42);
            this.cmbOperatore.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbOperatore.Name = "cmbOperatore";
            this.cmbOperatore.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbOperatore.Properties.DisplayMember = "op_name";
            this.cmbOperatore.Properties.PopupView = this.gridLookUpEdit1View;
            this.cmbOperatore.Properties.ValueMember = "op_name";
            this.cmbOperatore.Size = new System.Drawing.Size(284, 20);
            this.cmbOperatore.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // pwdTxb
            // 
            this.pwdTxb.Location = new System.Drawing.Point(21, 78);
            this.pwdTxb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pwdTxb.Name = "pwdTxb";
            this.pwdTxb.Size = new System.Drawing.Size(284, 21);
            this.pwdTxb.TabIndex = 1;
            this.pwdTxb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pwdTxb_KeyDown);
            // 
            // LogBtn
            // 
            this.LogBtn.Location = new System.Drawing.Point(21, 134);
            this.LogBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LogBtn.Name = "LogBtn";
            this.LogBtn.Size = new System.Drawing.Size(284, 24);
            this.LogBtn.TabIndex = 2;
            this.LogBtn.Text = "Accedi";
            this.LogBtn.Click += new System.EventHandler(this.LogBtn_Click);
            // 
            // XtraFormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 215);
            this.Controls.Add(this.LogBtn);
            this.Controls.Add(this.pwdTxb);
            this.Controls.Add(this.cmbOperatore);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "XtraFormLogin";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.XtraFormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cmbOperatore.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GridLookUpEdit cmbOperatore;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private System.Windows.Forms.TextBox pwdTxb;
        private DevExpress.XtraEditors.SimpleButton LogBtn;
    }
}