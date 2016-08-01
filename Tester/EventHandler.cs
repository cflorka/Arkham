using System;
namespace SimpleEvent
{
    class WorkerDLL
    {
        public event MyHandler1 Event1;

        public WorkerDLL()
        {
        }

        public void DoWork()
        {
            FireEvent("From Worker: Step 1");
            FireEvent("From Worker: Step 5");
            FireEvent("From Worker: Step 10");
        }

        private void FireEvent(string message)
        {
            MyEvent e1 = new MyEvent();
            e1.message = message;

            if (Event1 != null)
            {
                Event1(this, e1);
            }

            e1 = null;
        }
    }
}