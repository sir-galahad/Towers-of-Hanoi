/*
 * Created by SharpDevelop.
 * User: aaron
 * Date: 8/16/2014
 * Time: 7:02 PM
 * 
 */
using System;

namespace Hanoi
{
	public  static class ConsoleExtenions{
		public static void Locate(int x, int y){
			Console.CursorLeft=x;
			Console.CursorTop=y;
		}
		public static void WriteStringAt(string str,int x, int y){
			Console.CursorLeft=x;
			Console.CursorTop=y;
			Console.Write(str);
		}
		public static void CenterStringAt(string str,int x,int y){
			int half=str.Length/2;
			x=x-half;
			Console.CursorLeft=x;
			Console.CursorTop=y;
			Console.Write(str);
		}
	}
}