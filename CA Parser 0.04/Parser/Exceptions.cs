using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.Parser
{

	public class CAParserException : Exception
	{
		public CAParserException(string message)
			: base(message)
		{ }

		public CAParserException(string message, Exception innerException)
			: base(message, innerException)
		{ }

	}

}
