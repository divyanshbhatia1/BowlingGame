using System.Collections.Generic;
using System.Linq;

namespace BowlingGame
{
	public class Game
	{
		private List<int> allRoles = new List<int>();
		private int currentIndex = 0;
		public void Roll(int v)
		{
			allRoles.Add(v);
		}

		public int Score()
		{
			int _score = 0;
			for (var i = 0; i < 10; i++)
			{
				if (IsStrike())
				{
					_score += 10 + StrikeBonus();
					currentIndex++;
				}
				else if (IsSpare())
				{
					_score += 10 + SpareBonus();
					currentIndex += 2;
				}
				else
				{
					_score += SumOfBallsInFrame();
					currentIndex += 2;
				}
			}
			return _score;
		}

		private int SumOfBallsInFrame()
		{
			return allRoles[currentIndex] + allRoles[currentIndex + 1];
		}

		private int SpareBonus()
		{
			return allRoles[currentIndex + 2];
		}

		private bool IsSpare()
		{
			return allRoles[currentIndex] + allRoles[currentIndex + 1] == 10;
		}

		private int StrikeBonus()
		{
			return allRoles[currentIndex + 1] + allRoles[currentIndex + 2];
		}

		private bool IsStrike()
		{
			return allRoles[currentIndex] == 10;
		}
	}
}
