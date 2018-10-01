using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsRepo
{
	public enum Move
	{
		Rock, Paper, Scissors
	}

	public class RockPaperScissorsRepository
	{
		public Move GetMove()
		{
			return (Move)(new Random().Next(0, 3));
		}

		public string CalculateMove(Move playerMove, Move cpuMove)
		{
			if(playerMove == Move.Rock && cpuMove == Move.Scissors)
			{
				return "You win";
			}
			else if(playerMove == Move.Scissors && cpuMove == Move.Paper)
			{
				return "You win";
			}
			else if(playerMove == Move.Paper && cpuMove == Move.Rock)
			{
				return "You Win";
			}
			else if(playerMove == cpuMove)
			{
				return "Its a draw";
			}
			else
			{
				return "You lost";
			}
		}
	}
}
