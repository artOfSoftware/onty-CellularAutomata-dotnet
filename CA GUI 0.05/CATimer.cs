using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Toom.CellularAutomata.GUI
{
	class CATimer
	{
		private long timerStarted;
		
		/// <summary>
		/// Instantiates the timer and starts it.
		/// </summary>
		public CATimer( bool start=false )
		{
			if ( start )
				Start();
		}

		/// <summary>
		/// Starts the timer.
		/// </summary>
		public void Start()
		{
			timerStarted = DateTime.Now.Ticks;
		}

		/// <summary>
		/// Get time (in seconds, as double) since timer's Start() was called.
		/// </summary>
		/// <returns>Time in seconds</returns>
		public double GetS()
		{
			long timerNow = DateTime.Now.Ticks;
			return (timerNow - timerStarted) / 10000000.0;
		}

		/// <summary>
		/// Returns time in seconds, and resets the timer.
		/// </summary>
		/// <returns>Time in seconds</returns>
		public double GetSAndReset()
		{
			long timerNow = DateTime.Now.Ticks;
			double diff = (timerNow - timerStarted) / 10000000.0;
			Start();
			return diff;
		}

	}
}
