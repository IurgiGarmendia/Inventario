namespace Inventario
{
    partial class EntityInner
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
            this.pLinqInstantFeedbackSource1 = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCOD_LOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCODALMACEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button1 = new System.Windows.Forms.Button();
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
            // pLinqInstantFeedbackSource1
            // 
            this.pLinqInstantFeedbackSource1.DefaultSorting = "COD_LOTE ASC";
            this.pLinqInstantFeedbackSource1.DesignTimeElementType = typeof(Inventario.App_Code.Model.LOTES);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCOD_LOTE,
            this.colLOTE,
            this.colCODALMACEN,
            this.colIDENT});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // colCOD_LOTE
            // 
            this.colCOD_LOTE.FieldName = "COD_LOTE";
            this.colCOD_LOTE.MinWidth = 25;
            this.colCOD_LOTE.Name = "colCOD_LOTE";
            this.colCOD_LOTE.Visible = true;
            this.colCOD_LOTE.VisibleIndex = 0;
            this.colCOD_LOTE.Width = 94;
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
            // colCODALMACEN
            // 
            this.colCODALMACEN.FieldName = "CODALMACEN";
            this.colCODALMACEN.MinWidth = 25;
            this.colCODALMACEN.Name = "colCODALMACEN";
            this.colCODALMACEN.Visible = true;
            this.colCODALMACEN.VisibleIndex = 2;
            this.colCODALMACEN.Width = 94;
            // 
            // colIDENT
            // 
            this.colIDENT.Caption = "IDENT";
            this.colIDENT.FieldName = "IDENT";
            this.colIDENT.MinWidth = 25;
            this.colIDENT.Name = "colIDENT";
            this.colIDENT.Visible = true;
            this.colIDENT.VisibleIndex = 3;
            this.colIDENT.Width = 94;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 399);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EntityInner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "EntityInner";
            this.Text = "EntityInner";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_LOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colCODALMACEN;
        private DevExpress.Data.PLinq.PLinqInstantFeedbackSource pLinqInstantFeedbackSource1;
        private DevExpress.XtraGrid.Columns.GridColumn colIDENT;
        private System.Windows.Forms.Button button1;
    }
}