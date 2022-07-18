using System;
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
    public partial class Form1 : Form
    {
        EntityInner _frmInner = null;
        Frmbigarrena _frmBigarrena = null;
        FrmKonparaketa _frmKonparaketa = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            FrmAlmacen frmAlmacen = new FrmAlmacen();
            frmAlmacen.Show();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            XtraFormMovspz xtraFormMovspz = new XtraFormMovspz() { Text = "formIzena" };
            xtraFormMovspz.Show();

            xtraFormMovspz.FormClosing+= CloseHandler;
        }


        private void CloseHandler(object sender, FormClosingEventArgs e)
        {
            //XtraFormMovspz bidaltzailea= (XtraFormMovspz)sender;


            ////if (((XtraFormMovspz)sender).DialogResult == DialogResult.OK)
            //if (bidaltzailea.Text == "formIzena")
            //{
            //    try
            //    {
            //        MessageBox.Show("Form Izena: "+bidaltzailea.Text);





            //    }
            //    catch (Exception ex)
            //    {
            //        HandleExcepton(ex);
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("else " + bidaltzailea.Name);
            //}

            MessageBox.Show("Itxi " );
        }

        private void HandleExcepton(Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //https://gist.github.com/symphonicsky/1206406
            EventSubscriber eventSubscriber = new EventSubscriber();
        }

        private void barButtonItem4_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
            EventsExample eventsExample = new EventsExample();
            eventsExample.Show();
            eventsExample.FormClosing += CloseHandler;
        }

        private void barButtonItem5_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isFormOpen = IsAlreadyOpen(typeof(EntityInner));
            if (isFormOpen == false)
            {
                _frmInner = new EntityInner();
                _frmInner.innerEventHandler += _frmInner_innerEventHandler;
                _frmInner.Show();
                _frmInner.FormClosing += CloseHandler;
            }

            isFormOpen = IsAlreadyOpen(typeof(Frmbigarrena));
            if (isFormOpen == false)
            {
                _frmBigarrena = new Frmbigarrena();
                _frmBigarrena.Show();
                _frmBigarrena.FormClosing += CloseHandler;
            }

            
        }

        private void _frmInner_innerEventHandler(object sender, MyArguments e)
        {
            label1.Text = "inner gridean aukeratua: " + e.MyVal1 + " eta " + e.MyVal2;
            if(_frmBigarrena!=null)
                _frmBigarrena.labelEguneratu(e);
        }

        private bool IsAlreadyOpen(Type formType)

        {

            bool isOpen = false;



            foreach (Form f in Application.OpenForms)

            {

                if (f.GetType() == formType)

                {

                    f.BringToFront();

                    f.WindowState = FormWindowState.Normal;

                    isOpen = true;

                }

            }


            return isOpen;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(_frmInner!=null)
                _frmInner.filterInner("ATALLU");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_frmInner != null)
                _frmInner.filterInner("TECNICHAPA");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (_frmInner != null)
                _frmInner.filterInner("ARCELOR");
        }

        private void barButtonItem6_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bool isFormOpen = IsAlreadyOpen(typeof(FrmKonparaketa));
            if (isFormOpen == false)
            {
                _frmKonparaketa = new FrmKonparaketa();

                _frmKonparaketa.Show();
                _frmKonparaketa.FormClosing += CloseHandler;
            }
        }
    }
}
