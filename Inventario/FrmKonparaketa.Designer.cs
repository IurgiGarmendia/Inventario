namespace Inventario
{
    partial class FrmKonparaketa
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
            this.components = new System.ComponentModel.Container();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.entityServerModeSource1 = new DevExpress.Data.Linq.EntityServerModeSource();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCODALMACEN = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDENT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCOD_LOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLOTE = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dBAlmaceneschBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAlmaceneschBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.entityServerModeSource1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(800, 450);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // entityServerModeSource1
            // 
            this.entityServerModeSource1.DefaultSorting = "CODALMACEN ASC";
            this.entityServerModeSource1.ElementType = typeof(Inventario.App_Code.Model.ALMACENESCH);
            this.entityServerModeSource1.KeyExpression = "CODALMACEN";
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCODALMACEN,
            this.colIDENT,
            this.colCOD_LOTE,
            this.colLOTE});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowUpdated += new DevExpress.XtraGrid.Views.Base.RowObjectEventHandler(this.gridView1_RowUpdated);
            // 
            // colCODALMACEN
            // 
            this.colCODALMACEN.FieldName = "CODALMACEN";
            this.colCODALMACEN.MinWidth = 25;
            this.colCODALMACEN.Name = "colCODALMACEN";
            this.colCODALMACEN.Visible = true;
            this.colCODALMACEN.VisibleIndex = 0;
            this.colCODALMACEN.Width = 94;
            // 
            // colIDENT
            // 
            this.colIDENT.FieldName = "IDENT";
            this.colIDENT.MinWidth = 25;
            this.colIDENT.Name = "colIDENT";
            this.colIDENT.Visible = true;
            this.colIDENT.VisibleIndex = 1;
            this.colIDENT.Width = 94;
            // 
            // colCOD_LOTE
            // 
            this.colCOD_LOTE.Caption = "COD_LOTE";
            this.colCOD_LOTE.FieldName = "COD_LOTE";
            this.colCOD_LOTE.MinWidth = 25;
            this.colCOD_LOTE.Name = "colCOD_LOTE";
            this.colCOD_LOTE.Visible = true;
            this.colCOD_LOTE.VisibleIndex = 2;
            this.colCOD_LOTE.Width = 94;
            // 
            // colLOTE
            // 
            this.colLOTE.Caption = "LOTE";
            this.colLOTE.FieldName = "LOTE";
            this.colLOTE.MinWidth = 25;
            this.colLOTE.Name = "colLOTE";
            this.colLOTE.Visible = true;
            this.colLOTE.VisibleIndex = 3;
            this.colLOTE.Width = 94;
            // 
            // dBAlmaceneschBindingSource
            // 
            this.dBAlmaceneschBindingSource.DataSource = typeof(Inventario.App_Code.Model.ALMACENESCH);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(35, 289);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_ClickAsync);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(35, 248);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmKonparaketa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.gridControl1);
            this.Name = "FrmKonparaketa";
            this.Text = "FrmKonparaketa";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.entityServerModeSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBAlmaceneschBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.BindingSource dBAlmaceneschBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colCODALMACEN;
        private DevExpress.XtraGrid.Columns.GridColumn colIDENT;
        private DevExpress.Data.Linq.EntityServerModeSource entityServerModeSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private DevExpress.XtraGrid.Columns.GridColumn colCOD_LOTE;
        private DevExpress.XtraGrid.Columns.GridColumn colLOTE;
    }
}