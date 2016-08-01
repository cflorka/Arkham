using System;
namespace SimpleEvent
{
    public delegate void MyHandler1(object sender, MyEvent e);

    public class MyEvent : EventArgs
    {
        public string message;
    }

}