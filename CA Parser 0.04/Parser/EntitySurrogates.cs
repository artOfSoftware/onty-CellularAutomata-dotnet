using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.Parser
{

	public abstract class CAParserTemp
	{
	}

	public class CAParserTempFunction : CAParserTemp
	{
		public string name;
		public List<CAParserTemp> args;

		public CAParserTempFunction()
		{
			args = new List<CAParserTemp>();
		}
	}

	public class CAParserTempVector : CAParserTemp
	{
		public string vector;
	}

}
