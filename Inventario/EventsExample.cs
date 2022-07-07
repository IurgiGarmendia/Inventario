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
    public partial class EventsExample : Form
    {

        private Button m_nameButton;
        private Button m_clearButton;
        private Label m_nameLabel;
        private Container m_components = null;
        //public EventSubscriber eventSubscriber;
        public EventsExample()
        {
            initializeComponents();
            //eventSubscriber = new EventSubscriber();
        }

        private void initializeComponents()
        {
            m_nameLabel = new Label();
            m_nameButton = new Button();
            m_clearButton = new Button();
            SuspendLayout();
            m_nameLabel.Location = new Point(16, 16);
            m_nameLabel.Text = "Click NAME button, please";
            m_nameLabel.Size = new Size(300, 23);
            m_nameButton.Location = new Point(16, 120);
            m_nameButton.Size = new Size(176, 23);
            m_nameButton.Text = "NAME";
            //Create the delegate, plug in the method, and attach the delegate to the Click event of the button
            //m_nameButton.Click += new System.EventHandler(NameButtonClicked);
            //https://codingvision.net/c-eventhandler-with-arguments
            string s = "Iurgi jarria";
            m_nameButton.Click += (sender2, e2) => NameButtonClicked(sender2, e2, s);
            m_clearButton.Location = new Point(16, 152);
            m_clearButton.Size = new Size(176, 23);
            m_clearButton.Text = "CLEAR";
            //Create the delegate, plug in the method, and attach the delegate to the Click event of the button
            m_clearButton.Click += new System.EventHandler(ClearButtonClicked);
            this.ClientSize = new Size(292, 271);
            this.Controls.AddRange(new Control[] {

            m_nameLabel, m_nameButton, m_clearButton});
            this.ResumeLayout(false);

            
        }

        //Define the methods whose signature exactly matches with the declaration of the delegate
        //private void NameButtonClicked(object sender, EventArgs e)
        private void NameButtonClicked(object sender, EventArgs e, string s)
        {
            m_nameLabel.Text = "My name is john, please click CLEAR button to clear it "+ s;
        }
        private void ClearButtonClicked(object sender, EventArgs e)
        {
            m_nameLabel.Text = "Click NAME button, please";
            Fire(1,"formularioko botoitik deitua");
        }
        public event EventHandler<MyArguments> SampleEventHandler2;
        private void Fire(int val1, string val2)
        {
            MyArguments args = new MyArguments();
            args.MyVal1 = val1;
            args.MyVal2 = val2;
            //SampleEventHandler2?.Invoke(null, args);
            if (SampleEventHandler2 != null)
                SampleEventHandler2(null, args);


        }

        //public static void Main()
        //{
        //    Application.Run(new EventsExample());
        //}

    }
}
