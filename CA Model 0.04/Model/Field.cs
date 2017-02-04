using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.Model
{
	public class CAField
	{
		// has:
		// Dimensions
		//   axis name
		//   unit vector name
		//   boundaries config
		// Automata States
		// Rules
		// FieldInit

		public int[,] data = null;
		public int[,] dataNew = null;
		public int sizeX, sizeY;
		public int time;

		public CAField(int sizeX, int sizeY)
		{
			this.sizeX = sizeX;
			this.sizeY = sizeY;
			this.data = new int[sizeX, sizeY];
			this.time = 0;
		}

		public bool IsInitialized()
		{
			return (data != null);
		}

		public int GetDataAt(CAPoint p)
		{
			return data[p.x, p.y];
		}

		public void DoTransform( CAGameType whichRule )
		{
			CARuleStatic rule;

			if (whichRule == CAGameType.CONWAY)
				rule = new CARuleStaticSumEightNeighborsConway(this);
			else if (whichRule == CAGameType.NEC_MAX)
				rule = new CARuleStaticMaximumNEC(this);
			else if (whichRule == CAGameType.NEC_MIN)
				rule = new CARuleStaticMinimumNEC(this);
			else if (whichRule == CAGameType.NEC_MEDIAN)
				rule = new CARuleStaticMedianNEC(this);
			else if (whichRule == CAGameType.SWAP_ZEROS_AND_TWOS)
				rule = new CARuleStaticSwapTwosAndZeros(this);
			else
				throw new Exception("Unknown Rule, cannot continue");

			dataNew = new int[sizeX, sizeY];

			for (int y = 0; y < sizeY; y++)
				for (int x = 0; x < sizeX; x++)
				{
					CAPoint p = new CAPoint(x, y);
					int newVal = rule.CalculateTransform(p);
					dataNew[p.x, p.y] = newVal;
				}
			time++;
			data = dataNew;
			dataNew = null;
		}

		public void DoTransform(CARule rule)
		{
			dataNew = new int[sizeX, sizeY];

			for (int y = 0; y < sizeY; y++)
				for (int x = 0; x < sizeX; x++)
				{
					CAPoint p = new CAPoint(x, y);
					int newVal = rule.Evaluate(this, p);
					dataNew[p.x, p.y] = newVal;
				}
			time++;
			data = dataNew;
			dataNew = null;
		}


		#region Init functions
		public void InitRandom( int min, int max )
		{
			Random r = new Random(System.DateTime.Now.Millisecond);
			for (int y = 0; y < sizeY; y++)
				for (int x = 0; x < sizeX; x++)
					data[x, y] = r.Next(max-min+1) + min;
		}

		public void InitBar()
		{
			try
			{
				data[4, 5] = 1;
				data[5, 5] = 1;
				data[6, 5] = 1;

				data[4, 15] = 2;
				data[5, 15] = 2;
				data[6, 15] = 2;

				data[4, 25] = 2;
				data[5, 25] = 1;
				data[6, 25] = 2;
			}
			catch ( Exception )
			{ }
		}


		public void InitDiamond()
		{
			// first determine if horizontal or vert is smaller. use smaller dimansion as a guide.
			int sizeMax = sizeY;
			int shiftY = 0;
			if (sizeX < sizeMax)
			{
				sizeMax = sizeX;
				shiftY = (sizeY - sizeX) / 2;
			}

			// draw 1's
			int yTop    = sizeMax * 5/6 + shiftY;
			int yBottom = sizeMax * 1/6 + shiftY;
			int xMid    = sizeX / 2;

			int x1, x2, y1=0, y2=0;

			for (int dy = 0; ; dy++)
			{
				y1 = yTop - dy;
				y2 = yBottom + dy;

				if (y1 < y2)
					break;

				for (int dx = 0; dx <= dy; dx++)
				{
					x1 = xMid + dx;
					x2 = xMid - dx;
					data[x1, y1] = 1;
					data[x1, y2] = 1;
					data[x2, y1] = 1;
					data[x2, y2] = 1;
				}
			}


			// draw 2's

			yTop    = sizeMax * 4/6 + shiftY;
			yBottom = sizeMax * 2/6 + shiftY;
			xMid    = sizeX / 2;

			y1 = 0;
			y2 = 0;

			for (int dy = 0; ; dy++)
			{
				y1 = yTop - dy;
				y2 = yBottom + dy;

				if (y1 < y2)
					break;

				for (int dx = 0; dx <= dy; dx++)
				{
					x1 = xMid + dx;
					x2 = xMid - dx;
					data[x1, y1] = 2;
					data[x1, y2] = 2;
					data[x2, y1] = 2;
					data[x2, y2] = 2;
				}
			}

		
		}//method InitDiamond()


		public void InitCircle()
		{
			// first determine if horizontal or vert is smaller. use smaller dimansion as a guide.
			int sizeMax = sizeY;
			int shiftY = 0;
			if (sizeX < sizeMax)
			{
				sizeMax = sizeX;
				shiftY = (sizeY - sizeX) / 2;
			}

			// draw 1's
			double yTop = sizeMax * 5 / 6 + shiftY;
			double yBottom = sizeMax * 1 / 6 + shiftY;
			double xMid = sizeX / 2;
			double yMid = sizeY / 2;

			double x1, x2, y1 = 0, y2 = 0;
			double hyp = yTop-yMid;

			for (int dy = 0; ; dy++)
			{
				y1 = yTop - dy;
				y2 = yBottom + dy;

				if (y1 < y2)
					break;

				// do math
				double lv = (double) y1 - yMid;
				double angle = Math.Asin(lv / hyp);
				double lh = Math.Cos(angle);

				int dxMax = (int) (lh*hyp);

				for (double dx = 0; dx <= dxMax; dx++)
				{
					x1 = xMid + dx;
					x2 = xMid - dx;
					data[(int)x1, (int)y1] = 1;
					data[(int)x1, (int)y2] = 1;
					data[(int)x2, (int)y1] = 1;
					data[(int)x2, (int)y2] = 1;
				}
			}


			//// draw 2's

			yTop = sizeMax * 4 / 6 + shiftY;
			yBottom = sizeMax * 2 / 6 + shiftY;
			xMid = sizeX / 2;
			yMid = sizeY / 2;

			y1 = 0;
			y2 = 0;
			hyp = yTop - yMid;

			for (int dy = 0; ; dy++)
			{
				y1 = yTop - dy;
				y2 = yBottom + dy;

				if (y1 < y2)
					break;

				// do math
				double lv = (double)y1 - yMid;
				double angle = Math.Asin(lv / hyp);
				double lh = Math.Cos(angle);

				int dxMax = (int)(lh * hyp);

				for (double dx = 0; dx <= dxMax; dx++)
				{
					x1 = xMid + dx;
					x2 = xMid - dx;
					data[(int)x1, (int)y1] = 2;
					data[(int)x1, (int)y2] = 2;
					data[(int)x2, (int)y1] = 2;
					data[(int)x2, (int)y2] = 2;
				}
			}

		}//method InitCircle()


		public void InitHalfZeroHalfTwo()
		{
			int xMid = sizeX / 2;
			//int yMid = sizeY / 2;

			for (int y=0; y<sizeY; y++)
			{
				for (int x=0; x<xMid; x++)
					data[x, y] = 0;
				for (int x = xMid; x < sizeX; x++)
					data[x, y] = 2;
			}

		}//method InitHaldZeroHalfTwo()


		#endregion

		public override string ToString()
		{
			StringBuilder sb = new StringBuilder();
			string spacing = "";

			sb.AppendLine( GetTitle() );

			for (int y = sizeY-1; y >= 0; y--)
			{
				for (int x = 0; x < sizeX; x++)
				{
					int d = data[x, y];
					string ds;

					switch (d)
					{
						case 0:
							ds = " ";
							break;
						case 1:
							ds = "1";
							break;
						case 2:
							ds = "2";
							break;
						default:
							ds = "?";
							break;

					}

					sb.Append(ds);
					sb.Append(spacing);
				}
				sb.AppendLine();
			}

			return sb.ToString();
		}//ToString


		public string GetTitle()
		{
			return String.Format("At t={0} the field is:", time);
		}


	}
}
