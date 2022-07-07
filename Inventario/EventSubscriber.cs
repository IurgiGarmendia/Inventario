using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class EventSubscriber
    {

        //ejemplo delegado
        public delegate void MiDelegado(string mensaje);
        public MiDelegado miDelegado ;
        

        public EventSubscriber()
        {
            EventClass eventClass = new EventClass();
            //register or "subscribe" to eventClass's event
            eventClass.EventFired += new EventClass.EventFiredHandler(eventClass_EventFired);
            //calling this method would fire the event within the EventClass and since we are now subscribed with out eventClass_EventFired handler, it will fire as well
            eventClass.Fire();

            //eventClass.EventFiredInt += EventClass_EventFiredInt();
            eventClass.EventFiredInt += EventClass_EventFiredInt1;
            eventClass.FireBerria();


            eventClass.SampleEventHandler += adibideEventHandler;

            eventClass.FireEventHandler(5, "eventhandler");

            miDelegado = new MiDelegado(mezuaErakutsi);


            miDelegado("(delegatuak ) hau guzia zertarako?");
            miDelegado("(delegatuak 2) hau guzia zertarako2?");

            MiDelegado miDelegado1 = new MiDelegado(mezuaErakutsi2);
            miDelegado1("(delegatu berria 2) hau guzia zertarako3?");

            EventsExample eventsExample = new EventsExample();
            eventsExample.SampleEventHandler2 += EventsExample_SampleEventHandler2;
            eventsExample.Show();
            


        }

        private void EventsExample_SampleEventHandler2(object sender, MyArguments e)
        {
            System.Windows.Forms.MessageBox.Show($"event handler adibide: val1: { e.MyVal1 }, val2: { e.MyVal2  }");
        }

        private void mezuaErakutsi2(string mensaje)
        {
            System.Windows.Forms.MessageBox.Show(mensaje);
        }

        private void mezuaErakutsi(string mensaje)
        {
            System.Windows.Forms.MessageBox.Show(mensaje); 
        }

        private int EventClass_EventFiredInt1(string agurra)
        {
            System.Windows.Forms.MessageBox.Show(agurra);
            return 1;
        }

        private int EventClass_EventFiredInt()
        {
            System.Windows.Forms.MessageBox.Show("event fired int");
            return 1;
        }

        //this method or "handler" matches the signature of the delegate we created on the EventClass
        private void eventClass_EventFired()
        {
            System.Windows.Forms.MessageBox.Show("event fired" );
        }

        private void adibideEventHandler(object sender, MyArguments e)
        {
            System.Windows.Forms.MessageBox.Show($"event handler adibide: val1: { e.MyVal1 }, val2: { e.MyVal2  }");
        }
    }
}
