using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.Model
{
	public abstract class CARuleStatic
	{
		protected CAField field;
		public abstract int CalculateTransform(CAPoint p);


	
	}



	public enum CAGameType
	{
		NONE,
		CUSTOM,
		CONWAY,
		NEC_MIN,
		NEC_MAX,
		NEC_MEDIAN,
		SWAP_ZEROS_AND_TWOS

	
	}


	//public class GameRulesForGui
	//{
	//	public class RuleObjectForGui
	//	{
	//		private string name;
	//		private int value;
	//		public RuleObjectForGui( string displayName, int itemValue)
	//		{
	//			this.name  = displayName;
	//			this.value = itemValue;
	//		}

			
	//	}
	//	public GameRulesForGui()
	//	{
	//		GameTypeNames = new String[5];
	//		"Conway",
	//		"NEC Minimum",
	//		"NEC Maximum",
	//		"NEC Median",
	//		"Swap 0s and 2s"
	//	}

	//	public static string[] GameTypeNames;

	//}

	public class CARuleStaticSumEightNeighborsConway : CARuleStatic
	{
		public CARuleStaticSumEightNeighborsConway(CAField f)
		{
			this.field = f;
		}

		public override int CalculateTransform(CAPoint p)
		{
			int newVal;
			//CACalculator c = new CACalculator(field);
			int sum = 0;

			for (int j = -1; j <= 1; j++)
				for (int i = -1; i <= 1; i++)
				{
					if (i == 0 && j == 0) continue;

					CAVector v = new CAVector(i, j);
					CAPoint p2 = CAPoint.AddVector(field,p, v);
					int d = field.GetDataAt(p2);
					if (d == 1)
						sum++;
				}

			newVal = 0;
			int curVal = field.GetDataAt(p);

			if (curVal == 0)
			{
				if (sum == 3)
					newVal = 1;
			}
			else if (curVal == 1)
			{
				if (sum == 3 || sum == 2)
					newVal = 1;
			}
			else
				//throw new Exception("data is not 0 or 1.... hmmmmm.....");
				newVal = int.MinValue;

			return newVal;
		}
	}//class RuleSumEightNeighborsConway



	public class CARuleStaticMinimumNEC : CARuleStatic
	{
		public CARuleStaticMinimumNEC(CAField f)
		{
			this.field = f;
		}

		public override int CalculateTransform(CAPoint p)
		{
			//CACalculator c = new CACalculator(field);
			int min = int.MaxValue;

			CAVector v = new CAVector(0, 1);
			CAPoint p2 = CAPoint.AddVector(field,p, v);
			int d = field.GetDataAt(p2);
			if (d<min)
				min=d;

			v = new CAVector(1, 0);
			p2 = CAPoint.AddVector(field, p, v);
			d = field.GetDataAt(p2);
			if (d < min)
				min = d;

			d = field.GetDataAt(p);
			if (d < min)
				min = d;
			
			return min;
		}
	}//class RuleMinimumNEC


	class CARuleStaticMaximumNEC : CARuleStatic
	{
		public CARuleStaticMaximumNEC(CAField f)
		{
			this.field = f;
		}

		public override int CalculateTransform(CAPoint p)
		{
			//CACalculator c = new CACalculator(field);
			int max = int.MinValue;

			CAVector v = new CAVector(0, 1);
			CAPoint p2 = CAPoint.AddVector(field,p, v);
			int d = field.GetDataAt(p2);
			if (d > max)
				max = d;

			v = new CAVector(1, 0);
			p2 = CAPoint.AddVector(field,p, v);
			d = field.GetDataAt(p2);
			if (d > max)
				max = d;

			d = field.GetDataAt(p);
			if (d > max)
				max = d;

			return max;
		}
	}//class RuleMaximumNEC 



	public class CARuleStaticMedianNEC : CARuleStatic
	{
		public CARuleStaticMedianNEC(CAField f)
		{
			this.field = f;
		}

		public override int CalculateTransform(CAPoint p)
		{
			List<int> values = new List<int>();

			CAVector v = new CAVector(0, 1);
			CAPoint p2 = CAPoint.AddVector(field, p, v);
			int d = field.GetDataAt(p2);
			values.Add(d);

			v = new CAVector(1, 0);
			p2 = CAPoint.AddVector(field, p, v);
			d = field.GetDataAt(p2);
			values.Add(d);

			d = field.GetDataAt(p);
			values.Add(d);

			values.Sort();

			return values[1];
		}
	}//class RuleMaximumNEC 



	public class CARuleStaticSwapTwosAndZeros : CARuleStatic
	{
		public CARuleStaticSwapTwosAndZeros(CAField f)
		{
			this.field = f;
		}

		public override int CalculateTransform(CAPoint p)
		{
			int newVal;

			newVal = field.GetDataAt(p);

			if (newVal == 2)
				newVal = 0;
			else if (newVal == 0)
				newVal = 2;

			return newVal;
		}
	}//class RuleMaximumNEC 



}//ns
