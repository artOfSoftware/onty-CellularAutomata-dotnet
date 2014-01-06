using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.Model
{

	public abstract class CAExpression
	{
		public static int MAX_ARRAY_SIZE = 8;
		public abstract int Evaluate(CAField f, CAPoint p);

		public abstract override string ToString();
	
	}

	public abstract class CARule : CAExpression
	{
		//protected CAField field;
		protected List<CAExpression> args;


		public void SpecifyArguments(List<CAExpression> args)
		{
			// copy vectors
			this.args = new List<CAExpression>(args.Count);
			this.args.AddRange(args);
		}


		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();

			sb.Append("This is a CARuleMedian with args");

			foreach (CAExpression e in args)
			{
				if (e is CAVector)
				{
					sb.Append(" vector ");
					sb.Append(e.ToString());
				}
				else if (e is CAExpression)
				{
					sb.Append(" expr ");
					sb.Append(e.ToString());
				}
				else
				{
					sb.Append(" ??? ");
					sb.Append(e.ToString());
				}

			}

			sb.Append(".");

			return sb.ToString();
		}
	}



	public class CARuleMedian : CARule
	{
		public CARuleMedian()
		{
		}

		public override int Evaluate(CAField field, CAPoint p)
		{
			// check that list of args is non-empty
			if (args.Count == 0)
				throw new Exception("empty list of args in CARuleMedian.Evaluate");

			int[] values = new int[MAX_ARRAY_SIZE];
			int valuesIdx = 0;

			foreach ( CAExpression e in args )
			{
				values[valuesIdx++] = e.Evaluate(field, p);
			}

			Array.Sort(values);
			int indexMid = valuesIdx / 2;

			return values[indexMid];
		}

	}//class CARuleMedian 



	public class CARuleMaximum : CARule
	{
		public CARuleMaximum()
		{
		}

		public override int Evaluate(CAField field, CAPoint p)
		{
			// check that list of args is non-empty
			if (args.Count == 0)
				throw new Exception("empty list of args in CARuleMaximum.Evaluate");

			int max = int.MinValue;

			foreach (CAExpression e in args)
			{
				int v = e.Evaluate(field, p);
				if (v > max)
					max = v;
			}

			return max;
		}
	}//class CARuleMaximum 



	public class CARuleMinimum : CARule
	{
		public CARuleMinimum()
		{
		}

		public override int Evaluate(CAField field, CAPoint p)
		{
			// check that list of args is non-empty
			if (args.Count == 0)
				throw new Exception("empty list of args in CARuleMaximum.Evaluate");

			int min = int.MaxValue;

			foreach (CAExpression e in args)
			{
				int v = e.Evaluate(field, p);
				if (v < min)
					min = v;
			}

			return min;
		}
	}//class CARuleMinimum 


}//ns
