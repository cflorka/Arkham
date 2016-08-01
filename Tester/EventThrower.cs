using System;
namespace SimpleEvent
{
	public class Thrower
	{
    static void Main(string[] args)
    {
        Thrower p = new Thrower(args);
    }

    public Thrower(string[] args)
    {
        Console.WriteLine("From Console: Creating DLL");
        WorkerDLL wd = new WorkerDLL();

        Console.WriteLine("From Console: Wiring up event handler");
        WireEventHandlers(wd);

        Console.WriteLine("From Console: Doing the work");
        wd.DoWork();

        Console.WriteLine("From Console: Done");
    }

    private void WireEventHandlers(WorkerDLL wd)
    {
        MyHandler1 handler = new MyHandler1(OnHandler1);
        wd.Event1 += handler;
    }

    public void OnHandler1(object sender, MyEvent e)
    {
        Console.WriteLine(e.message);
    }
	}
}