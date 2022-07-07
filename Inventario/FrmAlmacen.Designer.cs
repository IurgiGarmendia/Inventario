namespace Inventario
{
    partial class FrmAlmacen
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.colCODIGO = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPEDIDOALM = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.pLinqInstantFeedbackSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODIGO,
            this.colLOTE,
            this.colPEDIDOALM});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "CODIGO ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(Inventario.App_Code.Model.ENTRADAALM);
            // 
            // colCODIGO
            // 
            this.colCODIGO.FieldName = "CODIGO";
            this.colCODIGO.MinWidth = 25;
            this.colCODIGO.Name = "colCODIGO";
            this.colCODIGO.Visible = true;
            this.colCODIGO.VisibleIndex = 0;
            this.colCODIGO.Width = 94;
            // 
            // colLOTE
            // 
            this.colLOTE.FieldName = "LOTE";
            this.colLOTE.MinWidth = 25;
            this.colLOTE.Name = "colLOTE";
            this.colLOTE.Visible = true;
            this.colLOTE.VisibleIndex = 1;
            this.colLOTE.Width = 94;
            // 
            // colPEDIDOALM
            // 
            this.colPEDIDOALM.FieldName = "PEDIDOALM";
            this.colPEDIDOALM.MinWidth = 25;
            this.colPEDIDOALM.Name = "colPEDIDOALM";
            this.colPEDIDOALM.Visible = true;
            this.colPEDIDOALM.VisibleIndex = 2;
            this.colPEDIDOALM.Width = 94;
            // 
            // FrmAlmacen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmAlmacen";
            this.Text = "FrmAlmacen";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colCODIGO;
        private DevExpress.XtraGrid.Columns.GridColumn colLOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colPEDIDOALM;
    }
}