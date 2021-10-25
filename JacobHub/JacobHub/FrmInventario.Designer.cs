namespace JacobHub
{
    partial class FrmInventario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInventario));
            this.Exportbtn = new System.Windows.Forms.GroupBox();
            this.Cmbtype = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Loadbtn = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.caricatigw = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ar_codart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ar_descr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.bc_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qta = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prezzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sconto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sconto2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Exportbtn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbtype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.caricatigw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Exportbtn
            // 
            this.Exportbtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Exportbtn.Controls.Add(this.Cmbtype);
            this.Exportbtn.Controls.Add(this.simpleButton2);
            this.Exportbtn.Controls.Add(this.label1);
            this.Exportbtn.Controls.Add(this.Loadbtn);
            this.Exportbtn.Controls.Add(this.simpleButton1);
            this.Exportbtn.Location = new System.Drawing.Point(10, 11);
            this.Exportbtn.Name = "Exportbtn";
            this.Exportbtn.Size = new System.Drawing.Size(1470, 69);
            this.Exportbtn.TabIndex = 0;
            this.Exportbtn.TabStop = false;
            // 
            // Cmbtype
            // 
            this.Cmbtype.EditValue = "";
            this.Cmbtype.Location = new System.Drawing.Point(153, 32);
            this.Cmbtype.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cmbtype.Name = "Cmbtype";
            this.Cmbtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Cmbtype.Properties.DisplayMember = "nome";
            this.Cmbtype.Properties.PopupView = this.gridLookUpEdit1View;
            this.Cmbtype.Properties.ValueMember = "id";
            this.Cmbtype.Size = new System.Drawing.Size(204, 20);
            this.Cmbtype.TabIndex = 7;
            this.Cmbtype.EditValueChanged += new System.EventHandler(this.Cmbtype_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Enabled = false;
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(525, 20);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(174, 38);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "Esporta Tabella";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(602, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // Loadbtn
            // 
            this.Loadbtn.Enabled = false;
            this.Loadbtn.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("Loadbtn.ImageOptions.Image")));
            this.Loadbtn.Location = new System.Drawing.Point(375, 20);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(144, 39);
            this.Loadbtn.TabIndex = 1;
            this.Loadbtn.Text = "Carica Su Database";
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(20, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(114, 40);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Aggungi file";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.caricatigw);
            this.groupBox2.Location = new System.Drawing.Point(12, 86);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1467, 644);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // caricatigw
            // 
            this.caricatigw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.caricatigw.Location = new System.Drawing.Point(6, 20);
            this.caricatigw.MainView = this.gridView1;
            this.caricatigw.Name = "caricatigw";
            this.caricatigw.Size = new System.Drawing.Size(1455, 618);
            this.caricatigw.TabIndex = 0;
            this.caricatigw.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ar_codart,
            this.ar_descr,
            this.bc_code,
            this.qta,
            this.prezzo,
            this.sconto1,
            this.sconto2});
            this.gridView1.GridControl = this.caricatigw;
            this.gridView1.Name = "gridView1";
            // 
            // ar_codart
            // 
            this.ar_codart.Caption = "Cod. Articolo";
            this.ar_codart.FieldName = "ar_codart";
            this.ar_codart.Name = "ar_codart";
            this.ar_codart.Visible = true;
            this.ar_codart.VisibleIndex = 0;
            // 
            // ar_descr
            // 
            this.ar_descr.Caption = "Descrizione";
            this.ar_descr.FieldName = "ar_descr";
            this.ar_descr.Name = "ar_descr";
            this.ar_descr.Visible = true;
            this.ar_descr.VisibleIndex = 1;
            // 
            // bc_code
            // 
            this.bc_code.Caption = "Barcode";
            this.bc_code.FieldName = "bc_code";
            this.bc_code.Name = "bc_code";
            this.bc_code.Visible = true;
            this.bc_code.VisibleIndex = 2;
            // 
            // qta
            // 
            this.qta.Caption = "Quantità";
            this.qta.FieldName = "qta";
            this.qta.Name = "qta";
            this.qta.Visible = true;
            this.qta.VisibleIndex = 3;
            // 
            // prezzo
            // 
            this.prezzo.Caption = "Prezzo";
            this.prezzo.FieldName = "prezzo";
            this.prezzo.Name = "prezzo";
            this.prezzo.Visible = true;
            this.prezzo.VisibleIndex = 4;
            // 
            // sconto1
            // 
            this.sconto1.Caption = "Sconto 1 ";
            this.sconto1.FieldName = "sconto1";
            this.sconto1.Name = "sconto1";
            this.sconto1.Visible = true;
            this.sconto1.VisibleIndex = 5;
            // 
            // sconto2
            // 
            this.sconto2.Caption = "Sconto 2 ";
            this.sconto2.FieldName = "sconto2";
            this.sconto2.Name = "sconto2";
            this.sconto2.Visible = true;
            this.sconto2.VisibleIndex = 6;
            // 
            // FrmInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1491, 743);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Exportbtn);
            this.Name = "FrmInventario";
            this.Text = "FrmInventario";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmInventario_Load);
            this.Exportbtn.ResumeLayout(false);
            this.Exportbtn.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cmbtype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.caricatigw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Exportbtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraGrid.GridControl caricatigw;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton Loadbtn;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn ar_codart;
        private DevExpress.XtraGrid.Columns.GridColumn ar_descr;
        private DevExpress.XtraGrid.Columns.GridColumn bc_code;
        private DevExpress.XtraGrid.Columns.GridColumn qta;
        private DevExpress.XtraGrid.Columns.GridColumn prezzo;
        private DevExpress.XtraGrid.Columns.GridColumn sconto1;
        private DevExpress.XtraGrid.Columns.GridColumn sconto2;
        private DevExpress.XtraEditors.GridLookUpEdit Cmbtype;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
    }
}