namespace JacobHub
{
    partial class StampaDDT
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
            DevExpress.XtraGrid.GridFormatRule gridFormatRule1 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue1 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule2 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue2 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            DevExpress.XtraGrid.GridFormatRule gridFormatRule3 = new DevExpress.XtraGrid.GridFormatRule();
            DevExpress.XtraEditors.FormatConditionRuleValue formatConditionRuleValue3 = new DevExpress.XtraEditors.FormatConditionRuleValue();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StampaDDT));
            this.et1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.et2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.et3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ddtgw = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.mm_codart = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_descr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mm_quant = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.prezzo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sc1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sc2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.label1 = new System.Windows.Forms.Label();
            this.Ddtcmb = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.et4 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ddtgw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ddtcmb.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // et1
            // 
            this.et1.Caption = "Etichetta 1";
            this.et1.FieldName = "et1";
            this.et1.Name = "et1";
            this.et1.Visible = true;
            this.et1.VisibleIndex = 7;
            this.et1.Width = 60;
            // 
            // et2
            // 
            this.et2.Caption = "Etichetta 2";
            this.et2.FieldName = "et2";
            this.et2.Name = "et2";
            this.et2.Visible = true;
            this.et2.VisibleIndex = 8;
            this.et2.Width = 60;
            // 
            // et3
            // 
            this.et3.Caption = "Etichetta 3";
            this.et3.FieldName = "et3";
            this.et3.Name = "et3";
            this.et3.Visible = true;
            this.et3.VisibleIndex = 9;
            this.et3.Width = 60;
            // 
            // ddtgw
            // 
            this.ddtgw.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ddtgw.EmbeddedNavigator.Margin = new System.Windows.Forms.Padding(2);
            this.ddtgw.Location = new System.Drawing.Point(5, 18);
            this.ddtgw.MainView = this.gridView1;
            this.ddtgw.Margin = new System.Windows.Forms.Padding(2);
            this.ddtgw.Name = "ddtgw";
            this.ddtgw.Size = new System.Drawing.Size(1176, 447);
            this.ddtgw.TabIndex = 0;
            this.ddtgw.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.ddtgw.Click += new System.EventHandler(this.ddtgw_Click);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.mm_codart,
            this.mm_descr,
            this.mm_quant,
            this.barcode,
            this.prezzo,
            this.sc1,
            this.sc2,
            this.et1,
            this.et2,
            this.et3,
            this.et4});
            this.gridView1.DetailHeight = 280;
            gridFormatRule1.ApplyToRow = true;
            gridFormatRule1.Column = this.et1;
            gridFormatRule1.Name = "Format0";
            formatConditionRuleValue1.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue1.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue1.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue1.Value1 = ((short)(0));
            gridFormatRule1.Rule = formatConditionRuleValue1;
            gridFormatRule2.ApplyToRow = true;
            gridFormatRule2.Column = this.et2;
            gridFormatRule2.Name = "Format1";
            formatConditionRuleValue2.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue2.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue2.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue2.Value1 = ((short)(0));
            gridFormatRule2.Rule = formatConditionRuleValue2;
            gridFormatRule3.ApplyToRow = true;
            gridFormatRule3.Column = this.et3;
            gridFormatRule3.Name = "Format2";
            formatConditionRuleValue3.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            formatConditionRuleValue3.Appearance.Options.UseBackColor = true;
            formatConditionRuleValue3.Condition = DevExpress.XtraEditors.FormatCondition.Greater;
            formatConditionRuleValue3.Value1 = ((short)(0));
            gridFormatRule3.Rule = formatConditionRuleValue3;
            this.gridView1.FormatRules.Add(gridFormatRule1);
            this.gridView1.FormatRules.Add(gridFormatRule2);
            this.gridView1.FormatRules.Add(gridFormatRule3);
            this.gridView1.GridControl = this.ddtgw;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // mm_codart
            // 
            this.mm_codart.Caption = "Articolo";
            this.mm_codart.FieldName = "mm_codart";
            this.mm_codart.Name = "mm_codart";
            this.mm_codart.Visible = true;
            this.mm_codart.VisibleIndex = 0;
            this.mm_codart.Width = 60;
            // 
            // mm_descr
            // 
            this.mm_descr.Caption = "Descrizione";
            this.mm_descr.FieldName = "mm_descr";
            this.mm_descr.Name = "mm_descr";
            this.mm_descr.Visible = true;
            this.mm_descr.VisibleIndex = 1;
            this.mm_descr.Width = 60;
            // 
            // mm_quant
            // 
            this.mm_quant.Caption = "Quantità";
            this.mm_quant.FieldName = "mm_quant";
            this.mm_quant.Name = "mm_quant";
            this.mm_quant.Visible = true;
            this.mm_quant.VisibleIndex = 2;
            this.mm_quant.Width = 60;
            // 
            // barcode
            // 
            this.barcode.Caption = "Barcode";
            this.barcode.FieldName = "Barcode";
            this.barcode.Name = "barcode";
            this.barcode.Visible = true;
            this.barcode.VisibleIndex = 3;
            this.barcode.Width = 94;
            // 
            // prezzo
            // 
            this.prezzo.Caption = "Prezzo";
            this.prezzo.FieldName = "prezzo";
            this.prezzo.Name = "prezzo";
            this.prezzo.Visible = true;
            this.prezzo.VisibleIndex = 4;
            this.prezzo.Width = 94;
            // 
            // sc1
            // 
            this.sc1.Caption = "Sconto 1";
            this.sc1.FieldName = "sc1";
            this.sc1.Name = "sc1";
            this.sc1.Visible = true;
            this.sc1.VisibleIndex = 5;
            // 
            // sc2
            // 
            this.sc2.Caption = "Sconto 2";
            this.sc2.FieldName = "sc2";
            this.sc2.Name = "sc2";
            this.sc2.Visible = true;
            this.sc2.VisibleIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ddtgw);
            this.groupBox1.Location = new System.Drawing.Point(10, 86);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(1198, 495);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.simpleButton2);
            this.groupBox2.Controls.Add(this.simpleButton1);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.Ddtcmb);
            this.groupBox2.Location = new System.Drawing.Point(10, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(1198, 71);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(405, 37);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(120, 23);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "Genera Etichette";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(272, 37);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(100, 23);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Applica Filtro";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "DDT ";
            // 
            // Ddtcmb
            // 
            this.Ddtcmb.Location = new System.Drawing.Point(5, 40);
            this.Ddtcmb.Margin = new System.Windows.Forms.Padding(2);
            this.Ddtcmb.Name = "Ddtcmb";
            this.Ddtcmb.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Ddtcmb.Properties.DisplayMember = "Chiave";
            this.Ddtcmb.Properties.PopupView = this.gridLookUpEdit1View;
            this.Ddtcmb.Properties.ValueMember = "Chiave";
            this.Ddtcmb.Size = new System.Drawing.Size(262, 20);
            this.Ddtcmb.TabIndex = 0;
            this.Ddtcmb.EditValueChanged += new System.EventHandler(this.Ddtcmb_EditValueChanged);
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // et4
            // 
            this.et4.Caption = "Etichetta4";
            this.et4.FieldName = "er4";
            this.et4.Name = "et4";
            this.et4.Visible = true;
            this.et4.VisibleIndex = 10;
            // 
            // StampaDDT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(1217, 590);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "StampaDDT";
            this.Text = "DDT";
            this.Load += new System.EventHandler(this.StampaDDT_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ddtgw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ddtcmb.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl ddtgw;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.GridLookUpEdit Ddtcmb;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn mm_codart;
        private DevExpress.XtraGrid.Columns.GridColumn mm_descr;
        private DevExpress.XtraGrid.Columns.GridColumn mm_quant;
        private DevExpress.XtraGrid.Columns.GridColumn et1;
        private DevExpress.XtraGrid.Columns.GridColumn et2;
        private DevExpress.XtraGrid.Columns.GridColumn et3;
        private DevExpress.XtraGrid.Columns.GridColumn barcode;
        private DevExpress.XtraGrid.Columns.GridColumn prezzo;
        private DevExpress.XtraGrid.Columns.GridColumn sc1;
        private DevExpress.XtraGrid.Columns.GridColumn sc2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraGrid.Columns.GridColumn et4;
    }
}