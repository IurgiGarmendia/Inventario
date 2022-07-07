﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventario
{
    public partial class FrmAlmacen : Form
    {
        public FrmAlmacen()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.GetEnumerable += pLinqInstantFeedbackSource1_GetEnumerable;
            // This line of code is generated by Data Source Configuration Wizard
            this.pLinqInstantFeedbackSource1.DismissEnumerable += pLinqInstantFeedbackSource1_DismissEnumerable;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_GetEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Instantiate a new DataContext
            Inventario.App_Code.Model.Alamcen dataContext = new Inventario.App_Code.Model.Alamcen();
            // Assign a queryable source to the PLinqInstantFeedbackSource
            e.Source = dataContext.DBEntradaAlmas;
            // Assign the DataContext to the Tag property,
            // to dispose of it in the DismissEnumerable event handler
            e.Tag = dataContext;
        }

        // This event is generated by Data Source Configuration Wizard
        void pLinqInstantFeedbackSource1_DismissEnumerable(object sender, DevExpress.Data.PLinq.GetEnumerableEventArgs e)
        {

            // Dispose of the DataContext
            ((Inventario.App_Code.Model.Alamcen)e.Tag).Dispose();
        }
    }
}
