using System;
using System.Collections.Generic;
using System.Text;

namespace DelegadosEventosCS
{ 
    
    public delegate void EventHandler(object sender, System.EventArgs e);
    
    public class Button
    {
        public event EventHandler Click;
        public void Reset()
        {
            Click = null;
        }
    }
}
//the 
//Button
// class defines a 
//Click
// event of type 
//EventHandler
//. Inside the 
//Button
// class, the 
//Click
// member is exactly like a private field of type 
//EventHandler
//. However, outside the 
//Button
// class, the 
//Click
// member can only be used on the left-hand side of the 
//+=
// and 
//-=
// operators. The 
//+=
// operator adds a handler for the event, and the 
//-=
// operator removes a handler for the event. The example

