using System;
using System.Threading;
//using System.Timers;
					
public class Program
{
	public static void aSecond()
	{
		Console.WriteLine("second");
	}
	
	public static void Main()
	{
		var timer1 = new Timer((e) => aSecond(), null, 0, 100000);
		//Timer timer2 = new Timer();
		//timer2.Interval = 10000;
		//timer2.Elapsed += aSecond;
		//timer2.Start();
		Thread.Sleep(8000);
	}
}
