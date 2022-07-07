using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventario
{
    class EventClass
    {
        //This is our "signature" for which all event handlers that want to subscribe to our event must match
        public delegate void EventFiredHandler();
        //we define our event here, using our "signature" we created above
        public event EventFiredHandler EventFired;
        //simple method to trigger the event
        public void Fire()
        {
            //here we make sure that we have "subscribers", if we did not check we could generate an exception
            if (EventFired != null)
            {
                int n = 0;
                while (n < 30)
                {
                    if (n > 25)
                    { 
                        EventFired();
                        //EventFired?.Invoke();
                    }
                    n++;
                }

            }
            

               
        }



        //This is our "signature" for which all event handlers that want to subscribe to our event must match
        public delegate int EventFiredHandlerInt(string agurra);
        //we define our event here, using our "signature" we created above
        public event EventFiredHandlerInt EventFiredInt;
        //simple method to trigger the event
        public void FireBerria()
        {
            //here we make sure that we have "subscribers", if we did not check we could generate an exception
            if (EventFiredInt != null)
            {
                int n = 0;
                while (n < 30)
                {
                    if (n > 25)
                        EventFiredInt(n+" agurra");
                        //EventFiredInt?.Invoke(n + " agurra");
                    n++;
                }

            }

        }
        //https://www.youtube.com/watch?v=841BAFuoXGE
        public event EventHandler<MyArguments> SampleEventHandler;
        public void FireEventHandler(int val1, string val2)
        {
            MyArguments args = new MyArguments();
            args.MyVal1 = val1;
            args.MyVal2 = val2;
            SampleEventHandler?.Invoke(null, args);
        }


        



    }
}
