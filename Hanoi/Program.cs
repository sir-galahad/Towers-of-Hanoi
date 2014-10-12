/*
 * Created by SharpDevelop.
 * User: aaron
 * Date: 8/16/2014
 * Time: 5:55 PM
 * 
 * 
 */
using System;

namespace Hanoi
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Hello World!");
			
			Hanoi h=new Hanoi(14);
			h.Start();
			Console.WriteLine("DONE!");
			
			Console.ReadKey(true);
		}
	}
}