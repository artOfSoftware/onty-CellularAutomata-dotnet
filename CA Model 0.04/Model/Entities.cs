using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.Model
{



	//public class State
	//{
	//	string name;
	//}

	//public class States
	//{
	//	List<State> states;
	//}


	public class CAPoint
	{
		public int x,y;

		#region Ctors
		public CAPoint( int x, int y)
		{
			this.x = x;
			this.y = y;
		}
		public CAPoint(CAPoint p)
		{
			this.x = p.x;
			this.y = p.y;
		}
		#endregion

		#region Static
		public static CAPoint AddVector(CAField field, CAPoint p, CAVector v)
		{
			CAPoint p2 = new CAPoint(p);
			p2.x = p.x + v.i;
			p2.y = p.y + v.j;

			// handle case of too far in positive direction
			if (p2.x >= field.sizeX) p2.x = p2.x % field.sizeX;
			if (p2.y >= field.sizeY) p2.y = p2.y % field.sizeY;

			// handle case of too far in negative direction
			while (p2.x < 0)
				p2.x = p2.x + field.sizeX;

			while (p2.y < 0)
				p2.y = p2.y + field.sizeY;

			return p2;
		}
		#endregion

	}

	public class CAVector : CAExpression
	{
		public int i,j;

		#region Ctor
		public CAVector( int i, int j)
		{
			this.i = i;
			this.j = j;
		}
		#endregion


		public override int Evaluate(CAField f, CAPoint p)
		{
			CAPoint p2 = CAPoint.AddVector(f, p, this);
			return f.GetDataAt(p2);
		}

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendFormat("CAVector({0},{1})",i,j);
			return sb.ToString();
		}
	}


}
