/*
 * Created by SharpDevelop.
 * User: aaron
 * Date: 8/16/2014
 * Time: 9:28 PM
 * 
 * 
 */
using System;
using System.Text;
using System.Collections.Generic;
namespace Hanoi
{
	/// <summary>
	/// this class implements and solves the "Towers of Hanoi" by way of a recursive method
	/// </summary>
	
	public class Hanoi
	{
		int moves=0;
		int stackDepth=0;
		Stack<int>[] poles=new Stack<int>[3];
		int discnum;
		public Hanoi(int discnum)
		{
			this.discnum=discnum;
			for(int x=0;x<3;x++){
				poles[x]=new Stack<int>(discnum);
			}
			for(int x=discnum;x>0;x--){
				poles[0].Push(x);
			}
		}
		public void DisplayStatus(){
			
			int sixth=Console.WindowWidth/6;
			Console.Clear();
			ConsoleExtenions.WriteStringAt(moves.ToString(),0,0);
			ConsoleExtenions.WriteStringAt(String.Format("Recurse Level:{0}",stackDepth),10,1);
			for(int x=0;x<3;x++){
				int y=0;
				string str="X";
				foreach(int disc in poles[x]){
					ConsoleExtenions.CenterStringAt(DisplayGetString(disc),sixth*(x*2+1),Console.WindowHeight-poles[x].Count+y);
					str+="XX";
					y++;
				}
			}
		}
		string DisplayGetString(int disc){
			StringBuilder sb=new StringBuilder();
			sb.Append('X');
			for(int x=1;x<disc;x++){
				sb.Append("XX");
			}
			return sb.ToString();
		}
		
		public void Start(){
			MoveDiscs(discnum+2,poles[0],poles[2],poles[1]);
		}
		
		public void MoveDiscs(int depthToMove,Stack<int> source,Stack<int> dest, Stack<int> buffer){
			stackDepth++;
			if(depthToMove==1){
				dest.Push(source.Pop());
				DisplayStatus();
				moves++;
			}else{
				for(int x=depthToMove-1;x>1;x--){
					MoveDiscs(x,source,buffer,dest);
					dest.Push(source.Pop());
					moves++;
					Stack<int> tmp=source;
					source=buffer;
					buffer=tmp;
					DisplayStatus();
					System.Threading.Thread.Sleep(100); //just to make it so the screen isn't 
														//refreshed faster than that eye can see
				}
				
			}
			stackDepth--;
		}
	}
}
