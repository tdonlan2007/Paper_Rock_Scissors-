using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsRepo
{
	public class Player
	{
		public int WinStreak { get; set; }

		public string LastMove { get; set; }

		public Move Move { get; set; }
	}
}
