using RockPaperScissorsRepo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RockPaperScissors
{
	public class ProgramUI
	{
		private Player _player = new Player();
		private Player _cpu = new Player();
		RockPaperScissorsRepository _repo = new RockPaperScissorsRepository();

		public void Run()
		{
			Console.Clear();
			Console.WriteLine(_player.LastMove);
			Console.WriteLine("Enter your move\n1. Rock\n2. Paper\n3. Scissors");
			var input = int.Parse(Console.ReadLine());

			switch (input)
			{
				case 1:
					_player.Move = Move.Rock;
					break;
				case 2:
					_player.Move = Move.Paper;
					break;
				case 3:
					_player.Move = Move.Scissors;
					break;
			}

			Console.Clear();
			Thread.Sleep(500);
			Console.WriteLine("3");
			Thread.Sleep(500);
			Console.Clear();
			Console.WriteLine("2");
			Thread.Sleep(500);
			Console.Clear();
			Console.WriteLine("1");
			Thread.Sleep(500);
			Console.Clear();

			_cpu.Move = _repo.GetMove();

			Console.WriteLine(_repo.CalculateMove(_player.Move, _cpu.Move));
			_player.LastMove = _player.Move.ToString();
			Console.WriteLine($"Your Move {_player.Move}\nCPU's Move {_cpu.Move}");

			Console.ReadKey();
			Run();
		}
	}
}
