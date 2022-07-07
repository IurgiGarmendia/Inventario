﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Data.PLinq;
//https://www.c-sharpcorner.com/UploadFile/ff2f08/entity-splitting-in-entity-framework-6-code-first-approach/


namespace Inventario
{
    public partial class EntityInner : Form
    {
        private string _filtering="";
        DevExpress.Data.PLinq.PLinqInstantFeedbackSource _nerePLinkiu;

        public EntityInner()
        {
            InitializeComponent();


            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.GetEnumerable += pLinqInstantFeedbackSource1_GetEnumerable;
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.DismissEnumerable += pLinqInstantFeedbackSource1_DismissEnumerable;

            _nerePLinkiu = new DevExpress.Data.PLinq.PLinqInstantFeedbackSource();
            _nerePLinkiu.GetEnumerable += nerePLinkiu_GetEnumerable;
        }

        private void nerePLinkiu_GetEnumerable(object sender, GetEnumerableEventArgs e)
        {
            Inventario.App_Code.Model.QueryInner dataContext = new Inventario.App_Code.Model.QueryInner();
            e.Source = from a in dataContext.DBLotes
                       join b in dataContext.DBAlmacenesch on a.CODALMACEN equals b.CODALMACEN into gj
                       from subpet in gj.DefaultIfEmpty()//left outer join egiteko
                       where subpet.IDENT==_filtering
                       select new { a.COD_LOTE, a.LOTE, a.CODALMACEN, IDENT = subpet.IDENT};


            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissEnumerable event handler
            //e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Instantiate a new DataContext
            Inventario.App_Code.Model.QueryInner dataContext1 = new Inventario.App_Code.Model.QueryInner();
            //// Assign a queryable source to the PLinqInstantFeedbackSource
            //e.Source = from a in dataContext.DBLotes
            //           join b in dataContext.DBAlmacenesch on a.CODALMACEN equals b.CODALMACEN
            //           select new { a.COD_LOTE, a.LOTE, a.CODALMACEN, b.IDENT };

            e.Source = from a in dataContext1.DBLotes
                       join b in dataContext1.DBAlmacenesch on a.CODALMACEN equals b.CODALMACEN into gj
                       from subpet in gj.DefaultIfEmpty()//left outer join egiteko
                       select new { a.COD_LOTE, a.LOTE, a.CODALMACEN, IDENT = subpet.IDENT };


            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissEnumerable event handler
            e.Tag = dataContext1;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_DismissEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Dispose of the DataContext
            ((Inventario.App_Code.Model.QueryInner)e.Tag).Dispose();
        }

        public void filterInner(string filtro)
        {
            gridControl1.DataSource = null;
            _filtering = filtro;
            gridControl1.DataSource = _nerePLinkiu;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gridControl1.DataSource = null;
            _filtering = "ATALLU";
            gridControl1.DataSource = _nerePLinkiu;
        }
    }
}
